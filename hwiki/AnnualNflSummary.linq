<Query Kind="Statements" />

int year = 2020;

Console.WriteLine($"|  **Project Start Date:**  |   {DateTime.Now.Date.ToString("[[yyyy-MM]]-dd")}   |  **End Date:**  |  | **Status:**  |  #project/active  |");
Console.WriteLine("|---|---|---|---|---|---|");
Console.WriteLine("|  **Goal**         |   Create a set of [[Google Sheets]] for use with [[Gridstats Retro]] that summarises the season and the players  | | | | | |");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("### Tasks");
Sheet("QB TDp");
Sheet("QB TDr");
Sheet("RB TDr");
Sheet("Rec TDc");
Sheet("PK");
Console.WriteLine();
TheProcedure();
Console.WriteLine("### Links");
NumberLine($"[[{year} NFL Standings & Team Stats | Pro-Football-Reference.com]](https://www.pro-football-reference.com/years/{year}/)");
NumberLine("https://webapps.stackexchange.com/questions/95500/how-to-use-split-text-to-columns-when-pasting-in-google-sheets");
Console.WriteLine();

Footer(year);
Console.WriteLine();
LinqFile("AnnualNflSummary");

}

void Footer( int year )
{
	Console.WriteLine();
	HorizontalRule();
	Console.WriteLine($"* < [[Annual Nfl Summary {year - 1}]] (m) [[Annual Nfl Summary {year+1}]] >");
}

void LinqFile( string fileName )
{
	Console.WriteLine($"`{fileName}.linq`");
}

void HorizontalRule()
{
	Console.WriteLine("---");	
}

void TheProcedure()
{
	Console.WriteLine("### Procedure");
	NumberLine("Copy previous sheet and empty it out");
	NumberLine("Scrape names from [[Pro Football Reference]] site");
	NumberLine("Use [[GameLog]] solution to further scrape data");
	BulletLine("eg see `GameStatsRepository_GeneratesTdp_ForQuarterbacks()` test method");
	NumberLine("Paste data into [[Google Sheets]]");
	Console.WriteLine();
}

void BulletLine(string line)
{
	Console.WriteLine($"* {line}");
}
void NumberLine(string line)
{
	Console.WriteLine($"1. [ ] {line}");
}

void Sheet( string header )
{
	Console.WriteLine($"1. [ ] {header}");
	Console.WriteLine("  *");
