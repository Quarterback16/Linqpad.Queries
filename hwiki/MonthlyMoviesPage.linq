<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

var startDate = new DateTime(2020,6,1);
	Console.WriteLine($"=== [[{CurrentMonth(startDate)}]] Movies ===");
	Console.WriteLine();
	
	Console.WriteLine("||  **#**  ||  **Movie**      ||  **Delivery**  ||  **Rating**  ||  **Comments**  ||");
	Console.WriteLine("||    1    ||                 ||                ||              ||                ||");
	Console.WriteLine("||    2    ||                 ||                ||              ||                ||");
	Console.WriteLine("||    3    ||                 ||                ||              ||                ||");
	Console.WriteLine("||    4    ||                 ||                ||              ||                ||");
	Console.WriteLine();	
	
	Console.WriteLine("==== Candidates ====");
	Console.WriteLine("  1. 1917 : [[Plex]]");
	Console.WriteLine("  1. Knives Out : [[Plex]]");	
	Console.WriteLine("  1. Eighth Grade : [[Plex]]");
	Console.WriteLine("  1. Little Women : [[Plex]]");	
	Console.WriteLine("  1. If Beale Street Could Talk : [[Plex]]");	
	Console.WriteLine("  1. Marriage Story : [[Netflix]]");
	Console.WriteLine("  1. Toy Story 4 : DisneyPlus");
	Console.WriteLine();
	
	Console.WriteLine("----");
	Console.WriteLine($"  * < [[Movies-{PreviousMonth(startDate)}]] (m) [[Movies-{NextMonth(startDate)}]] >");	
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


void DateLine(
   DateTime iDate,
   string commentPart )
{
   Console.WriteLine($"  1. {FirstTwoLetters(iDate)} : ({iDate.Day:0#}) : {commentPart}");	
}

string PrintDate(DateTime printDate)
{
	return printDate.ToString("yyyy-MM-dd");
}

string CurrentMonth(DateTime printDate)
{
	return printDate.ToString("yyyy-MM");
}

string PreviousMonth(DateTime printDate)
{
	return printDate.AddMonths(-1).ToString("yyyy-MM");
}

string NextMonth(DateTime printDate)
{
	return printDate.AddMonths(1).ToString("yyyy-MM");
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