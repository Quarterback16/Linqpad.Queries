<Query Kind="Program" />

void Main()
{
	Func<int> MultipliedFunc;
	//RunMultipliedByTwo();
	RunMultipliedByTwoFunc();
}

private static void RunMultipliedByTwoFunc()
{
	Func<int> intFunc = MultipliedByTwo(
		() => 1 + 1);
}

private static Func<int> MultipliedByTwoFunction(
	Func<int> funcDelegate)
{
	return () =>
	{
		int unWrappedFunc =	funcDelegate();
		int multipliedByTwo = unWrappedFunc * 2;
		return multipliedByTwo;
	};
}

private static void RunMultipliedByTwo()
{
	for (int i = 1; i <= 5; i++)
	{
		Console.WriteLine(
			"{0} multiplied by two is equal to {1}",
			i, 
			MultipliedByTwo(i));
	}
}

private static Func<int> MultipliedByTwo(
	Func<int> funcDelegate)
{
	int unWrappedFunc =	funcDelegate();
	int multipliedByTwo = unWrappedFunc * 2;
	return GetFuncFromInt(
		multipliedByTwo);
}

private static Func<int> GetFuncFromInt(
	int iItem)
{
	return () => iItem;
}

private static Nullable<int> MultipliedByTwo(
	Nullable<int> nullableInt)
{
	if (nullableInt.HasValue)
	{
		int unWrappedInt = nullableInt.Value;
		int multipliedByTwo = unWrappedInt * 2;
		return GetNullableFromInt(
			multipliedByTwo);
	}
	else
	{
		return new Nullable<int>();
	}
}

private static Nullable<int> GetNullableFromInt(
	int iNumber)
{
	return new Nullable<int>(
		iNumber);
}