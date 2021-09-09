<Query Kind="Program" />

void Main()
{
	GetIntFromHexString();
}

private static void GetIntFromHexString()
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
			HexStringToInt(hexStrings[i]));
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
		retVal += HexCharToByte(s[i]) *	(int)Math.Pow(0x10, iCnt++);
	}
	return retVal;
}

public static byte HexCharToByte(
	char c)
{
	byte res;
	switch (c)
	{
		case '1':
			res = 1;
			break;
		case '2':
			res = 2;
			break;
		case '3':
			res = 3;
			break;
		case '4':
			res = 4;
			break;
		case '5':
			res = 5;
			break;
		case '6':
			res = 6;
			break;
		case '7':
			res = 7;
			break;
		case '8':
			res = 8;
			break;
		case '9':
			res = 9;
			break;
		case 'A':
		case 'a':
			res = 10;
			break;
		case 'B':
		case 'b':
			res = 11;
			break;
		case 'C':
		case 'c':
			res = 12;
			break;
		case 'D':
		case 'd':
			res = 13;
			break;
		case 'E':
		case 'e':
			res = 14;
			break;
		case 'F':
		case 'f':
			res = 15;
			break;
		default:
			res = 0;
			break;
	}
	return res;  //  res is mutated during execution; so not functional
}
