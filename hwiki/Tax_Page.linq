<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

var startDate = new DateTime(2020,7,1);  //  strt of the financial year
Console.WriteLine($"The TaxReturn for the {FinYear(startDate)} financial year");
Console.WriteLine();

Console.WriteLine("==== Steve ====");
Console.WriteLine("  * https://my.gov.au/LoginServices/main/login?execution=e1s1");
Console.WriteLine();

Console.WriteLine("=== Deductions ===");
Console.WriteLine($"  * see [[Budget_{FinYear(startDate)}#Deductions]]");
Console.WriteLine("  * FredHollowsFoundation");
Console.WriteLine();

Console.WriteLine("----");
Console.WriteLine($"  * < TaxReturn_{startDate.ToString("yyyy")} (m) TaxReturn_{startDate.AddYears(2).ToString("yyyy")} >");	
}


string FinYear(DateTime startDate)
{
	return $"{startDate.ToString("yyyy")}-{startDate.AddYears(1).ToString("yy")}";
}

string PrintDate(DateTime printDate)
{
	return printDate.ToString("yyyy-MM-dd");
