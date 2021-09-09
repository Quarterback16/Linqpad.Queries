<Query Kind="Program" />

void Main()
{
	Prog.ActionDelegateInvoke();
}

public static class Prog
{
	//private delegate void AdditionDelegate<T1, T2>(T1 value1, T2 value2);
    // built in delegate for action
	//  void Action<T1, T2, T3 ... T16>(T1 val1, T2 val2  ...)
	
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
	public static void ActionDelegateInvoke()
	{
		Action<int, double> intDoubleAdd = AddIntDouble;
		Action<float, double> floatDoubleAdd = AddFloatDouble;
		Console.WriteLine("Invoking intDoubleAddAction delegate");
		intDoubleAdd(1, 2.5);
		Console.WriteLine("Invoking floatDoubleAddAction delegate");
		floatDoubleAdd((float)1.2, 4.3);
	}
}
