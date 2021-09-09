<Query Kind="Program" />

void Main()
{
	Console.WriteLine( "Enter an integer number ");
	int inputNumber = Convert.ToInt32(Console.ReadLine());
	
	IEnumerable<int> ints = Enumerable.Range(1, inputNumber);
	int factorialNumber = ints.Aggregate( (f, s) => f * s);
	
	//int factorialNumber = GetFactorial(inputNumber);  // imperative approach
	
	Console.WriteLine(
		"{0}! is {1}",
		inputNumber,
		factorialNumber);
}

	private static int GetFactorial(int intNumber)
	{
		if (intNumber == 0)
			return 1;
			
		return intNumber * GetFactorial(intNumber - 1);
	}


