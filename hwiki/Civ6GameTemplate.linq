<Query Kind="Program" />

void Main()
{
	var startDate = DateTime.Now;
    var civ = "Portugal";
	var leader = "Joao III";
	var game = 2;
	var objs = new string[]
	{
		"create cities with Harbour+City Centre+ Commerce Hub triangles plus a Campus somewhere",
        "tryout new Wetlands map",
        "get new Wonder Etemenanki",
        "try ZombiesGameMode",
		"maintain Science Lead",
		"build triplets"
	};
	
	ProjectHeader(
		startDate,
		$"Win with {leader} [[{civ}]]");
    VictoryTypes();
	GameObjectives(
		objs);
	TaskList();
	Section("Related");
	ThreadingLine(
		civ,
		game);
	Line();
	LingPadFile("Civ6GameTemplate");
}

void GameObjectives(
	string[] objs)
{
	Console.WriteLine($"=== Game Objectives ===");
	foreach (var obj in objs)
	{
		Console.WriteLine($"  1. {obj}");
	}
	Console.WriteLine();
}

void ThreadingLine(
	string civ,
	int game)
{
	Console.WriteLine("----");
	Console.WriteLine($"  * < [[Civ_VI_{civ}_Game_{game-1}]] (m) [[Civ_VI_{civ}_Game_{game+1}]]  >");
}

void LingPadFile(string filename)
{
	var lpf = new LinqpadFile(
		filename);
	Console.WriteLine(lpf.FileOut());
}

private void TaskList()
{
	Header("Tasks");
	Task("Ancient");
	Task("Classical");
	Task("Medieval");
	Task("Renaissance");
	Task("Industrial");
	Task("Modern");
	Task("Atomic");
	Task("Information");
	Console.WriteLine();
}

private void WriteItem(
	string item)
{
	Console.WriteLine($"    * {item}:-");
}

void FindStrategicResource(string era)
{
	var resource = "";
	var tech = "";
	if (era == "Ancient")
	{
		resource = "Horses";
		tech = "Horseback riding";
	}
	if (era == "Classical")
	{
		resource = "Iron";
		tech = "Bronze Working";
	}
	if (era == "Medieval")
	{
		resource = "Niter";
		tech = "Military Engineering";
	}
	if (era == "Industrial")
	{
		resource = "Coal";
		tech = "Industrialisation";
	}
	if (era == "Modern")
	{
		resource = "Oil";
		tech = "Refining";
	}
	if (era == "Atomic")
	{
		resource = "Uranium";
		tech = "Combined Arms";
	}
	if (!string.IsNullOrEmpty(resource))
	{
		Console.WriteLine($"    * () Find {resource} revealed by {tech}");
	}
}

void Task(string era)
{
	Console.WriteLine($"  1. () {era} Era : start T??? {Metrics(era)}");
	WriteItem("Normal: Dedication HicSuntDracones, ReformTheCoinage, HeartbeatOfSteam, ToArms");
	FindStrategicResource(era);
	var sections = new List<string>
		{
			"Discounts",
			"Government",			
			"Key Tech",
			"Key Civic",
			"Districts",
			"Improvements",
			"Units",
			"Buildings",
			"Wonders",
			"Eurekas",
			"Inspirations",
			"Quests"
		};
	foreach (var item in sections)
	{
		WriteItem(item);
		if (item == "Eurekas")
			Eurekas(era);
		if (item == "Inspirations")
			Inspirations(era);
		if (item == "Quests")
			QuestTemplate();
	}
}

