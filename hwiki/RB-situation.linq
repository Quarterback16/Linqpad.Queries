<Query Kind="Program">
  <DisableMyExtensions>true</DisableMyExtensions>
</Query>

void Main()
{
	var rb = new RbSituation();
	rb.LoadEvents();
	Console.WriteLine(
		rb.Situation());

	//  The Running Backs collection is just a different projection of the events
	rb.ProjectRunningBacks();
	Console.WriteLine($"{rb.RunningBacks.Count} RBs registered");
	//rb.RunningBacks.Dump();
	rb.AllocateRoles();
	var aces = rb.RunningBacks.Where(rb=>rb.Value.Role=="Ace").ToList();
	Console.WriteLine($"{aces.Count} ACEs");
	//aces.Dump();
	
	Console.WriteLine();
	Console.WriteLine("[[RB-situation.linq]]");
}

public class RbSituation
{
	public List<RbEvent> RbEvents { get; set; }
	public List<NflTeam> Teams { get; set; }	
	public Dictionary<string,RunningBack> RunningBacks { get; set; }	
	
	public RbSituation()
	{
		RbEvents = new List<UserQuery.RbEvent>();
		Teams = new List<UserQuery.NflTeam>();
		LoadTeams();
	}
	
	public string Situation()
	{
		var sb = new StringBuilder();
		sb.AppendLine($"#### Date: {DateTime.Now.ToString("yyyy-MM-dd")}");
		sb.AppendLine();
		sb.AppendLine(Heading());
		sb.AppendLine(HeadingSeparator());
		foreach (var team in Teams)
		{
			TeamLine(team,sb);
		}
		return sb.ToString();
	}

	private void TeamLine(
		NflTeam team, 
		StringBuilder sb)
	{
		var situation = new Situation(
			team.TeamCode,
			RbEvents.Where(t=>t.TeamCode == team.TeamCode).ToList());

		sb.Append($"| [[{team.TeamCode}]]  ");
		sb.Append($"| {situation.Ace,-20}  ");
		sb.Append($"| {situation.CommitteeMembers(),-60}  ");
		sb.Append($"| {situation.Bench(),-60}  ");
		sb.Append("|");
		sb.AppendLine();
	}

	string HeadingSeparator()
	{
		return "| --------| --------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |";
	}

	string Heading()
	{
		return "| **Team**| **Ace**               |  **Committee Members**                                        | **Reserves** |";
	}

