<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

var startDate = new DateTime(1987,2,1);
	Console.WriteLine($"The ColonnasDeLoreans [NflSeason_{PrintYear(startDate)} {PrintYear(startDate)}] GridStatsRetro " );
	Console.WriteLine();
	Console.WriteLine("=== Roster ===");	
	Console.WriteLine("||  **Player**    ||  **NFL**  ||  **Comments**  ||");
	PlayerTypeHeader("QB");
	PlayerLine("JoeMontana", "SF" );
	PlayerTypeHeader("RB");
	PlayerLine("JohnRiggins", "WR" );	
	PlayerTypeHeader("TE");
	PlayerTypeHeader("WR");
	PlayerLine("DwightClark", "SF" );	
	PlayerLine("MarkDuper", "MD" );	
	PlayerTypeHeader("PK");
	PlayerLine("MarkMosely", "WR" );	
	Console.WriteLine();	
	Console.WriteLine();
	Console.WriteLine("|| **Week** || **Opponent** || **R** || **Score** || **Rec** || **Comments** ||");
	for	(int i = 1; i < 13; i++ )
	{
       Console.WriteLine($"||    {i:00}    ||              ||       ||           ||         ||              ||");		
	}
	Console.WriteLine();
	Console.WriteLine("----");
	Console.WriteLine($"<< [[ColonnasDeLoreans_{PreviousYear(startDate)}]] (m) [[ColonnasDeLoreans_{NextYear(startDate)}]] >>");	
	Console.WriteLine();
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
   string playerName,
   string playerTeam)
{
   Console.WriteLine($"||  {playerName} ||  [[{playerTeam}]]   ||   ||");	
}

void PlayerTypeHeader(
   string playerPos )
{
   Console.WriteLine($"||||||  {playerPos} ||");	
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