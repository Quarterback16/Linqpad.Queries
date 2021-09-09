<Query Kind="Program" />

void Main()
{
	//Console.WriteLine(GetData());
	SwitchCaseInCSharp7();
}

private static void IsOperatorBeforeCSharp7()
{
	object o = GetData();
	if (o is String)
	{
		var s = (String)o;
		Console.WriteLine(
			"The object is String. Value = {0}",
			s);
	}
}

private static void IsOperatorInCSharp7()
{
	object o = GetData();
	if (o is String s)
	{
		Console.WriteLine(
			"The object is String. Value = {0}",
			s);
	}
}

private static object GetData(
   bool objectType = true)
{
	if (objectType)
		return "One";
	else
		return 1;
}

private static void SwitchCaseInCSharp7()
{
	object x = GetData(
		false);
	switch (x)
	{
		case string s:
			Console.WriteLine(
				"{0} is a string of length {1}",
				x,
				s.Length);
			break;
		case int i:
			Console.WriteLine(
				"{0} is an {1} int",
				x,
				(i % 2 == 0 ? "even" : "odd"));
			break;
		default:
			Console.WriteLine(
				"{0} is something else",
				x);
			break;
	}
}