	public void LoadEvents()
	{
		RbEvents.Add(new RbEvent("AC", "Chase Edmonds", "Start"));
		RbEvents.Add(new RbEvent("AC", "James Conner", "Start"));
		RbEvents.Add(new RbEvent("AC", "Jonathan Ward", "Reserve"));
		RbEvents.Add(new RbEvent("AC", "Eno Benjamin", "Reserve"));
		
		RbEvents.Add(new RbEvent("AF", "Mike Davis", "Start"));
		RbEvents.Add(new RbEvent("AF", "Wayne Gallman", "Reserve"));		
		RbEvents.Add(new RbEvent("AF", "Cordelle Patterson", "Reserve"));
		
		RbEvents.Add(new RbEvent("BB", "Devon Singletary", "Start"));
		RbEvents.Add(new RbEvent("BB", "Zack Moss", "Start"));
		RbEvents.Add(new RbEvent("BB", "Matt Breida", "Reserve"));
		RbEvents.Add(new RbEvent("BB", "Taiwan Jones", "Reserve"));
		
		//		RbEvents.Add(new RbEvent("BR", "JK Dobbins", "Start"));
		RbEvents.Add(new RbEvent("BR", "Gus Edwards", "Start"));
		RbEvents.Add(new RbEvent("BR", "Ty'Son Williams", "Reserve"));
		
		RbEvents.Add(new RbEvent("CH", "David Montgomery", "Start"));
		RbEvents.Add(new RbEvent("CH", "Damien Williams", "Reserve"));
		RbEvents.Add(new RbEvent("CH", "Tarik Cohen", "Reserve"));
		
		RbEvents.Add(new RbEvent("CI", "Joe Mixon", "Start"));
		RbEvents.Add(new RbEvent("CI", "Samaje Perine", "Reserve"));
		RbEvents.Add(new RbEvent("CI", "Chris Evans", "Reserve"));

		RbEvents.Add(new RbEvent("CL", "Nick Chubb", "Start"));
		RbEvents.Add(new RbEvent("CL", "Kareem Hunt", "Start"));
		RbEvents.Add(new RbEvent("CL", "D'Ernest Johnson", "Reserve"));
		RbEvents.Add(new RbEvent("CL", "Demetric Felton", "Reserve"));

		RbEvents.Add(new RbEvent("CP", "Christian McCaffrey", "Start"));
		RbEvents.Add(new RbEvent("CP", "Chubba Hubbard", "Reserve"));
		RbEvents.Add(new RbEvent("CP", "Royce Freeman", "Reserve"));		
		
		RbEvents.Add(new RbEvent("DB", "Melvin Gordon", "Start"));
		RbEvents.Add(new RbEvent("DB", "Javonte Williams", "Start"));
		RbEvents.Add(new RbEvent("DB", "Nate McCrary", "Reserve"));

		RbEvents.Add(new RbEvent("DC", "Eziekiel Elliott", "Start"));
		RbEvents.Add(new RbEvent("DC", "Tony Pollard", "Reserve"));
		RbEvents.Add(new RbEvent("DC", "Cory Clement", "Reserve"));
		
		RbEvents.Add(new RbEvent("DL", "D'Andre Swift", "Start"));
		RbEvents.Add(new RbEvent("DL", "Jamaal Williams", "Reserve"));
		RbEvents.Add(new RbEvent("DL", "Godwin Igwebuike", "Reserve"));		
		RbEvents.Add(new RbEvent("DL", "Jermar Jefferson", "Reserve"));				
		
		RbEvents.Add(new RbEvent("GB", "Aaron Jones", "Start"));
		RbEvents.Add(new RbEvent("GB", "AJ Dillon", "Reserve"));
		RbEvents.Add(new RbEvent("GB", "Kylin Hill", "Reserve"));

		RbEvents.Add(new RbEvent("HT", "David Johnson", "Start"));
		RbEvents.Add(new RbEvent("HT", "Mark Ingram", "Start"));
		RbEvents.Add(new RbEvent("HT", "Phillip Lindsay", "Start"));
		RbEvents.Add(new RbEvent("HT", "Rex Burkhead", "Reserve"));
		RbEvents.Add(new RbEvent("HT", "Scottie Phillips", "Reserve"));
		
		RbEvents.Add(new RbEvent("IC", "Jonathan Taylor", "Start"));
		RbEvents.Add(new RbEvent("IC", "Marlon Mack", "Reserve"));
		RbEvents.Add(new RbEvent("IC", "Nyheim Hines", "Reserve"));
		RbEvents.Add(new RbEvent("IC", "Jordan Wilkins", "Reserve"));
		
		RbEvents.Add(new RbEvent("JJ", "James Robinson", "Start"));
		RbEvents.Add(new RbEvent("JJ", "Carlos Hyde", "Reserve"));
		RbEvents.Add(new RbEvent("JJ", "Dare Ogunbowale", "Reserve"));
		
		RbEvents.Add(new RbEvent("MD", "Miles Gaskin", "Start"));
		RbEvents.Add(new RbEvent("MD", "Salvon Ahmed", "Reserve"));
		RbEvents.Add(new RbEvent("MD", "Mike Brown", "Reserve"));

		RbEvents.Add(new RbEvent("MV", "Dalvin Cook", "Start"));
		RbEvents.Add(new RbEvent("MV", "Alexander Mattison", "Reserve"));
		
		RbEvents.Add(new RbEvent("NE", "Damien Harris", "Start"));
		RbEvents.Add(new RbEvent("NE", "James White", "Reserve"));
		RbEvents.Add(new RbEvent("NE", "Rhamondre Stevenson", "Reserve"));
		RbEvents.Add(new RbEvent("NE", "JJ Taylor", "Reserve"));
		RbEvents.Add(new RbEvent("NE", "Brandon Bolden", "Reserve"));
		
		RbEvents.Add(new RbEvent("NG", "Saquon Barkley", "Start"));
		RbEvents.Add(new RbEvent("NG", "Devontae Booker", "Reserve"));
		RbEvents.Add(new RbEvent("NG", "Gary Brightwell", "Reserve"));		
		
		RbEvents.Add(new RbEvent("NJ", "Michael Carter", "Start"));
		RbEvents.Add(new RbEvent("NJ", "Tevin Coleman", "Start"));
		RbEvents.Add(new RbEvent("NJ", "Ty Johnson", "Start"));
		RbEvents.Add(new RbEvent("NJ", "Josh Adams", "Reserve"));

		RbEvents.Add(new RbEvent("NO", "Alvin Kamara", "Start"));
//		RbEvents.Add(new RbEvent("NO", "Latavius Murray", "Reserve"));
		RbEvents.Add(new RbEvent("NO", "Tony Jones", "Reserve"));
		RbEvents.Add(new RbEvent("NO", "Dwayne Washington", "Reserve"));

		RbEvents.Add(new RbEvent("LV", "Josh Jacobs", "Start"));
		RbEvents.Add(new RbEvent("LV", "Kenyan Drake", "Reserve"));
		RbEvents.Add(new RbEvent("LV", "Peyton Barber", "Reserve"));

		RbEvents.Add(new RbEvent("PE", "Miles Sanders", "Start"));
		RbEvents.Add(new RbEvent("PE", "Boston Scott", "Reserve"));
		RbEvents.Add(new RbEvent("PE", "Kenneth Gainwell", "Reserve"));

		RbEvents.Add(new RbEvent("PS", "Najee Harris*", "Start"));
		RbEvents.Add(new RbEvent("PS", "Benny Snell", "Reserve"));
		RbEvents.Add(new RbEvent("PS", "Kallen Ballage", "Reserve"));

		RbEvents.Add(new RbEvent("LC", "Austin Ekeler", "Start"));
		RbEvents.Add(new RbEvent("LC", "Justin Jackson", "Start"));
		RbEvents.Add(new RbEvent("LC", "Joshua Kelley", "Start"));
		RbEvents.Add(new RbEvent("LC", "Larry Rountree", "Start"));

		RbEvents.Add(new RbEvent("LR", "Darrell Henderson", "Start"));
		RbEvents.Add(new RbEvent("LR", "Sony Michel", "Reserve"));
		RbEvents.Add(new RbEvent("LR", "Jake Funk", "Reserve"));		
		
		RbEvents.Add(new RbEvent("KC", "CEH", "Start"));
		RbEvents.Add(new RbEvent("KC", "Darrel Williams", "Reserve"));
		RbEvents.Add(new RbEvent("KC", "Jerick McKinnon", "Reserve"));

		RbEvents.Add(new RbEvent("SF", "Raheem Mostert", "Start"));
		RbEvents.Add(new RbEvent("SF", "Tre Sermon", "Reserve"));
		RbEvents.Add(new RbEvent("SF", "Jamycal Hasty", "Reserve"));
		RbEvents.Add(new RbEvent("SF", "Elijah Mitchell", "Reserve"));		

		RbEvents.Add(new RbEvent("SS", "Chris Carson", "Start"));
		RbEvents.Add(new RbEvent("SS", "Rashaad Penny", "Reserve"));
		RbEvents.Add(new RbEvent("SS", "Alex Collins", "Reserve"));
		RbEvents.Add(new RbEvent("SS", "Travis Homer", "Reserve"));
		RbEvents.Add(new RbEvent("SS", "DeeJay Dallas", "Reserve"));

		RbEvents.Add(new RbEvent("TB", "Ronald Jones", "Start"));
		RbEvents.Add(new RbEvent("TB", "Leonard Fournette", "Start"));
		RbEvents.Add(new RbEvent("TB", "Giovanni Bernard", "Reserve"));	
		RbEvents.Add(new RbEvent("TB", "Ke'Shawn Vaughn", "Reserve"));				
		
		RbEvents.Add(new RbEvent("TT", "Derrick Henry", "Start"));
		RbEvents.Add(new RbEvent("TT", "Jeremy McNichols", "Reserve"));
		
		RbEvents.Add(new RbEvent("WR", "Antonio Gibson", "Start"));
		RbEvents.Add(new RbEvent("WR", "JD McKissic", "Reserve"));
		RbEvents.Add(new RbEvent("WR", "Jaret Patterson", "Reserve"));		
		
		RbEvents.Add(new RbEvent("KC", "CEH", "ankle", "probable", new DateTime(2021,09,6)));
		RbEvents.Add(new RbEvent("KC", "Darrel Williams", "concussion", "probable", new DateTime(2021,09,6)));
		RbEvents.Add(new RbEvent("CH", "Tarik Cohen", "PUP", "OUT", new DateTime(2021,09,8)));
		RbEvents.Add(new RbEvent("DL", "D'Andre Swift", "groin", "probable", new DateTime(2021,09,8)));		
		RbEvents.Add(new RbEvent("NO", "Latavius Murray", "CUT", "2021-09-08"));

		RbEvents.Add(new RbEvent("DL", "D'Andre Swift", "groin", "probable", new DateTime(2021, 09, 8)));
		RbEvents.Add(new RbEvent("NO", "Latavius Murray", "CUT", "2021-09-08"));
		RbEvents.Add(new RbEvent("NE", "Rhamondre Stevenson", "thumb", "probable", new DateTime(2021, 09, 9)));
		RbEvents.Add(new RbEvent("LC", "Austin Elker", "hamstring", "probable", new DateTime(2021, 09, 9)));

	}
	

