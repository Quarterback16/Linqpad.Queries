<Query Kind="Program" />

void Main()
{
	Tuple<string, int, int> geometry1 = new Tuple<string, int, int>(
		"Rectangle",
		2,
		3);
	Tuple<string, int, int> geometry2 = new Tuple<string, int, int>(
		"Square",
		2,
		2);
	Console.WriteLine(
		"{0} has size {1} x {2}",
		geometry1.Item1,
		geometry1.Item2,
		geometry1.Item3);
	Console.WriteLine(
		"{0} has size {1} x {2}",
		geometry2.Item1,
		geometry2.Item2,
		geometry2.Item3);
}

// You can define other methods, fields, classes and namespaces here
