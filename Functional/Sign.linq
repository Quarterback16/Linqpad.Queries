<Query Kind="Program" />

void Main()
{
	Console.WriteLine(
	"Sign of -15 is {0}",
	GetSignF(-15));
}

public static string GetSignF(
	int val)
{
	return val > 0 ? "positive" : "negative";		
}

public static string GetSign(
	int val)
{
	string posOrNeg;
	if (val>0)
		posOrNeg = "positive";
	else
		posOrNeg = "negative";
		
	return posOrNeg;
}
