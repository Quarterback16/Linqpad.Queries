<Query Kind="Statements" />

var startDate = new DateTime(2020,8,1);

	Console.WriteLine($"=== [[{CurrentMonth(startDate)}]] {startDate.ToString("MMMM")} Health Log ===");
	Console.WriteLine();
	Console.WriteLine("|| **Day** ||  **Weight**  ||  **Breakfast**                ||  **lunch**              ||  **Dinner**              ||  **Exercise**  ||  **Steps**  ||  **Cals**  ||");
	var printDate = startDate;
	while ( printDate.Month == startDate.Month )
	{
	   Console.WriteLine( PrintLine( printDate ));
	   printDate = printDate.AddDays(1);
	}
	Console.WriteLine();
	Console.WriteLine();
	Console.WriteLine("----");
	Console.WriteLine($"  * < [[Health_{PreviousMonth(startDate)}]] (m) [[Health_{NextMonth(startDate)}]] >");	
}

string PrintLine( DateTime printDate)
{
	return $"||  {FirstLetter(printDate)} {printDate.Day,2}   ||              ||                               ||                         ||                          ||                ||             ||            ||";
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

string FirstLetter( DateTime printDate )
{
   return printDate.ToString("D").Substring(0,1);
}

string DateLink( DateTime printDate )
{
   if ( FirstLetter(printDate) == "S" )
      return new String(' ', 14);
	  
   return $"[[{printDate.ToString("yyyy-MM-dd")}]]";