void Eurekas(string era)
{
	var events = new List<Discovery>();
	if (era == "Ancient")
	{
		events.Add(new Discovery("Slinger kill", "Archery"));
		events.Add(new Discovery("Build a quarry", "Masonry"));
		events.Add(new Discovery("Discover natural wonder", "Astrology"));
		events.Add(new Discovery("Mine a resource", "Wheel"));
		events.Add(new Discovery("Kill 3 barbs", "Bronze Working"));
		events.Add(new Discovery("Meet another Civ", "Writing"));
		events.Add(new Discovery("City on the coast", "Sailing"));
		events.Add(new Discovery("Farm a resource", "Irrigation"));
	}
	if (era == "Classical")
	{
		events.Add(new Discovery("Build a pasture", "Horseback riding"));
		events.Add(new Discovery("Build a water mill", "Construction"));
		events.Add(new Discovery("Build an Iron mine", "Iron Working"));
		events.Add(new Discovery("Recruit a Great Scientist", "Education"));
		events.Add(new Discovery("Own 2 galleys", "Ship Building"));
		events.Add(new Discovery("Improve 2 sea resources", "Celestial Navigation"));
		events.Add(new Discovery("Build ancient walls", "Engineering"));
		events.Add(new Discovery("Build a Lumber mill", "Mass Production"));
		events.Add(new Discovery("Kill a unit with a spearman", "Military Tactics"));
		events.Add(new Discovery("Have a Trade Route", "Currency"));
	}
	if (era == "Medieval")
	{
		events.Add(new Discovery("3 archers", "Machinery"));
		events.Add(new Discovery("3 mines", "Apprenticeship"));
		events.Add(new Discovery("Knight kill", "Military Science"));
		events.Add(new Discovery("Build Aqueduct", "Military Engineering"));
		events.Add(new Discovery("Have Feudalism civic", "Stirrups"));
		events.Add(new Discovery("Govt with 6 policy slots", "Castles"));
		events.Add(new Discovery("2 Forts", "Ballistics"));		
	}
	if (era == "Renaissance")
	{
		events.Add(new Discovery("Build lumber mill", "Mass Production"));
		events.Add(new Discovery("Know Guilds civic", "Banking"));
		events.Add(new Discovery("2 harbours", "Cartography"));
		events.Add(new Discovery("3 crossbowmen", "Metal Casting"));
		events.Add(new Discovery("2 bombards", "Siege Tactics"));
		events.Add(new Discovery("Musket kill", "Square Rigging"));
		events.Add(new Discovery("Build Uni next to Mountain", "Astronomy"));
		events.Add(new Discovery("2 Unis", "Printing"));
		events.Add(new Discovery("Build Armoury", "Gunpowder"));
	}
	if (era == "Industrial")
	{
		events.Add(new Discovery("2 Unis", "Printing"));
		events.Add(new Discovery("2 Workshops", "Industrialisation"));
		events.Add(new Discovery("Know Enlightenment civic", "Scientific Theory"));
		events.Add(new Discovery("Knight kill", "Military Science"));
		events.Add(new Discovery("Mine Niter", "Rifling"));
		events.Add(new Discovery("2 Banks", "Economics"));
		events.Add(new Discovery("2 Shipyards", "Steam Power"));
		events.Add(new Discovery("2 Neighbourhoods", "Sanitation"));
	}
	if (era == "Modern")
	{
		events.Add(new Discovery("IndustrialWonder", "Flight"));
		events.Add(new Discovery("3 Musketmen", "Replaceable Parts"));
		events.Add(new Discovery("Coal Mine and Ironclad", "Steel"));
		events.Add(new Discovery("Coal Power Plant", "Refining"));
		events.Add(new Discovery("National Park", "Radio"));
		events.Add(new Discovery("2 Privateers", "Electricity"));
		events.Add(new Discovery("level 2 Alliance", "Chemistry"));
		events.Add(new Discovery("Extract an Artifact", "Combustion"));
	}
	if (era == "Atomic")
	{
		events.Add(new Discovery("Spy or Scientist", "Rocketry"));
		events.Add(new Discovery("Spy or Scientist", "Nuclear Fission"));
	}
	if (era == "Information")
	{
		events.Add(new Discovery("Have Globalisation civic", "Robotics"));
		events.Add(new Discovery("2 Broadcast Centres", "Satellites"));
		events.Add(new Discovery("2 Drones", "Lasers"));
		events.Add(new Discovery("Kill a Fighter", "Guidance Sytems"));
		events.Add(new Discovery("Spy or Scientist", "Stealth Technology"));
		events.Add(new Discovery("3 Tanks", "Composites"));
		events.Add(new Discovery("build an Aluminum mine", "Nonotechnology"));
		events.Add(new Discovery("Build a Nuclear Power Plant", "Nuclear Fission"));
	}
	foreach (var item in events)
		item.Display();
		
}
void Inspirations(string era)
{
	var events = new List<Discovery>();
	if (era == "Ancient")
	{
		events.Add(new Discovery("Discover a second continent", "Foreign Trade"));
		events.Add(new Discovery("Improve 3 tiles", "Craftsmanship"));
		events.Add(new Discovery("Clear barb camp", "Military Tradition"));
		events.Add(new Discovery("Build specialty district", "State Workforce"));
		events.Add(new Discovery("Found a Pantheon", "Mysticism"));
		events.Add(new Discovery("Pop 6", "Early Empire"));
		events.Add(new Discovery("Meet 3 city states", "Political Philosophy"));
		events.Add(new Discovery("Build a wonder", "Drama and Poetry"));
	}
	if (era == "Classical")
	{
		events.Add(new Discovery("Found a religion", "Theology"));
		events.Add(new Discovery("Build 3 distinct Districts", "Mathematics"));
		events.Add(new Discovery("Build 2 Campus", "Recorded History"));
		events.Add(new Discovery("Quadrireme kill", "Naval Tradition"));
		events.Add(new Discovery("8 Land units", "Mercenaries"));
		events.Add(new Discovery("4 trade routes", "Medieval Faires"));
		events.Add(new Discovery("Build 2 Markets", "Guilds"));
		events.Add(new Discovery("Build 2 Temples", "Divine right"));
	}

	if (era == "Medieval")
	{
		events.Add(new Discovery("Pop 10", "Civil Service"));
		events.Add(new Discovery("6 farms", "Feudalism"));
		events.Add(new Discovery("2 temples", "Divine Right"));
	}
	if (era == "Renaissance")
	{
		events.Add(new Discovery("2 caravels", "Exploration"));
		events.Add(new Discovery("3 Great People", "The Enlightenment"));
		events.Add(new Discovery("Earn a Great Artist", "Humanism"));
		events.Add(new Discovery("Great Merchant", "Mercantilism"));
		events.Add(new Discovery("Have an Aliance", "Diplo Service"));	
		events.Add(new Discovery("v 6 cities following ur religion", "Reformed Church"));		
	}
	if (era == "Industrial")
	{
		events.Add(new Discovery("Research Astronomy", "Colonialism"));
		events.Add(new Discovery("7 different districts", "Civil Engineering"));
		events.Add(new Discovery("Declar war with Casus belli", "Nationalism"));
		events.Add(new Discovery("Build Art Museum", "Opera and Ballet"));
		events.Add(new Discovery("Build Archaeological Museum", "Natural History"));
		events.Add(new Discovery("15 pop city", "Urbanisation"));
	}
	if (era == "Modern")
	{
		events.Add(new Discovery("Breathtaking Neighbourhood", "Conservatism"));
		events.Add(new Discovery("Research Radio", "Mass Media"));
		events.Add(new Discovery("3 Corps", "Mobilization"));
		events.Add(new Discovery("2 Stock Exchanges", "Capitalism"));
	}
	if (era == "Atomic")
	{
		events.Add(new Discovery("Have a themed building", "Cultural Heritage"));
		events.Add(new Discovery("Research Nuclear Fission", "Cold War"));
		events.Add(new Discovery("Build an Aerodrome on a foreign continent", "Rapid Deployment"));
		events.Add(new Discovery("Build a Space port", "Space Race"));
		events.Add(new Discovery("2 Entertainment Centres", "Professional Sports"));
	}
	if (era == "Information")
	{
		events.Add(new Discovery("Mine Uranium", "Venture Politics"));
		events.Add(new Discovery("10 slot Govt", "Near Future Governance"));
		events.Add(new Discovery("own a Rock band", "Disttributed Sovreignity"));
		events.Add(new Discovery("Research Robotics", "Optimization Imperitive"));
		events.Add(new Discovery("Research Telecommunications", "Social Media"));
		events.Add(new Discovery("2 Air Ports", "Globalisation"));
		events.Add(new Discovery("2 Solar Farms", "Environmentalism"));
	}
	foreach (var item in events)
		item.Display();
}

