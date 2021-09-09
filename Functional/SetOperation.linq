<Query Kind="Program" />

void Main()
{
	//ConcatUnionOperator();
	IntersectExceptOperator();
}

static int[] sequence1 = { 1, 2, 3, 4, 5, 6 };
static int[] sequence2 = { 3, 4, 5, 6, 7, 8 };

public static void ConcatUnionOperator()
{
	IEnumerable<int> concat = sequence1.Concat(sequence2);
	IEnumerable<int> union = sequence1.Union(sequence2);
	Console.WriteLine("Concat");
	foreach (int i in concat)
	{
		Console.Write(".." + i);
	}
	Console.WriteLine();
	Console.WriteLine();
	Console.WriteLine("Union");
	foreach (int i in union)
	{
		Console.Write(".." + i);
	}
	Console.WriteLine();
	Console.WriteLine();
}

public static void IntersectExceptOperator()
{
	IEnumerable<int> intersect = sequence1.Intersect(sequence2);
	IEnumerable<int> except1 = sequence1.Except(sequence2);
	IEnumerable<int> except2 = sequence2.Except(sequence1);
	Console.WriteLine("Intersect of Sequence");
	foreach (int i in intersect)
	{
		Console.Write(".." + i);
	}
	Console.WriteLine();
	Console.WriteLine();
	Console.WriteLine("Except1");
	foreach (int i in except1)
	{
		Console.Write(".." + i);
	}
	Console.WriteLine();
	Console.WriteLine();
	Console.WriteLine("Except2");
	foreach (int i in except2)
	{
		Console.Write(".." + i);
	}
	Console.WriteLine();
	Console.WriteLine();
}
