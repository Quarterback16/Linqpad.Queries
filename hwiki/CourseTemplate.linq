<Query Kind="Statements" />

var title = "Programming in [[Blazor]]";
var author = "Felipe Gavilan";
var year = "20??";


Console.WriteLine($"|  **Title:**      |  {title}   |");
Console.WriteLine($"|  **Author:**     |  {author}  |");
Console.WriteLine($"|  **Year:**       |  {year}    |");
Console.WriteLine("|  **URL:**        |    |");
Console.WriteLine($"|  **Structure:**  |    8 Parts       |");

Console.WriteLine();

Section("Notes and Learnings");
Links("Structure (Parts)");
Links("Bibliography");
Section("Resources");
Section("Related");
Console.WriteLine("=== Log ===");
Console.WriteLine("  * 2020-??-?? : [[Skimming]]");
Console.WriteLine();

}

void Links(string header)
{
	Console.WriteLine($"=== {header} ===");
	Console.WriteLine("  1.");
	Console.WriteLine();
}

void Section(string header)
{
	Console.WriteLine($"=== {header} ===");
	Console.WriteLine("  *");
	Console.WriteLine();
}

string PrintDate(DateTime printDate)
{
	return printDate.ToString("yyyy-MM-dd");