<Query Kind="Program" />

void Main()
{
	int[] intArray =
	{
		0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
		10, 11, 12, 13, 14, 15, 16, 17, 18, 19,
		20, 21, 22, 23, 24, 25, 26, 27, 28, 29,
		30, 31, 32, 33, 34, 35, 36, 37, 38, 39,
		40, 41, 42, 43, 44, 45, 46, 47, 48, 49
	};
	ExtractArray(intArray);
}

public static void ExtractArray(int[] intArray)
{
	//IEnumerable<int> extractedData = System.Linq.Enumerable.
	//	Where(intArray, i => i.IsPrime());
	
	//  the query operator Where is an extension method on the enumerable
	IEnumerable<int> extractedData = intArray.
		Where(i => i.IsPrime());
		
		
	Console.WriteLine(
		"Prime Numbers from 0 - 49 are:");
	foreach (int i in extractedData)
	{
		Console.Write( "{0} \t", i);
	}
	Console.WriteLine();
}
