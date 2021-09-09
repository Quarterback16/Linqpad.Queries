<Query Kind="Statements" />

var dlc = "Maya and Gran Colombia Pack";
Console.WriteLine($"The {dlc} DLC is a [[CivilizationVI]] extension that came out [[2020-05]]");
Console.WriteLine("  * Apocalypse Mode");
Console.WriteLine("  * Soothsayers");
Console.WriteLine("  * Maya");
Console.WriteLine("  * Gran Colombia");
Console.WriteLine();

Header("Achievements (0/36)");
var cheevos = new List<Achievement>
{
   new Achievement("The stars are right","Win a regular game as Lady Six Sky."),
   new Achievement("El Libertador","Win a regular game as Simón Bolívar."),
   new Achievement("Court of Itzamna","As the Maya found a settlement adjacent to 4 luxury resources"), 
   new Achievement("To plow the sea","As Simón Bolívar activate all the Comandante Generals cross multiple games."), 
   new Achievement("I'll melt with you","Win any Victory with Apocalypse mode enabled."),
   new Achievement("The end of the world as we know it","Be the last person standing after comets begin falling."), 
   new Achievement("The accursed share","Use a max-promotions Soothsayer to sacrifice a max-promotions GDR."), 
};
foreach(var a in cheevos)
{
   AchievementRow(a);
}

Console.WriteLine();
Console.WriteLine();
Section("Related");
Section("Links");

	Console.WriteLine();
	Console.WriteLine("----");
	Console.WriteLine($"<< [[Prev]] (m) [[Next]] >>");	
	Console.WriteLine();
}

void AchievementRow(Achievement cheevo)
{
	Console.WriteLine($"||   ||  {cheevo.Name}  || {cheevo.Description}  ||     ||");
}

void Section(string header)
{
    Header(header);
	Console.WriteLine("  *");
	Console.WriteLine();
}

void Header(string header)
{
	Console.WriteLine($"=== {header} ===");
}

string PrintDate(DateTime printDate)
{
	return printDate.ToString("yyyy-MM-dd");
	
}

public struct Achievement {
  public string Name;
  public string Description;
  
  public Achievement(
      string name,
	  string desc) 
  {
	Name = name;
	Description = desc;
  }	