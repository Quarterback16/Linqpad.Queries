<Query Kind="Program">
  <Output>DataGrids</Output>
  <Reference>E:\FileSync\SyncProjects\GameLog\RosterService\bin\Release\GameLogService.dll</Reference>
  <Reference>E:\FileSync\SyncProjects\GameLog\RosterService\GridstatsEvents.json</Reference>
  <Reference>E:\FileSync\SyncProjects\GameLog\GameLog.Tests\bin\Release\RetroEvents.json</Reference>
  <Reference>E:\FileSync\SyncProjects\GameLog\RosterService\bin\Release\RosterService.dll</Reference>
  <Namespace>GameLogService.Model</Namespace>
  <Namespace>Gridstats</Namespace>
</Query>

using RosterService;

void Main()
{
	var teamName = "Colonnas Comanches";
	var round = new Gridstats.Round( 2021, "P01" );
	var sendToMd = true;
	
	var rosterContext = new RosterContext
	{
		LosingPoints = 121,
		Protect = 3,
		RunBlock = 3,
		PassRush = 0,
		PassDefence = 4,
		RunDefence = 4
	};
	var rosters = new GridstatsRosters(
		new RosterEventStore("GridstatsEvents.json"),
		null);
	var gsRepo = new GridstatsRepository();

	var s0 = new int[] { 37, 260, 194, 242, 233, 81, 301};
	var b0 = new int[] { 42, 207, 179, 330, 223, 323, 285};
	var (s,b) = gsRepo.AddTurnsheet(
	 	new TurnSheet( round, rosters, rosterContext, (s0,b0), false)

			.Rebid(179, 51, "Kamara at 115 a no go")
			//.Rebid(42, 30, "Cant afford 2 franchise level QBs")
			//.Rebid( 171, 29, "DK was at 46 high for a receiver")
			//.Rebid( 285, 39, "need a 3rd kicker first tho prefs NFC")					
			.Bid( 353, 37, "pick of the rooks")		
			
			.Waive(225, "Cam is injured")
			.Marketing(62, "")
			.Merchandising(20, "")

			.Fast(354, 1, "potential starting Rook")
			
			.Waive(288, "get another starting QB")
			);

	round = new Gridstats.Round(2021, "P02");
		(s, b) = gsRepo.AddTurnsheet(
	 		new TurnSheet(round, rosters, rosterContext, (s0, b0), false)

			.Rebid(42, 30, "Cant afford 2 franchise level QBs")
			//.Rebid( 171, 29, "DK was at 46 high for a receiver")
			//.Rebid( 285, 39, "need a 3rd kicker first tho prefs NFC")					
			.Bid(416, 14, "Drafted PK")

			.Contract(207, 35, "should be good in year 2 will cost 17LP")

			.Fast(51, 1, "stop AI from making mistake and drain funds")
			.Fast(371,1, "back from injury")
			.Fast(275,2, "year 2 on Playoff team")

			.Fast(124, 1, "TE")
			.Waive(288, "get another starting QB")
			.Waive(242, "too beat up now")
			);

	round = new Gridstats.Round(2021, "P03");
	(s, b) = gsRepo.AddTurnsheet(
		 new TurnSheet(round, rosters, rosterContext, (s0, b0), false)

		.Rebid( 171, 29, "DK was at 46 high for a receiver")
		//.Rebid( 285, 39, "need a 3rd kicker first tho prefs NFC")					
		.Bid("Ammendola","Matt", "NJ", 14, "cheap PK")
		

		.Waive(242, "too beat up now")
		.Waive(354, "RBs are so fragile")

		.Fast(124, 1, "TE")
		.Fast(327, 1, "Rookie")
		
		.Waive(288, "get another starting QB")

		);

	round = new Gridstats.Round(2021, "W01");
	(s, b) = gsRepo.AddTurnsheet(
		 new TurnSheet(round, rosters, rosterContext, (s0, b0), false)

		.Rebid(285, 39, "Bills may be better than Ravens")
		.Rebid( 81, 14, "Wages move")					
		//.Bid("Ammendola", "Matt", "NJ", 14, "cheap PK")
		.Q1(37)
		.Q2(327)
		.A1(179)
		.A2(202)
		.B1(207)
		.B2(194)
		.X1(124)
		.X2(262)
		.Y1(201)
		.Y2(323)
		.Z1(81)
		.Z2(233)		

		.Contract( 179, 85, "Could let him go for more funds")
		.Waive( 288, "get another starting QB")
		.Waive( 275, "have 5 stud RBs")

		.Marketing(36)
		);

	var turnSheet = gsRepo
		.TurnSheet(round)
		.ToMarkdown(teamName);

	if (sendToMd)
		SendTurnSheetToObsdian(
			turnSheet,
			round);

	Console.WriteLine(turnSheet);
	Console.WriteLine();
}

void SendTurnSheetToObsdian(
	string turnSheet, 
	Gridstats.Round round)
{
	var filePath = $"d:\\Dropbox\\Obsidian\\ChestOfNotes\\CL {round.Season} {round.WeekCode}.md";

	using (StreamWriter outputFile = new StreamWriter(filePath))
	{
		outputFile.WriteLine(turnSheet);
	}
}

public class GridstatsRepository
{
	public List<TurnSheet> Sheets { get; set; }
	
	public GridstatsRepository()
	{
		Sheets = new List<TurnSheet>();
	}
	
	public (int[] s, int[] b) AddTurnsheet(
		TurnSheet turnsheet)
	{
		Sheets.Add(turnsheet);
		return (turnsheet.StartingLineup(), turnsheet.SecondsLineup() );
	}
	
	public TurnSheet TurnSheet(
		Gridstats.Round round)
	{
		var sheet = Sheets.Where(s => s.Round.Season == round.Season && s.Round.WeekCode == round.WeekCode)
			.FirstOrDefault();
		return sheet;
	}
	
	public int[] Starters(
		Gridstats.Round round)
	{
		var sheet = Sheets.Where(s=>s.Round.Season==2021 && s.Round.WeekCode == "P01")
			.FirstOrDefault();
		return sheet.StartingLineup();
	}

	public int[] Backups(Gridstats.Round round)
	{
		var sheet = Sheets.Where(s => s.Round.Season == 2021 && s.Round.WeekCode == "P01")
			.FirstOrDefault();
		return sheet.SecondsLineup();
	}

}


