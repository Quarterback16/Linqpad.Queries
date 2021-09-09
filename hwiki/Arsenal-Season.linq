<Query Kind="Program">
  <Reference>E:\FileSync\SyncProjects\TipIt\ScheduleService\bin\Release\netcoreapp3.1\epl-schedule-2021.json</Reference>
  <Reference>E:\FileSync\SyncProjects\TipIt\ScheduleService\bin\Release\netcoreapp3.1\nfl-schedule-2021.json</Reference>
  <Reference>E:\FileSync\SyncProjects\TipIt\ScheduleService\bin\Release\netcoreapp3.1\sra-schedule-2021.json</Reference>
  <Reference>E:\FileSync\SyncProjects\TipIt\ScheduleService\bin\Release\netcoreapp3.1\TipIt.dll</Reference>
  <Namespace>ScheduleService</Namespace>
  <Namespace>System.Globalization</Namespace>
  <Namespace>TipIt.Models</Namespace>
  <Namespace>Utes</Namespace>
</Query>

void Main()
{
//	SeasonSlate("Arsenal", 2021, "EPL");
	SeasonSlate("Juventus", 2021, "S-A");
}
	
private void SeasonSlate(
	string team,
	int season,
	string league,
	bool toObsidian = false)
{
	var scheduleService = new ScheduleService.ScheduleMaster();
	var games = scheduleService.GetSchedule( 
		team,
		league,
		season);
	var table = new WikiTable();
	table.Columns.Add(new Utes.WikiColumn("Rd"));
	table.Columns.Add(new Utes.WikiColumn("Date"));
	table.Columns.Add(new Utes.WikiColumn("Opponent"));
	table.Columns.Add(new Utes.WikiColumn("W"));
	table.Columns.Add(new Utes.WikiColumn("R"));
	table.Columns.Add(new Utes.WikiColumn("Score"));
	table.Columns.Add(new Utes.WikiColumn("Rec"));
	table.Columns.Add(new Utes.WikiColumn("Comment"));
	table.AddRows(games.Count);
	
	for	(int i = 1; i < games.Count+1; i++ )
	{
		var game = Week(i, games);
		table.AddCell(i, 0, $"{i:0#}");
		table.AddCell(i, 1, $"{GameDate(game)}");
		table.AddCell(i, 2, $"{GameOpponent(game,team,league)}");
		table.AddCell(i, 3, $"{GameLocation(game,team)}");
	}
	table.Render();
	
	Console.WriteLine();
	Console.WriteLine("---");
	Console.WriteLine($"<< [[{team} {season - 1}]] (m) [[{team} {season+1}]] >>");	
	Console.WriteLine();
	LinqPadFile($"{team}-Season");
	}
	
	void LinqPadFile(string filename)
	{
		var lpf = new LinqpadFile(
			filename);
		Console.WriteLine(lpf.FileOut());
	}
	
	string GameDate(Game game)
	{
		if (game == null)
			return "BYE";
		return game.GameDate.ToString("yyyy-MM-dd HH:MM");
	}
	
	string GameOpponent(Game game,string team, string league)
	{
		if (game == null)
			return "BYE";
		var oppCode = game.OpponentOf(team);
		var oppName = oppCode;
		if (league.Equals("NFL"))
		{
			oppName = MyExtensions.ConvertNflCode(oppCode);
			oppName = $"[[{oppName}|{oppCode}]]";
		}
		return oppName;
	}
	
	string GameLocation(Game game,string team)
	{
		if (game == null)
			return "";
		if (game.IsHomeTeam(team))
			return "H";
		return "A";
	}
	
	Game Week(int w, List<Game> games)
	{
		var query = games.Where( g=>g.Round.Equals(w))
			.FirstOrDefault();;
		return query;
	}
	
	int WeekNumber( DateTime theDate)
	{
		DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(theDate);
	    if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
	        theDate = theDate.AddDays(3);
	
	    // Return the week of our adjusted day
	    return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(
			theDate, 
			CalendarWeekRule.FirstFourDayWeek, 
			DayOfWeek.Monday);
	}
	
	
	
	void PlayerLine(
	   string playerPos )
	{
	   Console.WriteLine($"|  {playerPos} |   |   |  |");	
	}
	

// You can define other methods, fields, classes and namespaces here
