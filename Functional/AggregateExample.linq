<Query Kind="Program" />

void Main()
{
	AggregateInt();
	AggregateString();
}

private static void AggregateInt()
{
	List<int> listInt = new List<int>() { 1, 2, 3, 4, 5, 6 };
	
	int addition = listInt.Aggregate(
		(sum, i) => sum + i);
		
	Console.WriteLine(
		"The sum of listInt is " + addition);
}

private static void AggregateString()
{
	List<string> listString = new List<string>()
		{
			"The", "quick", "brown", "fox", "jumps", "over",
			"the", "lazy", "dog"
		};
	string stringAggregate = listString.Aggregate((strAll, str) =>
	strAll + " " + str);
	Console.WriteLine(stringAggregate);
}
