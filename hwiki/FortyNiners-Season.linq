<Query Kind="Statements">
  <Reference>E:\FileSync\SyncProjects\TipIt\ScheduleService\bin\Release\netcoreapp3.1\nfl-schedule-2021.json</Reference>
  <Reference>E:\FileSync\SyncProjects\TipIt\ScheduleService\bin\Release\netcoreapp3.1\TipIt.dll</Reference>
  <Namespace>ScheduleService</Namespace>
  <Namespace>System.Globalization</Namespace>
  <Namespace>Utes</Namespace>
  <Namespace>TipIt.Models</Namespace>
</Query>


var startDate = new DateTime(2021,2,1);
Console.WriteLine($"The [[Nfl Season {PrintYear(startDate)}]] [[San Francisco Forty Niners]] **W - L**");
Console.WriteLine();

Console.WriteLine("|  **Pos**  |  **Player**         |   **Stats**  | **Comments**  |");
Console.WriteLine("| --- | --- | --- | --- |");
PlayerLine("QB");
PlayerLine("RB");
PlayerLine("RB");
PlayerLine("WR");
PlayerLine("WR");
PlayerLine("WR");
PlayerLine("TE");
PlayerLine("TE");
PlayerLine("DL");
PlayerLine("DL");
PlayerLine("DL");
PlayerLine("DL");
PlayerLine("LB");
PlayerLine("LB");
PlayerLine("LB");
PlayerLine("DB");
PlayerLine("DB");
PlayerLine("DB");
PlayerLine("DB");
PlayerLine("PK");
Console.WriteLine();	
Console.WriteLine();
var scheduleService = new ScheduleService.ScheduleMaster();
var games = scheduleService.GetSchedule( 
	"SF",
	"NFL",
	startDate.Year);
var table = new WikiTable();
table.Columns.Add(new Utes.WikiColumn("Week"));
table.Columns.Add(new Utes.WikiColumn("Date"));
table.Columns.Add(new Utes.WikiColumn("Opponent"));
table.Columns.Add(new Utes.WikiColumn("HA"));
table.Columns.Add(new Utes.WikiColumn("R"));
table.Columns.Add(new Utes.WikiColumn("Score"));
table.Columns.Add(new Utes.WikiColumn("Rec"));
table.Columns.Add(new Utes.WikiColumn("Comment"));
table.AddRows(18);

for	(int i = 1; i < 19; i++ )
{
	var game = Week(i, games);
	table.AddCell(i, 0, $"{i:0#}");
	table.AddCell(i, 1, $"{GameDate(game)}");
	table.AddCell(i, 2, $"{GameOpponent(game)}");
	table.AddCell(i, 3, $"{GameLocation(game)}");
}
table.Render();

Console.WriteLine();
Console.WriteLine("---");
Console.WriteLine($"<< [[San Francisco Forty Niners {PreviousYear(startDate)}]] (m) [[San Francisco Forty Niners {NextYear(startDate)}]] >>");	
Console.WriteLine();
LinqPadFile("FortyNiners-Season");
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

string GameOpponent(Game game)
{
	if (game == null)
		return "BYE";
	var oppCode = game.OpponentOf("SF");
	var oppName = MyExtensions.ConvertNflCode(oppCode);
	return $"[[{oppName}|{oppCode}]]";
}

string GameLocation(Game game)
{
	if (game == null)
		return "";
	if (game.IsHomeTeam("SF"))
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


bool IsMonday(DateTime theDate)
{
   return theDate.DayOfWeek == DayOfWeek.Monday;
}


void PlayerLine(
   string playerPos )
{
   Console.WriteLine($"|  {playerPos} |   |   |  |");	
}

string PrintYear(DateTime printDate)
{
	return printDate.ToString("yyyy");
}

string PrintDate(DateTime printDate)
{
	return printDate.ToString("yyyy-MM-dd");
}

string CurrentMonth(DateTime printDate)
{
	return printDate.ToString("yyyy-MM");
}

string PreviousYear(DateTime printDate)
{
	return printDate.AddYears(-1).ToString("yyyy");
}

string NextYear(DateTime printDate)
{
	return printDate.AddYears(1).ToString("yyyy");
}

string FirstTwoLetters( DateTime printDate )
{
   return printDate.ToString("D").Substring(0,2);
}

int DaysInMonth( DateTime theDate )
{
   var theYear = theDate.Year;
   var theMonth = theDate.Month;
   return DateTime.DaysInMonth(theYear,theMonth);