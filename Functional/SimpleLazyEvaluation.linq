<Query Kind="Program" />

void Main()
{
	GetMember();
}

private static MemberData GetMember()
{
	MemberData member = null;
	try
	{	        
		if (member != null && member.Age > 50)
		{
			Console.WriteLine("IF Statement is TRUE");
			return member;
		}
		else
		{
			Console.WriteLine("IF Statement is FALSE");
			return null;
		}
	}
	catch (Exception ex)
	{
		Console.WriteLine("ERROR " + ex.Message);
		return null;
	}
}

public class MemberData
{
	public string Name { get; set; }
	public string Gender { get; set; }
	public int Age { get; set; }
}