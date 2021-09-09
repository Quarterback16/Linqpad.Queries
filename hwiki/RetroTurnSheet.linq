<Query Kind="Program">
  <Output>DataGrids</Output>
  <Namespace>GameLogService.Model</Namespace>
  <Namespace>Gridstats</Namespace>
</Query>

using RosterService;

void Main()
{
	var teamName = "Colonnas De Loreans";
	var round = new Gridstats.Round( 1988, "P01" );
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
	var rosters = new RetroRosters(
		new RosterEventStore(),
		new GameStatsRepository());
	var retroRepo = new RetroRepository();

	var s0 = new int[] { 14, 197, 239, 180, 78, 269, 370};
	var b0 = new int[] { 2, 167, 320, 44, 110, 362, 145 };
	var (s, b) = retroRepo.AddTurnsheet(
		 new TurnSheet(round, rosters, rosterContext, (s0,b0), true)
			.Q1(203)
			.K1(61)
			.K2(145)
			.Bid(14, 22, "To Prevent a Fast 1 on Dan the Man")
			.Bid(373, 14, "17 TDr next 2 yrs")
			.Poach(308, 50, "Best QB sitting on the minimum")
			.Waive(78, "retired?")
			.Fast(349, 7, "the Nigerian Nightmare")
			.Fast(363, 1, "next best free agent RB")
			.Fast(341, 1, "ex Duck")
			.Merchandising(25, "for delayed income stream")
			.Marketing(25, "for delayed income stream")
			.Waive(274, "retired?")
			.Waive(370, "retired?")
			.Waive(197, "non contributor")
			.Waive(2, "non contributor")
			.Waive(236, "non contributor")
			.Rebid(167, 14, "Do this in Week 1 - Has no TDs in QTR 2"));

	round = new Gridstats.Round( 1988, "W01" );
	(s,b) = retroRepo.AddTurnsheet(
	 	new TurnSheet(round, rosters, rosterContext, (s,b), true)
			.WeeksUsed(1,2,3,4)
			.A1(320)
			.B1(139)
			.B2(341)
			.Y1(44)  // Mandatory
			.X2(362)
			.Bid(308, 50, "Followup on the Poach")
			.Rebid(167, 14, "Do this in Week 1 - Has no TDs in QTR 2")
			.Poach(45, 24, "2 yr production and 49er")
			.Stuff("3 of 4 weeks")
			.Waive(236, "non contributor")
			.Waive(370, "retired?")
			.Waive(197, "non contributor")
			.Waive(274, "retired?")
			.Waive(2, "non contributor")
			.Merchandising(25, "for delayed income stream")
			.Marketing(25, "for delayed income stream")
			.Holdouts(308)
			);

	round = new Gridstats.Round(1988, "W02");
	(s, b) = retroRepo.AddTurnsheet(
	 	new TurnSheet(round, rosters, rosterContext, (s, b), true)
			.WeeksUsed(5, 6, 7, 8)
			.A1(341)
			.A2(139)
			.B1(373)
			.B2(363)
			.Bid(54, 14, "Good Free Agent")
			.Bid(45, 29, "Followup on the Poach")
			
			.Poach(184, 29, "2 yr production")
			.Waive(197, "non contributor")
			.Waive(274, "retired?")
			.Fast(157, 1, "Renfro Replacement")
			.Fast(331, 1, "shift Danny White")

			.Waive(2, "non contributor")
			.Merchandising(25, "for delayed income stream")
			.Marketing(25, "for delayed income stream")
			.Fast(176, 1, "To cover week 9 and shift Danny White")
			.Holdouts(323,45)
			);

	round = new Gridstats.Round(1988, "W03");
	(s, b) = retroRepo.AddTurnsheet(
	 	new TurnSheet(round, rosters, rosterContext, (s, b), true)
			.WeeksUsed(9, 10, 11, 12)
			.Q2(331)
			.A1(239)
			.A2(349)
			.B1(139)
			.X1(157)
			.X2(362)
			.Y2(180)
			.Z2(110)
				
			.Bid(54, 39, "Number 2 in 89")
			.Bid(184, 29, "10 in 88 8 in 89")			
			//.Rebid(308, 33, "not paying 5 per week if rebuilding")
			
			.Poach(49, 29, "for this year")	
			.Waive(2, "non contributor")
			.Waive(203, "Have Everett now")
			.Stuff("could win Wk 11")		
			.Fast(392, 1, "for 1989")	
			
			.Merchandising(50, "for delayed income stream")
			.Poach(258, 29, "2 yr production, 9 in 89")
			.Marketing(25, "for delayed income stream")			
			.Fast(169, 1, "Better Post GS WEEK 5 10 in 89")			
			.Fast(176, 1, "To cover week 9 and shift Danny White")
			.Holdouts(184, 352)
			);

	round = new Gridstats.Round(1988, "W04");
	(s, b) = retroRepo.AddTurnsheet(
	 	new TurnSheet(round, rosters, rosterContext, (s, b), true)
			.WeeksUsed(13, 14, 15, 16)
			.Q1(308)
			.A2(363)
			.B1(45)
			.B2(349)
			.X2(110)
			.Z2(362)

			.Bid(203, 14, "protect investment")
			.Bid(314, 14, "5 this 8 next")
			//.Rebid(308, 33, "not paying 5 per week if rebuilding")

			.Poach(258, 29, "2 yr production, 9 in 89")
			.Waive(320)
			.Stuff("could win Wk 11")
			.Merchandising(50, "for delayed income stream")
			.Marketing(25, "for delayed income stream")

			.Poach(392, 30, "#3 in 89")
			.Fast(169, 1, "Better Post GS WEEK 5 10 in 89")
			.Fast(176, 1, "To cover week 9 and shift Danny White")
			.Holdouts(341, 49, 336)
			);

	round = new Gridstats.Round(1988, "W05");
	int[] skipWeeks = new int[4] { 3, 8, 10, 14 };
	(s, b) = retroRepo.AddTurnsheet(
	 	new TurnSheet(round, rosters, rosterContext, (s, b), true, skipWeeks )
			.WeeksUsed(1, 2, 4)
			.A1(139)
			.A2(341)
			.B2(379)
			.Y1(184)

		    .Bid(258, 29, "follow up")
		    //.Bid("Butts", "Marion", "SD", 14, "9 next year")			
			.Rebid(45, 22, "might be my RB5 next yr")

			.Poach(392, 36, "#3 in 89")
			.Stuff("use it b4 u lose it")
			.Waive(180,"need room")
			.Waive(139,"need room")			
			
			.Fast(169, 1, "Better Post GS WEEK 5 10 in 89")
			
			.Fast(176, 1, "To cover week 9 and shift Danny White")
			.Holdouts(258, 341, 157)
			);

	round = new Gridstats.Round(1988, "W06");
	skipWeeks = new int[5] { 2, 3, 8, 10, 14 };
	(s, b) = retroRepo.AddTurnsheet(
	 	new TurnSheet(round, rosters, rosterContext, (s, b), true, skipWeeks)
			.WeeksUsed(5,6,7)
			.Q1(331)
			.Q2(308)
			.A1(373)
			.A2(239)
			.B1(363)
			.B2(54)
			.X1(44)
			.K1(145)
			.K2(61)

			.Bid(392, 39, "follow up")
			.Bid(33, 49, "all-time GREAT")
			//.Bid("Carter", "Chris", "PE", 14, "11 next year")			
			//.Bid("Butts", "Marion", "SD", 14, "9 next year")			

			//.Poach(318, 54, "Wk 6 Attack the strength Hilliard")
			.Poach(49, 28, "Make him Pay")
			//.Poach(221, 120, "Wk 7 Attack the strength Bell")
			//.Poach(169, 29, "Wk 8 Attack the strength Miller")
			//.Poach(326, 29, "Wk 9 Attack the strength Taylor")
			//.Poach(262, 29, "Wk 10 Attack the strength Norwood")
			
			.Stuff("use it b4 u lose it")

			.Fast(150, 4, "Actually Sterling Sharpe WR#2 next year")
			.Fast(36, 1, "Paul Palmer 2 TDcs in week 4")
			.Fast(139,2)
			.Holdouts(392, 90)
			);
			
	var turnSheet = retroRepo
		.TurnSheet(round)
		.ToMarkdown(teamName);

	if (sendToMd)
		SendTurnSheetToObsdian(
			turnSheet,
			round);

	Console.WriteLine(turnSheet);
	
}


void SendTurnSheetToObsdian(
	string turnSheet,
	Gridstats.Round round)
{
	var filePath = $"d:\\Dropbox\\Obsidian\\ChestOfNotes\\CD {round.Season} {round.WeekCode}.md";

	using (StreamWriter outputFile = new StreamWriter(filePath))
	{
		outputFile.WriteLine(turnSheet);
	}
}


public class RetroRepository
{
	public List<TurnSheet> Sheets { get; set; }
	
	public RetroRepository()
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
	
	public int[] Starters(Gridstats.Round round)
	{
		var sheet = Sheets.Where(s=>s.Round.Season==1988 && s.Round.WeekCode == "P01")
			.FirstOrDefault();
		return sheet.StartingLineup();
	}

	public int[] Backups(Gridstats.Round round)
	{
		var sheet = Sheets.Where(s => s.Round.Season == 1988 && s.Round.WeekCode == "P01")
			.FirstOrDefault();
		return sheet.SecondsLineup();
	}

}



