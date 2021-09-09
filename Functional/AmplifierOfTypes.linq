<Query Kind="Program" />

void Main()
{
	PrintStringNumber("Three");
	PrintIntContainingNull();
}

private static void PrintIntContainingNull()
{
	PrintStringNumber("three");
	PrintStringNumber("five");
	PrintStringNumber(null);
	PrintStringNumber("zero");
	PrintStringNumber("four");
}

private static Nullable<int> WordToNumber(string word)
{
	Nullable<int> returnValue;
	if (word == null)
	{
		return null;
	}
	switch (word.ToLower())
	{
		case "zero":
			returnValue = 0;
			break;
		case "one":
			returnValue = 1;
			break;
		case "two":
			returnValue = 2;
			break;
		case "three":
			returnValue = 3;
			break;
		case "four":
			returnValue = 4;
			break;
		case "five":
			returnValue = 5;
			break;
		default:
			returnValue = null;
			break;
	}
	return returnValue;
}

private static void PrintStringNumber(
	string stringNumber)
{
	if (stringNumber == null &&
		WordToNumber(stringNumber) == null)
	{
		Console.WriteLine(
			"Word: null is Int: null");
	}
	else
	{
		Console.WriteLine(
			"Word: {0} is Int: {1}",
			stringNumber.ToString(),
			WordToNumber(stringNumber));
	}
}