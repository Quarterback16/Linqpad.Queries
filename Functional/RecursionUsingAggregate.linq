<Query Kind="Program" />

void Main()
{
	GetFactorialAggregate(5);
}

private static void GetFactorialAggregate(
	int intNumber)
{
	IEnumerable<int> ints =	Enumerable.Range(1, intNumber);
	
	//  Aggregate works a bit like for each element in the sequence do x to it
	int factorialNumber = ints.Aggregate((accumulator, element) => accumulator * element);
	
	Console.WriteLine(
		"{0}! (using Aggregate) is {1}",
		intNumber, 
		factorialNumber);
}
