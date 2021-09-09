<Query Kind="Statements" />

Console.WriteLine("Challenge:");
Console.WriteLine();
Console.WriteLine("Why?: ");
Console.WriteLine();
Console.WriteLine("=== [ColonnaDevelopmentProcess Development Plan] ===");
Console.WriteLine();

Console.WriteLine("=== Solution File ===");
Console.WriteLine();
Console.WriteLine("<code>");
Console.WriteLine("</code>");
Console.WriteLine();
Links("Dependencies");
Console.WriteLine("=== Deploy to ===");
Console.WriteLine();
Console.WriteLine("<code>");
Console.WriteLine("host c:\\developer\\utes\\product name");
Console.WriteLine("</code>");
Console.WriteLine();
Section("Related");

Section("Backlog");

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