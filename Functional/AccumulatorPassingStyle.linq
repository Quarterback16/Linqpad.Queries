<Query Kind="Program" />

void Main()
{
	//GetFactorialOfFiveUsingAPS();
	GetFactorialOfFiveUsingAPS2();
}

private static void GetFactorialOfFiveUsingAPS2()
{
	Console.WriteLine("5! (using GetFactorialAPS2)");
	GetFactorialAPS2(5);
}

private static void GetFactorialOfFiveUsingAPS()
{
	int i = GetFactorialAPS(5);
	Console.WriteLine(
		"5! (using GetFactorialAPS) is {0}", i);
}

public static int GetFactorialAPS(
	int intNumber,
	int accumulator = 1)
{
	if (intNumber == 0)
		return accumulator;
		
	return GetFactorialAPS(
		intNumber-1,
		intNumber * accumulator );  // parameter is accumating the result!
}

public static void GetFactorialAPS2(
	int intNumber,
	int accumulator = 1)
{
	if (intNumber == 0)
	{
		Console.WriteLine(
			"The result is " + accumulator);
		return;
	}

	GetFactorialAPS2(
		intNumber - 1,
		intNumber * accumulator);  // parameter is accumating the result!
}
