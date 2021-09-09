<Query Kind="Program" />

void Main()
{
	Prog.ReturnValueDelegateInvoke();
}

public static class Prog
{
	private delegate TResult AddAndConvert<T1, T2, TResult>(
		T1 digit1, T2 digit2);

	private static float AddIntDoubleConvert(int x, double y)
	{
		float result = (float) (x+y);
		Console.WriteLine(
			"int {0} + double {1} = (float) {2}",
			x,
			y,
			result);
		return result;
	}
	private static int AddFloatDoubleConvert(float x, double y)
	{
		int result = (int) (x+y);
		Console.WriteLine(
			"float {0} + double {1} = (int) {2}",
			x,
			y,
			result);
		return result;
	}
	public static void ReturnValueDelegateInvoke()
	{
		AddAndConvert<int, double, float> 
			intDoubleAddConvertToFloat = AddIntDoubleConvert;
		AddAndConvert<float, double, int> 
			floatDoubleAddConvertToInt = AddFloatDoubleConvert;
		Console.WriteLine("Invoking intDoubleAddConvertToFloat delegate");
		float f = intDoubleAddConvertToFloat(5, 3.9);
		Console.WriteLine("Invoking floatDoubleAddConvertToInt delegate");
		int i = floatDoubleAddConvertToInt((float)4.3, 2.1);
	}
}
