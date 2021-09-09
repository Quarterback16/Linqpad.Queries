<Query Kind="Program" />

void Main()
{
	GetFactorialOfFiveUsingCPS();
}

private static void GetFactorialOfFiveUsingCPS()
{
	Console.Write("5! (using GetFactorialCPS) is ");
	GetFactorialCPS(5, x => Console.WriteLine(x));
}

public static void GetFactorialCPS(
	int intNumber,
	Action<int> actCont)
{
	if (intNumber == 0 )
		actCont(1);
	else
		GetFactorialCPS(
			intNumber - 1,
			x => actCont( intNumber * x ));
}
