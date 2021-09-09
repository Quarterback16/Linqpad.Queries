<Query Kind="Program" />

void Main()
{
	GetIntFromHexStringFunctional();
}

private static void GetIntFromHexStringFunctional()
{
	string[] hexStrings = {
		"FF", "12CE", "F0A0", "3BD",
		"D43", "35", "0", "652F",
		"8DCC", "4125"};

	for (int i = 0; i < hexStrings.Length; i++)
	{
		Console.WriteLine(
			"0x{0}\t= {1}",
			hexStrings[i],
			HexStringToIntFunctional(hexStrings[i]));
	}
}

public static int HexStringToInt(
	string s)
{
	int iCnt = 0;
	int retVal = 0;
	for (int i = s.Length - 1; i >= 0; i--)
	{
		//  Power of 16
		retVal += HexCharToByteFunctional(s[i]) * (int)Math.Pow(0x10, iCnt++);
	}
	return retVal;
}

public static int HexStringToIntFunctional(
   string s)
{
	return s.ToCharArray()
		.ToList()
		.Select((c, i) => new { c, i })
		.Sum( (v) => HexCharToByteFunctional(v.c) * (int) Math.Pow(0x10, v.i));
}



public static byte HexCharToByteFunctional(
	char c)
{
	//  C# 7.0
	return c.Match()
		.With(ch => ch == '1', (byte)1)
		.With(ch => ch == '2', 2)
		.With(ch => ch == '3', 3)
		.With(ch => ch == '4', 4)
		.With(ch => ch == '5', 5)
		.With(ch => ch == '6', 6)
		.With(ch => ch == '7', 7)
		.With(ch => ch == '8', 8)
		.With(ch => ch == '9', 9)
		.With(ch => ch == 'A', 10)
		.With(ch => ch == 'a', 10)
		.With(ch => ch == 'B', 11)
		.With(ch => ch == 'b', 11)
		.With(ch => ch == 'C', 12)
		.With(ch => ch == 'c', 12)
		.With(ch => ch == 'D', 13)
		.With(ch => ch == 'd', 13)
		.With(ch => ch == 'E', 14)
		.With(ch => ch == 'e', 14)
		.With(ch => ch == 'F', 15)
		.With(ch => ch == 'f', 15)
		.Else(0)
		.Do();		
}

