<Query Kind="Statements" />

var title = "The Mikado Method";
var author = "Olna Ellenstan and Daniel Brolund";
var year = "2014";
var about = "[[Technical Debt]]";
var recommendedBy = "";
var nChapters = 7;
//var structure = "20 chapters";
var structure = $"{nChapters} chapters";
var format = "[[pdf]]";
//var format = "[AudioBookSystem audio] and [[epub]]";

BookTags(author,year,format);
Console.WriteLine($"|  |  |");
Console.WriteLine($"| :--- | --- |");
Console.WriteLine($"|  **Title:**      |  {title}   |");
Console.WriteLine($"|  **Author:**     |  {author}  |");
Console.WriteLine($"|  **Year:**       |  {year}    |");
Console.WriteLine($"|  **Structure:**  |  {structure}     |");
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
Console.WriteLine("### Log");
Console.WriteLine($" * [[{PrintDate(DateTime.Now)}]]-{DateTime.Now.Day:0#} : [[Skimming]]");
Console.WriteLine();
Console.WriteLine("#book/planning");
Console.WriteLine();
}

void BookTags(
	string author,
	string year,
	string format)
{
	HorizontalLine();
	MdTag("tags", "[book,IT]");
	MdTag("author", author);
	MdTag("year", year);
	MdTag("format", format);
	Console.WriteLine();
	HorizontalLine();
}

void MdTag(
	string tagName, 
	string tagValue)
{
	Console.WriteLine($"{tagName}: {tagValue}");
}

void HorizontalLine()
{
	Console.WriteLine("---");
}

void Chapters(int nChapters)
{
	for (int i = 0; i < nChapters; i++)
	{
		Console.WriteLine($"{i + 1}.");
	}
	Console.WriteLine();
}

void Links(string header)
{
	Console.WriteLine($"### {header}");
	Console.WriteLine("1.");
	Console.WriteLine();
}

void BulletPoint(string point)
{
	Console.WriteLine($" - {point}");
}

void Header(string header)
{
	Console.WriteLine($"### {header}");
}

void Section(string header)
{
	Console.WriteLine($"### {header}");
	Console.WriteLine("* ");
	Console.WriteLine();
}

string PrintDate(DateTime printDate)
{
	return printDate.ToString("yyyy-MM");