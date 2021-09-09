<Query Kind="Statements" />

Expression<Func<int, int, int>> addExpr = (x,y) => x + y;
Func<int,int,int> addCompiled = addExpr.Compile();
int result2 = addCompiled(10,20);
Console.WriteLine(result2);
Func<int, int> factorial = x =>
{
	int result = 1;
	for (int m = 2; m <= x; m++)
		result *= m;
	return result;
};
Console.WriteLine( factorial(4) );
