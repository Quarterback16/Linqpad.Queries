<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

var startDate = new DateTime(2019,7,1);  //  strt of the financial year
Console.WriteLine($"RentalProperty Profit and Loss Statement for the {FinYear(startDate)} financial year");
Console.WriteLine();

Console.WriteLine("||  **Month**        ||  **Income**  ||  **Expenses**   ||  **Profit**  ||  **Comments** ||");
for	(int m = 0; m < 12; m++ )
{
    Console.WriteLine($"||  {MonthLink(startDate.AddMonths(m))}      ||              ||                 ||              ||               ||");
}
Console.WriteLine("||  Total            ||              ||                 ||              ||               ||");
Console.WriteLine("||  InterestExpense  ||              || **-$99,999.99** ||              ||               ||");
Console.WriteLine("||  Total Expenses   ||              ||    $99,999.99   ||              ||               ||");
Console.WriteLine("||  //TAX LOSS//     ||              || **-$99,999.99** ||              ||               ||");
Console.WriteLine();  

Console.WriteLine("----");
Console.WriteLine($"  * < RentalProperty_{startDate.ToString("yyyy")} (m) RentalProperty_{startDate.AddYears(2).ToString("yyyy")} >");	
}

string MonthLink(DateTime printDate)
{
	return $"[[{printDate.ToString("yyyy-MM")}]]";
}

string FinYear(DateTime startDate)
{
	return $"{startDate.ToString("yyyy")}-{startDate.AddYears(1).ToString("yy")}";
}

string PrintDate(DateTime printDate)
{
	return printDate.ToString("yyyy-MM-dd");