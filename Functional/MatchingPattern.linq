<Query Kind="Program" />

void Main()
{
	TransformIntIntoText();
}

public static string NumberFactorType(
	int intSelectedNumber)
{
	if (intSelectedNumber < 2)
		return "neither prime nor composite number";
	else if (intSelectedNumber.IsPrime())
		return "prime number";
	else
		return "composite number";
}

public static void TransformIntIntoText()
{
	for (int i = 0; i < 10; i++)
	{
		Console.WriteLine(
			"{0} is {1}",
			i,
			NumberFactorType(i));
	}
}
