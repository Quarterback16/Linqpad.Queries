<Query Kind="Statements" />

var leader = "[[Lautaro]]";

Section($"{leader} [[CivilizationVI]] GOTM");

Console.WriteLine();
Console.WriteLine($"||  **designated VC:**      ||   Civ6_CulturalVictory  ||");
Console.WriteLine($"||  **Map Type:**           ||     ||");
Console.WriteLine($"||  **Difficult Level:**    ||     ||");
Console.WriteLine($"||  **Game pace:**          ||   Standard        ||");
Console.WriteLine($"||  **Version:**            ||   1.0.0.341       ||");
Console.WriteLine();
Section("Strategy");
Links("Objectives");
Links("Capital Build Order");
Links("Wonder list");
Links("Key Techs");
Links("Key Policies");
Links("Key Governers");

	Console.WriteLine($"=== Achievment Lists ===");
	Console.WriteLine("  * Gathering Storm");
	Console.WriteLine("  * RiseAndFall");
	Console.WriteLine();
	Console.WriteLine($"=== Links ===");
	Console.WriteLine("  1. https://civ6.gamepedia.com/");
	Console.WriteLine();
	var lf = new Utes.LinqpadFile("GOTM-Template");
	Console.WriteLine(lf.FileOut());
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