void Links(string header)
{
	Console.WriteLine($"=== {header} ===");
	Console.WriteLine("  1.");
	Console.WriteLine();
}

string Metrics(string era)
{
	if (era == "Ancient")
		return "Sci: 0 Cul: 0 Fai: 0 Gol: 0 Dip: 0";
	return "Sci: nn Cul: nn Fai: nn Gol: nn Dip: nn";
	
}
void QuestTemplate()
{
	Console.WriteLine("      * () CityState___ : quest");
}

private void VictoryTypes()
{
	Header("Victory Type");
	Numb("[[Civ6_ScienceVictory]]");
	Numb("[[Civ6_ReligiousVictory]]");
	Numb("[[Civ6_CulturalVictory]]");
	Numb("[[Civ6_DiplomaticVictory]]");
	Numb("[[Civ6_DominationVictory]]");
	Console.WriteLine();
}

void Numb(string line)
{
	Console.WriteLine($"  1. {line}");
}

void Line()
{
	Console.WriteLine("----");
}

void Header(string header)
{
	Console.WriteLine($"=== {header} ===");
}

private void ProjectHeader(
	DateTime startDate,
	string theGoal)
{
	string[] cells = {
			"**Project Start Date:**",
			$"{startDate.ToString("yyyy-MM-dd")}",
			"**End Date:**",
			"",
			"**Status:**",
			"#active"
		};
	Console.WriteLine(
	   TableCells(
		  cells));
	GoalLine(theGoal);
	cells[0] = "**Estimated Time Needed**";
	cells[1] = "8 blocks";
	cells[2] = string.Empty;
	cells[4] = string.Empty;
	cells[5] = string.Empty;
	Console.WriteLine(
	   TableCells(
		  cells));
	Console.WriteLine();
}

private void GoalLine(string idea)
{
	Console.WriteLine(
	  $"||  **Goal** or **[[Objective]]**  ||||||||||| {idea} by ??  ||");
}                                          

string TableCells(string[] cells)
{
	var tableRow = "||  ";
	for (int i = 0; i < cells.Length; i++)
	{
		tableRow += "  " + cells[i] + "  ||";
	}
	return tableRow;
}

void Section(string header)
{
	Console.WriteLine($"=== {header} ===");
	Console.WriteLine("  *");
	Console.WriteLine();
}

public class LinqpadFile
{
	public string FileName { get; set; }
	public LinqpadFile(string fileName)
	{
		FileName = fileName;
	}
	public string FileOut()
	{
		return $"  * //<code>{FileName}.linq</code>//";
	}
}

public class Discovery
{
	public string Event { get; set; }
	public string Reward { get; set; }

	public Discovery(string theEvent, string reward)
	{
		Event = theEvent;
		Reward = reward;
	}

	public void Display()
	{
		Console.WriteLine($"      * () {Event} > {Reward}");
	}
}