<Query Kind="Program" />

void Main()
{
	PrintResult();
}

private static bool IsMultipleOfSeven(int i)
{
	return i % 7 == 0;
}

private static int FindMultiplesOfSeven(
	List<int> numList)
{
	return numList
		.Find(
			IsMultipleOfSeven);
}

private static void PrintResult()
{
	Console.WriteLine(
		"The Multiple of 7 from the number list is {0}",
		FindMultiplesOfSeven(numbers));
}

static List<int> numbers = new List<int>
{
	54, 2, 91, 70, 72, 44, 61, 93,
	73, 3, 56, 5, 38, 60, 29, 32,
	86, 44, 34, 25, 22, 44, 66, 7,
	9, 59, 70, 47, 55, 95, 6, 42
};

