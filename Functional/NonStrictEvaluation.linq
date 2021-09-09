<Query Kind="Program" />

void Main()
{
	int x = 4;
	int y = 3;
	int z = 2;
	Console.WriteLine("Strict Evaluation");
	Console.WriteLine(
	String.Format(
		"Calculate {0} + ({1} * {2})", x, y, z));
	int result = OuterFormula(x, InnerFormula(y, z));
	Console.WriteLine(
	String.Format(
		"{0} + ({1} * {2}) = {3}", 
		x, y, z, result));
	Console.WriteLine();
}

private static int OuterFormula(int x, int yz)
{
	Console.WriteLine(
		String.Format(
			"Calculate {0} + InnerFormula({1})",
			x,
			yz));
	return x * yz;
}

private static int InnerFormula(int y, int z)
{
	Console.WriteLine(
		String.Format(
			"Calculate {0} * {1}",
			y,
			z));
	return y * z;
}