<Query Kind="Program" />

void Main()
{
	Prog.VoidDelegateInvoke();
}

public static class Prog
{
	private delegate void AdditionDelegate<T1, T2>(T1 value1, T2 value2);

	private static void AddIntDouble(int x, double y)
	{
		Console.WriteLine(
			"int {0} + double {1} = {2}",
			x,
			y,
			x + y);
	}
	private static void AddFloatDouble(float x, double y)
	{
		Console.WriteLine(
			"float {0} + double {1} = {2}",
			x,
			y,
			x + y);
	}
	public static void VoidDelegateInvoke()
	{
		AdditionDelegate<int, double> intDoubleAdd = AddIntDouble;
		AdditionDelegate<float,double> floatDoubleAdd = AddFloatDouble;
		Console.WriteLine("Invoking intDoubleAdd delegate");
		intDoubleAdd(1, 2.5);
		Console.WriteLine("Invoking floatDoubleAdd delegate");
		floatDoubleAdd((float)1.2, 4.3);
	}
}
