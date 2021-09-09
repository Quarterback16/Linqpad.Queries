<Query Kind="Program" />

void Main()
{
	//  this variable is actually an anonymous method
	Func<string, string> displayMessageDelegate = delegate (string str)
	{
		return String.Format("Message: {0}", str);
	};

	Console.WriteLine(
		displayMessageDelegate("sample"));
}

