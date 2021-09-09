<Query Kind="Program" />

void Main()
{
	OfTypeCastSimple();
}

public static void OfTypeCastSimple()
{
	ArrayList arraylist = new ArrayList();
	arraylist.AddRange(
		new int[] { 1, 2, 3, 4, 5});
		
	IEnumerable<int> sequenceOfType = arraylist.OfType<int>();
	IEnumerable<int> sequenceCast = arraylist.Cast<int>();

	Console.WriteLine(
		"OfType of arrayList");
	foreach (int i in sequenceOfType)
	{
		Console.Write(".." + i);
	}
	Console.WriteLine();
	Console.WriteLine();
	Console.WriteLine(
	"Cast of arrayList");
	foreach (int i in sequenceCast)
	{
		Console.Write(".." + i);
	}
	Console.WriteLine();
	Console.WriteLine();
}
