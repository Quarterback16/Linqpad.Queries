<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

var year = 2021;
var startDate = new DateTime(year,2,1);
var pageType = "SuperBowl";

SuperBowlHeading(startDate);

Console.WriteLine($"[[{MonthLink(startDate,2)}]]-?? :- ");
Console.WriteLine();
Console.WriteLine("//Where I watched it.//");
Console.WriteLine();

SeasonLink(year);

Console.WriteLine();
Console.WriteLine("----");
Console.WriteLine($"  * < [[{pageType}_{startDate.AddYears(-1).ToString("yyyy")}[[ (m) [[{pageType}_{startDate.AddYears(1).ToString("yyyy")}]] >");	

}

void SeasonLink(
   int nYear)
{
   Console.WriteLine($"  * [[NflSeason_{nYear-1}]]");
}

string MonthLink(
   DateTime startDate,
   int nMonth)
{
   return $"{startDate.Year}-{nMonth:0#}";	
}

void SuperBowlHeading(DateTime startDate)
{
	Console.WriteLine($"=== [[SuperBowl]] {SuperBowlNumber(startDate.Year)} ===");
	Console.WriteLine();
}

int SuperBowlNumber(int theYear)
{
	return theYear - 1966;
}

string PrintDate(DateTime printDate)
{
	return printDate.ToString("yyyy-MM-dd");
