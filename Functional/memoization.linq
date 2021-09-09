<Query Kind="Program" />

void Main()
{
	var x = GetFactorial(10);
	var y = GetFactorial(4); 
}

private static Dictionary<int,int> memoizeDict = new Dictionary<int,int>();

private static int GetFactorial(int intNumber)
{
	if (intNumber == 0)
		return 1;
		
	if (memoizeDict.ContainsKey(intNumber))
		return memoizeDict[intNumber];
		
	int i = intNumber * GetFactorial(intNumber -1);
	memoizeDict.Add(intNumber,i);
	return i;
}
