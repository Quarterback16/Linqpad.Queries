<Query Kind="Program" />

void Main()
{
	SelectManyOperator();
}

public static void SelectManyOperator()
{
	List<string> numberTypes = new List<string>
	{
		"Multiplied by 2",
		"Multiplied by 3"
	};
	List<int> numbers = new List<int>
	{
		6,
		12,
		18,
		24
	};
	IEnumerable<NumberType> query =
		numbers.SelectMany(
			num => numberTypes,
			(n , t) => new NumberType
			{
				TheNumber = n,
				TheType = t
			});
	foreach (var nt in query)
	{
		Console.WriteLine(
			String.Format(
				"Number: {0,2} - Types: {1}",
				nt.TheNumber,
				nt.TheType));
	}
	
}

public class NumberType
{
	public int TheNumber { get; set; }
	public string TheType { get; set; }
}