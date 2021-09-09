<Query Kind="Program" />

void Main()
{
	int i = AreaRectangleDelegate(1,2);
	int j = AreaSquareDelegate(2,3);
	Console.WriteLine("i = " + i);
	Console.WriteLine("j = " + j);
}

	private static Func<int, int, int> AreaRectangleDelegate 
		= delegate (int a, int b)
		{
			return a * b;
		};
		
	private static Func<int, int, int> AreaSquareDelegate
		= delegate (int a, int b)
		{
			return a * b;
		};
