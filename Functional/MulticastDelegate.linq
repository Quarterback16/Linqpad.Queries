<Query Kind="Program" />

void Main()
{
	Program.CombineDelegate();
}


public class Program
{
	private delegate void CalculatorDelegate(int a, int b);
	
	private static void Add(int x, int y)
	{
		Console.WriteLine(
			"{0} + {1} = {2}",
			x,
			y,
			x + y);
	}

	private static void Subtract(int x, int y)
	{
		Console.WriteLine(
			"{0} - {1} = {2}",
			x,
			y,
			x - y);
	}

	private static void Multiply(int x, int y)
	{
		Console.WriteLine(
			"{0} * {1} = {2}",
			x,
			y,
			x * y);
	}

	private static void Division(int x, int y)
	{
		Console.WriteLine(
			"{0} / {1} = {2}",
			x,
			y,
			x / y);
	}

	public static void CombineDelegate()
	{
		CalculatorDelegate calcMultiples =
			(CalculatorDelegate) Delegate.Combine(
				new CalculatorDelegate[] 
				{
					Add,
					Subtract,
					Multiply,
					Division
				});
		Delegate[] calcList = calcMultiples.GetInvocationList();
		Console.WriteLine(
			"Total delegates in calcMultiples: {0}",
			calcList.Length);
			calcMultiples(6, 3);
	}
}