	private void LoadTeams()
	{
		Teams.Add(new NflTeam("AC"));
		Teams.Add(new NflTeam("AF"));
		Teams.Add(new NflTeam("BB"));
		Teams.Add(new NflTeam("BR"));
		Teams.Add(new NflTeam("CH"));
		Teams.Add(new NflTeam("CI"));
		Teams.Add(new NflTeam("CL"));
		Teams.Add(new NflTeam("CP"));
		Teams.Add(new NflTeam("DB"));
		Teams.Add(new NflTeam("DC"));
		Teams.Add(new NflTeam("DL"));
		Teams.Add(new NflTeam("GB"));
		Teams.Add(new NflTeam("HT"));
		Teams.Add(new NflTeam("IC"));
		Teams.Add(new NflTeam("JJ"));
		Teams.Add(new NflTeam("MD"));
		Teams.Add(new NflTeam("MV"));
		Teams.Add(new NflTeam("NE"));
		Teams.Add(new NflTeam("NG"));
		Teams.Add(new NflTeam("NJ"));
		Teams.Add(new NflTeam("NO"));
		Teams.Add(new NflTeam("LV"));
		Teams.Add(new NflTeam("PE"));
		Teams.Add(new NflTeam("PS"));
		Teams.Add(new NflTeam("LC"));
		Teams.Add(new NflTeam("LR"));
		Teams.Add(new NflTeam("KC"));
		Teams.Add(new NflTeam("SF"));
		Teams.Add(new NflTeam("SS"));
		Teams.Add(new NflTeam("TB"));
		Teams.Add(new NflTeam("TT"));
		Teams.Add(new NflTeam("WR"));
	}

