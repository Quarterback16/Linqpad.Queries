<Query Kind="Program" />

void Main()
{
	Prog.GenericDelegateInvoke();
}

public static class Prog
{
	private delegate T FormulaDelegate<T>( T a, T b);
	
	private static int AddInt(int x, int y)
	{
		return x + y;
	}
	private static double AddDouble(double x, double y)
	{
		return x + y;
	}
	public static void GenericDelegateInvoke()
	{
		//  same delegate but different types
		FormulaDelegate<int> intAddition = AddInt;
		FormulaDelegate<double> doubleAddition = AddDouble;
		Console.WriteLine("Invoking intAddition(2,3)");
		Console.WriteLine(
			"result = {0}",
			intAddition(2, 3));
		Console.WriteLine("Invoking doubleAddition(2.2, 3.5)");
		Console.WriteLine(
			"result = {0}",
			doubleAddition(2.2, 3.5));
	}
}
