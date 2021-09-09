<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

var theDate = DateTime.Now;

var theIdea = "Create a utility that creates the current Running Back situation.";

	Console.WriteLine(theIdea);
	Console.WriteLine();

	Console.WriteLine($"  1. () : //next action//");

	Console.WriteLine();

	Console.WriteLine($"  * [[{CurrentMonth(theDate)}]]-{theDate.Day}");
	Console.WriteLine();
	
	Console.WriteLine("#idea");
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