	internal void ProjectRunningBacks()
	{
		RunningBacks = new Dictionary<string,RunningBack>();
		foreach (var rb in RbEvents)
		{
			if (rb.Action == "Start" || rb.Action == "Reserve")
			{
				if (!RunningBacks.ContainsKey(rb.Name))
					AddRb(rb);
			}
		}
	}

	private void AddRb(RbEvent rb)
	{
		var newRb = new RunningBack
		{
			Name = rb.Name,
			TeamCode = rb.TeamCode,
			Role = rb.Action,			
		};
		RunningBacks.Add( rb.Name, newRb );
	}

	internal void AllocateRoles()
	{
		foreach (var team in Teams)
		{
			CheckTeam(team);
		}
	}

	private void CheckTeam(NflTeam team)
	{
		var teamEvents = RbEvents
			.Where(t => t.TeamCode == team.TeamCode)
			.OrderBy(t => t.EventDate)
			.ToList();
		var starterCount = 0;
		var committee = new List<string>();
		var reserves = new List<string>();
		var ace = string.Empty;
		foreach (var ev in teamEvents)
		{
			if (ev.Action == "Start")
			{
				ace = ev.Name;
				starterCount++;
				if (starterCount > 1)
					ace = string.Empty;
				committee.Add(ev.Name);
			}
			if (ev.Action == "Reserve")
			{
				reserves.Add(ev.Name);
			}
		}
		if (!string.IsNullOrEmpty(ace))
			MakeAce(ace);
	}

