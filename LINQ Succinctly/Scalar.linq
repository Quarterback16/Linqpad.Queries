<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] fibonacci = { 0, 1, 1, 2, 3, 5 };
	
	// Scalar returns a single value
	int numberOfElements = fibonacci.Count();
	
	Console.WriteLine("Count: {0}", numberOfElements);
	
	IEnumerable<int> distinctNumbers = fibonacci.Distinct();
	
	Console.WriteLine("Elements in the output sequence");
	foreach (var number in distinctNumbers)
	{
		Console.WriteLine(number);
	}
}

// You can define other methods, fields, classes and namespaces here
