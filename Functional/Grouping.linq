<Query Kind="Program" />

void Main()
{
	 GroupingByFileNameExtension();
}

public static void GroupingByFileNameExtension()
{
	IEnumerable<string> fileList = Directory
		.EnumerateFiles(
			@"d:\temp\decks",
			"*.*",
			SearchOption.AllDirectories);
			
	IEnumerable<IGrouping<string,string>> query =
	   fileList.GroupBy(
	   	   f => Path.GetFileName(f)[0].ToString());
	
	foreach (IGrouping<string,string> g in query)
	{
		Console.WriteLine();
		Console.WriteLine(
			"File start with the letter: " + g.Key);
		foreach (string filename in g)
		{
			Console.WriteLine(
			   "..." + Path.GetFileName(filename));			   
		}
	}
}