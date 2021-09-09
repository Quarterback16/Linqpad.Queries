<Query Kind="Statements" />

var title = "Hyperfocus; How to be more productive in a World of Distraction";
var author = "Chris Bailey";
var year = "2018";
var about = "Productivity";
var recommendedBy = "na";
var nChapters = 14;
var structure = "2 parts; 10 chapters";
//var structure = $"{nChapters} chapters";
var format = "[[epub]]";
//var format = "[AudioBookSystem audio] and [[epub]]";

Console.WriteLine($"||  **Title:**      ||  {title}   ||");
Console.WriteLine($"||  **Author:**     ||  {author}  ||");
Console.WriteLine($"||  **Year:**       ||  {year}    ||");
Console.WriteLine($"||  **Structure:**  ||  {structure}     ||");
Console.WriteLine();
Console.WriteLine($"  * {format}");
Console.WriteLine();
Header("What is the Book About");
BulletPoint(about);
Console.WriteLine();
Links("Questions");
Links("Authors Proposals");
Section("Nuggets");
Section("Phrasing");
Section("Notes");
Header("Structure (Chapters)");
Chapters(nChapters);
Links("Bibliography");
Section("Reviews");
Header("Recommended By");
BulletPoint(recommendedBy);
Console.WriteLine();
Section("Related");
Section("Resources");
Console.WriteLine("=== Log ===");
Console.WriteLine($"  * [[{PrintDate(DateTime.Now)}]]-{DateTime.Now.Day:0#} : [[Skimming]]");
Console.WriteLine();
Console.WriteLine("#book");
Console.WriteLine("#planning");
}

void Chapters(int nChapters)
{
	for (int i = 0; i < nChapters; i++)
	{
		Console.WriteLine("  1.");
	}
	Console.WriteLine();
}

void Links(string header)
{
	Console.WriteLine($"=== {header} ===");
	Console.WriteLine("  1.");
	Console.WriteLine();
}

void BulletPoint(string point)
{
	Console.WriteLine($"  * {point}");
}

void Header(string header)
{
	Console.WriteLine($"=== {header} ===");
}

void Section(string header)
{
	Console.WriteLine($"=== {header} ===");
	Console.WriteLine("  *");
	Console.WriteLine();
}

string PrintDate(DateTime printDate)
{
	return printDate.ToString("yyyy-MM");