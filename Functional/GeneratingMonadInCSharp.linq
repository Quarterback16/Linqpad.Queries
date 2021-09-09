<Query Kind="Program" />

void Main()
{
	Console.WriteLine(
		MultipliedByTwo(4));
	RunMultipliedByTwo();
}

private static void RunMultipliedByTwo()
{
	Console.WriteLine(
		"RunMultipliedByTwo() implementing " +
		"higher-order programming");
		
	for (int i = 1; i <= 5; i++)
	{
		Console.WriteLine(
			"{0} multiplied by to is equal to {1}",
			i, 
			MultipliedByTwo(i));
	}
}

private static Nullable<int> MultipliedByTwoFunction(
	Nullable<int> iNullable,
	Func<int, int> funcDelegate)
{
	if (iNullable.HasValue)
	{
		int unWrappedInt = iNullable.Value;
		int multipliedByTwo = funcDelegate(unWrappedInt);
		return new Nullable<int>(
			multipliedByTwo);
	}
	else
	{
		return new Nullable<int>();
	}
}

private static Nullable<int> MultipliedByTwo(
	Nullable<int> iNullable)
{
	return MultipliedByTwoFunction(
		iNullable,
		(int x) => x * 2);
}