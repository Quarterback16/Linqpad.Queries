<Query Kind="Statements" />

var teamName = "Pittsburgh Steelers";
var abbreviation = "PS";

Header( teamName, abbreviation );
Console.WriteLine();

Section("Honours");
Links("Top Players");
Links("Links");

}

void Section(string header)
{
	Console.WriteLine($"=== {header} ===");
	Console.WriteLine("  *");
	Console.WriteLine();
}

void Links(string header)
{
	Console.WriteLine($"=== {header} ===");
	Console.WriteLine("  1.");
	Console.WriteLine();
}

void Header(string header, string abbreviation)
{
	Console.WriteLine($"=== {header} [[{abbreviation}]] ===");
	Console.WriteLine("  * 19nn to current");
	Console.WriteLine();
}

string PrintDate(DateTime printDate)
{
	return printDate.ToString("yyyy-MM-dd");