	private void MakeAce(string ace)
	{
		var rb = RunningBacks[ace];
		rb.Role = "Ace";
		RunningBacks[ace] = rb;
	}
}

public class RunningBack
{
	public string Name { get; set; }
	public string Role { get; set; }
	public string TeamCode { get; set; }
	public string Injury { get; set; }
	public string Status { get; set; }
}

public class Situation
{
	public string TeamCode { get; set; }	
	public string Ace { get; set; }
	public List<string> Committee { get; set; }
	public List<string> Reserves { get; set; }
	public Situation(
		string teamCode,
		List<RbEvent> events)
	{
		Committee = new List<string>();
		Reserves = new List<string>();
		TeamCode = teamCode;
		Ace = string.Empty;
		var starterCount = 0;
		var sortedEvents = events.OrderBy(e=>e.EventDate).ToList();
		foreach (var ev in events)
		{
			if (ev.Action == "Start")
			{
				Ace = ev.Name;
				starterCount++;
				if (starterCount > 1)
					Ace = string.Empty;
				Committee.Add(ev.Name);
			}
			if (ev.Action == "Reserve")
			{
				Reserves.Add(ev.Name);
			}
			if (ev.Action == "INJ")
				Tag( ev );
		}

	}

	private void Tag(RbEvent ev)
	{
		if (Ace == ev.Name)
		{
			Ace = TagHim(Ace, ev);
			return;
		}
		for (int i = 0; i < Committee.Count; i++)
		{
			if (Committee[i] == ev.Name)
			{
				Committee[i] = TagHim(Committee[i], ev);
				return;
			}
		}
		for (int i = 0; i < Reserves.Count; i++)
		{
			if (Reserves[i] == ev.Name)
			{
				Reserves[i] = TagHim(Reserves[i], ev);
				return;
			}
		}
	}

	string TagHim(string name, RbEvent ev)
	{
		return $"{name} ({ev.InjuryLoc}, {ev.Status})";
	}

	public string CommitteeMembers()
	{
		var sb = new StringBuilder();
		if (string.IsNullOrEmpty(Ace))
		{
			foreach (var member in Committee)
			{
				sb.Append(member);
				sb.Append(", ");
			}
		}
		return TrimIt(sb.ToString());
	}

	public string Bench()
	{
		var sb = new StringBuilder();
		foreach (var member in Reserves)
		{
			sb.Append(member);
			sb.Append(", ");
		}
		return TrimIt(sb.ToString());
	}

	private string TrimIt(string it)
	{
		if (it.Length > 0)
			it = it.Substring(0, it.Length - 2);
		return it;
	}
}



public class NflTeam
{
	public string TeamCode { get; set; }	
	public NflTeam(
		string teamCode)
	{
		TeamCode = teamCode;
	}
}

public class RbEvent
{
	public DateTime EventDate { get; set; }
	public string TeamCode { get; set; }
	public string Name { get; set; }
	public string Action { get; set; }
	public string InjuryLoc { get; set; }
	public string Status { get; set; }
	public string TrainingLevel { get; set; }
	public RbEvent(
		string teamCode,
		string name,
		string actionCode,
		string eventDate = "2021-09-01")
	{
		Name = name;
		TeamCode = teamCode;
		Action = actionCode;
		EventDate = DateTime.Parse(eventDate);
	}
	public RbEvent(
		string teamCode,
		string name,
		string location,
		string status,
		DateTime date
		)
	{
		Name = name;
		TeamCode = teamCode;
		Action = "INJ";
		EventDate = DateTime.Now.Date;
		InjuryLoc = location;
		Status = status;
		EventDate = date;
	}
}

