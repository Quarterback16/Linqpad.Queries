<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	int[] fibonacci = { 0, 1, 1, 2, 3, 5 };  //  in memory or local data source
	
	// Construct a Query
	IEnumerable<int> numbersGreaterThanTwoQuery = fibonacci.Where( x => x > 2);
	
	//  At this point query had been created but not executed
	
	// change the first element of the input sequence
	fibonacci[0] = 99;
	
	// cause the query to be executed (enumerated)
	
	foreach (var number in numbersGreaterThanTwoQuery)
	{
		Console.WriteLine(number);
	}
}

// You can define other methods, fields, classes and namespaces here
