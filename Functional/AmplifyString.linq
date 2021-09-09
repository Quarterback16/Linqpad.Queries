<Query Kind="Program" />

void Main()
{
	AmplifyString();
}

private static void AmplifyString()
{
	IEnumerable<string> stringEnumerable
		= YieldNames();
	Console.WriteLine(
		"Enumerate the stringEnumerable");
	foreach (string s in stringEnumerable)
	{
		Console.WriteLine(
			"- {0}", s);
	}
	IEnumerable<string> stringSorted = SortAscending(stringEnumerable);
	Console.WriteLine();
	Console.WriteLine(
		"Sort the stringEnumerable");
	foreach (string s  in stringSorted)
	{
		Console.WriteLine(
			"- {0}", s);
	}
}

private static IEnumerable<string> YieldNames()
{
	yield return "Nicholas Shaw";
	yield return "Anthony Hammond";
	yield return "Desiree Waller";
	yield return "Gloria Allen";
	yield return "Daniel McPherson";
}

private static IEnumerable<string> SortAscending(
	IEnumerable<string> enumString)
{
	return enumString.OrderBy(s => s);
}