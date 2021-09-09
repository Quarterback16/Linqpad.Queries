<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

var startDate = new DateTime(2020,7,1);  //  strt of the financial year
Console.WriteLine($"The Budget for the {FinYear(startDate)} financial year, tabled {Month(7,startDate)}.");
Console.WriteLine();
Console.WriteLine("Total cost of living in hundreds equals ( Fixed Costs * 12 ) + Jul + Aug + Sep + Oct + Nov + Dec + Jan + Feb + Mar + Apr + May + Jun which equals **$11,800**");

Console.WriteLine("=== Fixed costs (in hundreds) every month  ===");
Console.WriteLine("  1. Food: 10");
Console.WriteLine("  1. CarInsurance: 1");
Console.WriteLine("  1. AnimalInsurance (Vet): 1");
Console.WriteLine("  1. HealthInsurance: 5");
Console.WriteLine("  1. InternetService: 1");
Console.WriteLine("  1. Petrol: 3");
Console.WriteLine("  1. Cleaning: 0");
Console.WriteLine();
Console.WriteLine("**Total Fixed costs each month:  21**");
Console.WriteLine();

Console.WriteLine($"|| **{Month(7,startDate)}** || **{Month(8,startDate)}** || **{Month(9,startDate)}**   ||");
Console.WriteLine("||                     <br>Total: 0 ||  KingsmillGas : 3 <br> KingsmillElectricity:  8  <br> KingsmillWater: 3  <br>Car Service: 6 <br><br>Total: 20 ||  KingsmillRates (15): 5  <br><br>Total: 5               ||");
Console.WriteLine($"|| **{Month(10,startDate)}** || **{Month(11,startDate)}** || **{Month(12,startDate)}**  ||");
Console.WriteLine("||                     <br>Total: 0 ||  KingsmillGas : 3 <br> KingsmillElectricity: 11  <br> KingsmillWater: 3  <br><br>Total: 17 ||  KingsmillRates (15): 5  <br><br>Total: 5               || ");
Console.WriteLine($"|| **{Month(1,startDate)}** || **{Month(2,startDate)}** || **{Month(3,startDate)}**     ||");
Console.WriteLine("||  Car Service: 3 <br><br>Total: 3 ||  KingsmillGas : 2 <br> KingsmillElectricity:  4  <br> KingsmillWater: 5  <br><br>Total: 11 ||  KingsmillRates (15): 5 <br>Rego: 10 <br><br>Total: 15  || ");
Console.WriteLine($"|| **{Month(4,startDate)}** || **{Month(5,startDate)}** || **{Month(6,startDate)}**     ||");
Console.WriteLine("||  Car Service: 3 <br><br>Total: 3 ||  KingsmillGas : 2 <br> KingsmillElectricity:  5  <br> KingsmillWater: 4  <br><br>Total: 11 ||  KingsmillRates (15): 5 <br>Ipads: 2 <br><br>Total:  7  || ");
Console.WriteLine();
Console.WriteLine("**Total Variable costs:  97**");
Console.WriteLine();

Console.WriteLine("<Anchor(Deductions)>");
Console.WriteLine("=== Tax Deductions (//tally here during the year//) ===");
Console.WriteLine("||  **Date**   ||  **Item**                                ||  **Category**    ||  **Amount**  ||");
Console.WriteLine("||             ||                                          ||                  ||              ||");
Console.WriteLine();

Console.WriteLine("=== Related ===");
Console.WriteLine($"  * TaxReturn_{startDate.AddYears(1).ToString("yyyy")}");
Console.WriteLine();

Console.WriteLine("----");
Console.WriteLine($"  * < [[Budget_{FinYear(startDate.AddYears(-1))}]] (m) [[Budget_{FinYear(startDate.AddYears(1))}]] >");	
}

string Month(int month, DateTime startDate)
{
    var monthName = new DateTime( 2020, month, 1)
       .ToString("MMM", CultureInfo.InvariantCulture)
	   .ToUpper();
    var year = startDate.Year;
	if (month < 7)
	   year++;
	return $"{monthName} [[{year}-{month:0#}]]";
}

string FinYear(DateTime startDate)
{
	return $"{startDate.ToString("yyyy")}-{startDate.AddYears(1).ToString("yy")}";
}

string PrintDate(DateTime printDate)
{
	return printDate.ToString("yyyy-MM-dd");
