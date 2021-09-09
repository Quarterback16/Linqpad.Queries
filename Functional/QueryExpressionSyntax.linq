<Query Kind="Program" />

void Main()
{
	InvokingQueryExpressions();
}

private static void InvokingQueryExpressions()
{
	IEnumerable<string> query =
		from n in names
		where n.Length > 4
		orderby n[0]
		select n.ToUpper();
	foreach (string s in query)
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