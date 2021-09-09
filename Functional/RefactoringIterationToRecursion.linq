<Query Kind="Program" />

void Main()
{
	int[] intDataArray =
		{8, 10, 24, -1, 98, 47, -101, 39 };
	int iMaxNumber = FindMaxRecursive(
		intDataArray);
	Console.WriteLine(
		"Max Number (using FindMaxRecursive) = " + iMaxNumber);
}

public static int FindMaxIteration(
	int[] intArray)
{
	int iMax = 0;
	for (int i = 0; i < intArray.Length; i++)
	{
		if (intArray[i] > iMax)
			iMax = intArray[i];
	}
	return iMax;
}

public static int FindMaxRecursive(
	int [] intArray,
	int iStartIndex = 0)
{
	if (iStartIndex == intArray.Length - 1)
		return intArray[iStartIndex];
	else
		return Math.Max(
			intArray[iStartIndex],
			FindMaxRecursive( 
				intArray,
				iStartIndex + 1));			
}
