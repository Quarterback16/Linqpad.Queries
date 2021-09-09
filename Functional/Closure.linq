<Query Kind="Program" />

void Main()
{
	Func<int, int> incrementFunc = GetFunction();
	for (int i = 0; i < 10; i++)
	{
		Console.WriteLine(
			"Invoking {0}: incrementFunc(1) = {1}",
			i,
			incrementFunc(1));
	}
}

private static Func<int, int> GetFunction()
{
	int localVar = 1;
	Func<int,int> returnFunc = scopevar =>
	{
		localVar *= 2;
		return scopevar + localVar;
	};
	return returnFunc;
}
