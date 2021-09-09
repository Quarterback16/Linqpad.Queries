<Query Kind="Program" />

void Main()
{	
	OrderByOperator();
	//OrderByOperatorWithComparer();
}

static List<string> nameList = new List<string>
	{
		"Blair", "lane", "Jessie", "Aiden",
		"Reggie", "Tanner", "Maddox", "Kerry"
	};


public static void OrderByOperator()
{
	IEnumerable<string> query = nameList
		.OrderBy(n => n.Length)
		.ThenBy( n => n);
	foreach (var s in query)
	{
		Console.WriteLine(s);
	}
}

public static void OrderByOperatorWithComparer()
{
	IEnumerable<string> query = nameList.OrderBy(
		n => n,
		new LastCharacterComparer());
	foreach (var s in query)
	{
		Console.WriteLine(s);
	}
}

public class LastCharacterComparer : IComparer<string>
{
	public int Compare(string x, string y)
	{
		return string.Compare(
		   x[x.Length-1].ToString(),
		   y[y.Length-1].ToString());
	}
}

