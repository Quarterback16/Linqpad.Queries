<Query Kind="Program" />

void Main()
{
	NonDeferred();
}

private static void NonDeferred()
{
	List<int> intList = new List<int>
	{
		0, 1, 2, 3, 4, 5, 6, 7, 8, 9
	};
	IEnumerable<int> queryInt = intList.Select(
		i => i * 2);
	int queryIntCount = queryInt.Count();  // 10
	List<int> queryIntCached = queryInt.ToList(); 
	int queryIntCachedCount = queryIntCached.Count(); //10
	
	intList.Clear();
	Console.WriteLine(
		String.Format(
			"Enumerate queryInt.Count {0}.", 
			queryIntCount));
	foreach (int i in queryInt)
	{
		Console.WriteLine(i);
	}
	Console.WriteLine(
		String.Format(
			"Enumerate queryIntCached.Count {0}.",
			queryIntCachedCount));
	foreach (int i in queryIntCached)
	{
		Console.WriteLine(i);
	}
}