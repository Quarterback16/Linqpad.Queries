<Query Kind="Program" />

void Main()
{
	FirstClassConcept();
	FirstClassConcept2(
		displayMessageDelegate,
		"Pass lambda expression to argument");
}

static Func<string, string> displayMessageDelegate = str => String.Format("Message: {0}", str);

static private void FirstClassConcept()
{
	string str = displayMessageDelegate(
		"Assign displayMessageDelegate() to variable");
	Console.WriteLine(str);
}

static private void FirstClassConcept2(
	Func<string, string> funct,
	string message)
{
	Console.WriteLine(funct(message));
}
