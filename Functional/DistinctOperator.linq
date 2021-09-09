<Query Kind="Program" />

void Main()
{
	DistinctOperator();
}

public static void DistinctOperator()
{
	string words = "TheQuickBrownFoxJumpsOverTheLazyDog";
	IEnumerable<char> queryDistinct = words.Distinct();
	string distinctWords = "";
	foreach (var c in queryDistinct)
	{
		distinctWords += c.ToString();
	}
	Console.WriteLine( distinctWords );
}
