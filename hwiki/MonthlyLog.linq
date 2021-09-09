<Query Kind="Statements" />

var startDate = new DateTime(2020,11,1);
	Console.WriteLine($"=== {startDate.ToString("MMMM")} [FutureLog_2020 2020] ===");
	Console.WriteLine();
	Console.WriteLine("|| **Day** || **Daily Log** || **Comments** ||");
	var printDate = startDate;
	while ( printDate.Month == startDate.Month )
	{
	   Console.WriteLine( PrintLine( printDate ));
	   printDate = printDate.AddDays(1);
	}
	Console.WriteLine();
	Console.WriteLine();
	Console.WriteLine("==== Done (Wins) ====");
	Console.WriteLine("  1. ");
	Console.WriteLine();
	Console.WriteLine("==== Books ====");
	Console.WriteLine("  1. ");
	Console.WriteLine();
	Console.WriteLine("----");
	Console.WriteLine($"  * < [[{PreviousMonth(startDate)}]] (m) [[{NextMonth(startDate)}]] >");	
}

string PrintLine( DateTime printDate)
{
   var holiday = IsHoliday(printDate);
	if (string.IsNullOrEmpty(holiday))
		return $"|| {FirstLetter(printDate)} {printDate.Day,2} ||  {DateLink(printDate)}  ||   ||";
	return $"|| {FirstLetter(printDate)} {printDate.Day,2} ||  {PrintDate(printDate)}  ||  {holiday}  ||";
}

string IsHoliday(DateTime printDate)
{
	if (printDate == new DateTime(2020, 1, 1))
       return "New Year's Day";
    if (printDate == new DateTime(2020,1,27))
       return "Australia Day";
    if (printDate == new DateTime(2020, 3, 9))
       return "Canberra Day";
    if (printDate == new DateTime(2020, 4, 10))
       return "Good Friday";
    if (printDate == new DateTime(2020, 4, 13))
       return "Easter Monday";
    if (printDate == new DateTime(2020, 4, 27))
       return "Anzac Day Holiday";
    if (printDate == new DateTime(2020, 6, 1))
       return "Reconciliation Day";
    if (printDate == new DateTime(2020, 6, 8))
       return "Queen's Birthday";
    if (printDate == new DateTime(2020, 10, 5))
       return "Labour Day";
    if (printDate == new DateTime(2020, 12, 25))
       return "Christmas Day";
    if (printDate == new DateTime(2020, 12, 28))
       return "Boxing Day Holiday";
   return string.Empty;
}

string PrintDate(DateTime printDate)
{
	return printDate.ToString("yyyy-MM-dd");
}

string PreviousMonth(DateTime printDate)
{
	return printDate.AddMonths(-1).ToString("yyyy-MM");
}

string NextMonth(DateTime printDate)
{
	return printDate.AddMonths(1).ToString("yyyy-MM");
}

string FirstLetter( DateTime printDate )
{
   return printDate.ToString("D").Substring(0,1);
}

string DateLink( DateTime printDate )
{
   if ( FirstLetter(printDate) == "S" )
      return new String(' ', 14);
	  
   return $"[[{printDate.ToString("yyyy-MM-dd")}]]";