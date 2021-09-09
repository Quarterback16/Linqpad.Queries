<Query Kind="Program" />

void Main()
{
	//UsingExtensionMethod();
	UsingStaticMethod();
}

private static void UsingExtensionMethod()
{
	IEnumerable<string> query = names
	   .Where( nameof => nameof.Length > 4 )
	   .OrderBy( n => n[0] )
	   .Select( n => n.ToUpper() );
	   
	foreach (var s in query)
	{
		Console.WriteLine(s);
	}
}

private static void UsingStaticMethod()
{
	IEnumerable<string> query =
	  Enumerable.Select(
	  	Enumerable.OrderBy(
		   Enumerable.Where(
		      names,
			  n => n.Length > 4),
			  n => n[0]),
		   n => n.ToUpper());
		   
	foreach (var s in query)
	{
		Console.WriteLine(s);
	}
			  
			  
			  
}

static List<string> names = new List<string>
{
	"Howard", "Pat",
	"Jaclyn", "Kathryn",
	"Ben", "Aaron",
	"Stacey", "Levi",
	"Patrick", "Tara",
	"Joe", "Ruby",
	"Bruce", "Cathy",
	"Jimmy", "Kim",
	"Kelsey", "Becky",
	"Scott", "Dick"
};