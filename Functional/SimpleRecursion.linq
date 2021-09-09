<Query Kind="Program" />

void Main()
{
	 GetFactorialOfFive();
}

private static void GetFactorialOfFive()
{
	int i = GetFactorial(5);
	Console.WriteLine("5! is {0}", i);
}


private static int GetFactorial(
	int intNumber)
{
	if (intNumber == 0)
	   return 1;  // base case defines the eend of the recursion chain
	return intNumber * GetFactorial(intNumber-1);
}
