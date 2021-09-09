<Query Kind="Program" />

void Main()
{
	 //FirstLastOperator();
	 //FirstOrDefaultOperator();
	 //SingleOperator();
	 //ElementAtOperator();
	 DefaultIfEmptyOperator();
}

public static void DefaultIfEmptyOperator()
{
	List<int> numbers = new List<int>();
	//Console.WriteLine(
	//	"DefaultIfEmpty Operator: {0}",
	//	numbers.DefaultIfEmpty());
	foreach (int number in numbers.DefaultIfEmpty())
	{
		Console.WriteLine(
			"DefaultIfEmpty Operator: {0}", number);
	}
}


public static void ElementAtOperator()
{
	Console.WriteLine(
		"ElementAt Operator: {0}",
		numbers.ElementAt(5));
	Console.WriteLine(
		"ElementAtOrDefault Operator: {0}",
		numbers.ElementAtOrDefault(11));
}

public static void SingleOperator()
{
	Console.WriteLine(
		"Single Operator for number can be divided by 7: {0}",
		numbers.Single(n => n % 7 == 0));
	//  single can only have 1 element otherwise it throws an exception	
	//Console.WriteLine(
	//	"Single Operator for number can be divided by 2: {0}",
	//	numbers.Single(n => n % 2 == 0));
	Console.WriteLine(
		"SingleOrDefault Operator: {0}",
		numbers.SingleOrDefault(n => n % 10 == 0));
	//  single can only have 1 element otherwise it throws an exception			
	//Console.WriteLine(
	//	"SingleOrDefault Operator: {0}",
	//	numbers.SingleOrDefault(n => n % 3 == 0));
}

public static void FirstLastOperator()
{
	Console.WriteLine(
		"First Operator: {0}",
		numbers.First());
	Console.WriteLine(
		"First Operator with predicate: {0}",
		numbers.First(n => n % 3 == 0));
	Console.WriteLine(
		"Last Operator: {0}",
		numbers.Last());
	Console.WriteLine(
		"Last Operator with predicate: {0}",
		numbers.Last(n => n % 4 == 0));
}

public static void FirstOrDefaultOperator()
{
	//Console.WriteLine(
	//	"First Operator with predicate: {0}",
	//	numbers.First(n => n % 10 == 0));
	
	//  this will return the default value for an int
	Console.WriteLine(
		"First Operator with predicate: {0}",
		numbers.FirstOrDefault(n => n % 10 == 0));
}

public static int[] numbers = 
{
	1, 2, 3,
	4, 5, 6,
	7, 8, 9
};