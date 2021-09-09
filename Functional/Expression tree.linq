<Query Kind="Program" />

void Main()
{
	//  this in an expression tree
	Expression<Func<int,int,int>> expression = (a,b) => a * b;
	ExploreBody(expression);
	CompilingExpr(expression);
}

// You can define other methods, fields, classes and namespaces here
private static Func<int, int, int> AreaRectangleDelegate = (a, b) => a * b;
private static Func<int, int, int> AreaSquareDelegate = (x, y) => x * y;

private static void ExploreBody(
   Expression<Func<int,int,int>> expr)
{
	BinaryExpression body = (BinaryExpression) expr.Body;
	ParameterExpression left = (ParameterExpression)body.Left;
	ParameterExpression right = (ParameterExpression)body.Right;
	Console.WriteLine(expr.Body);
	Console.WriteLine(
		"\tThe left part of the expression: {0}\n" +
		"\tThe NodeType: {1}\n" +
		"\tThe right part: {2}\n" +
		"\tThe Type: {3}\n",
		left.Name,
		body.NodeType,
		right.Name,
		body.Type);
}

private static void CompilingExpr(
   Expression<Func<int,int,int>> expr)
{
	int a = 2;
	int b = 3;
	int compResult = expr.Compile() (a,b);
	
	Console.WriteLine(
		"The result of expression {0}" + 
		" with a = {1} and b = {2} is {3}",
		expr.Body,
		a,
		b,
		compResult);	
}