<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

var startDate = new DateTime(1983,1,1);
var teamName = "Send On The Fridge";
var ownerName = "GlenPaul";

	Console.WriteLine($"The {teamName}, is a GridstatsRetro team, owned by {ownerName}");
	Console.WriteLine();
	Console.WriteLine( $"  * formed in [NflSeason_{PrintYear(startDate)} {PrintYear(startDate)}]");
    Console.WriteLine();
	Console.WriteLine();
	Console.WriteLine($"===  Roster ===");
	Console.WriteLine();
		
	Console.WriteLine("||  **Pos**  ||  **Player**         || **Comments**  ||");
	PlayerLine("QB");
	PlayerLine("QB");
	PlayerLine("RB");
	PlayerLine("RB");
	PlayerLine("RB");
	PlayerLine("RB");
	PlayerLine("TE");
	PlayerLine("TE");
	PlayerLine("WR");
	PlayerLine("WR");
	PlayerLine("WR");
	PlayerLine("WR");
	PlayerLine("WR");
	PlayerLine("WR");
	PlayerLine("PK");
	PlayerLine("PK");
	Console.WriteLine();	
	Console.WriteLine();
	Console.WriteLine("===  Seasons ===");
	Console.WriteLine("||  **Year**  ||  **Record**  ||  *Comments**  ||");
	Console.WriteLine($"||  [GridStatsRetro_{PrintYear(startDate)} {PrintYear(startDate)}] ||  W - L  ||    ||");
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
   string playerPos )
{
   Console.WriteLine($"||  {playerPos} ||   ||  ||");	
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