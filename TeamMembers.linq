<Query Kind="Program" />

void Main()
{
	var members = new List<TeamMember>();
	members.AddRange( DefineMembers() );
	
    var memberCount = members.Count;
	Console.WriteLine($"Jobseeker team has {memberCount} members");
	int stillToRegister = members.Where( m=>!m.IsOnGovTeams ).Count();
	var pc = ((decimal) stillToRegister / (decimal) memberCount).ToString("0.00%");
	Console.WriteLine($"{stillToRegister} members have still to register {pc} percent");
	foreach (var m in members)
	{
		if (!m.IsOnGovTeams)
		{
			Console.WriteLine(m.FirstName);
			WriteEmail(m);
		}
	}
}

private void WriteEmail(TeamMember m)
{
	Console.WriteLine(new String('-',40));
	Console.WriteLine($"Hi {m.FirstName}");
	Console.WriteLine();
	Console.WriteLine("If you need a hand getting connected, I can come over when you have time.");
	Console.WriteLine();
	Console.WriteLine("Currently you are showing as disconnected");
	Console.WriteLine();
	Console.WriteLine("Cheers");
	Console.WriteLine("Steve");
	Console.WriteLine(new String('-', 40));
}

private List<TeamMember> DefineMembers()
{
	var list = new List<TeamMember>();
	list.Add(new TeamMember { FirstName = "Steve", Surname = "Colonna", IsOnGovTeams = true });
	list.Add(new TeamMember { FirstName = "Vipula", Surname = "Gunawardena", IsOnGovTeams = true });
	list.Add(new TeamMember { FirstName = "Andrew", Surname = " Garrett", IsOnGovTeams = true });
	list.Add(new TeamMember { FirstName = "Srinath", Surname = "Karunakaran", IsOnGovTeams = true });
	list.Add(new TeamMember { FirstName = "Ian", Surname = "Hope", IsOnGovTeams = true });
	list.Add(new TeamMember { FirstName = "Andrew", Surname = "Nishnianidze", IsOnGovTeams = true });
	list.Add(new TeamMember { FirstName = "Jarrod", Surname = "Mann", IsOnGovTeams = true });
	list.Add(new TeamMember { FirstName = "Lucy", Surname = "Patrick", IsOnGovTeams = true });
	list.Add(new TeamMember { FirstName = "Craig", Surname = "Evans", IsOnGovTeams = true });
	list.Add(new TeamMember { FirstName = "Nitin", Surname = "Sabharwal", IsOnGovTeams = true });
	list.Add(new TeamMember { FirstName = "Marina", Surname = "Palombi", IsOnGovTeams = true });
	list.Add(new TeamMember { FirstName = "Barry", Surname = "Barnes", IsOnGovTeams = true });
	list.Add(new TeamMember { FirstName = "Colin", Surname = "Good", IsOnGovTeams = true });
	list.Add(new TeamMember { FirstName = "Marie", Surname = "Birkeland", IsOnGovTeams = true });
	list.Add(new TeamMember { FirstName = "Hina", Surname = "Joesph", IsOnGovTeams = true });

	list.Add(new TeamMember { FirstName = "Sonu", Surname = "Khinda", IsOnGovTeams = false });
	list.Add(new TeamMember { FirstName = "Jess", Surname = "Lintermans", IsOnGovTeams = false });
	list.Add(new TeamMember { FirstName = "Tiffany", Surname = "Lo", IsOnGovTeams = false });
	list.Add(new TeamMember { FirstName = "Dirk", Surname = "Brugman", IsOnGovTeams = false });
	list.Add(new TeamMember { FirstName = "Colette", Surname = "Steindl", IsOnGovTeams = false });
	
	return list;
}

public class TeamMember
{
   public string FirstName { get; set; }
   public string Surname { get; set; }
   public bool IsOnGovTeams { get; set; }
}

// Define other methods and classes here