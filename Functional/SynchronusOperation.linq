<Query Kind="Program" />

void Main()
{
	SynchronusProcess();
}

public static void SynchronusProcess()
{
	Stopwatch sw = Stopwatch.StartNew();
	Console.WriteLine(
		"Start synchonous process now ...");
	int iResult = RunSynchronousProcess();
	Console.WriteLine(
		"The Result = {0}",
		iResult);
	Console.WriteLine(
		"Total Time = {0} second(s)!",
		sw.ElapsedMilliseconds/1000);
}

public static int RunSynchronousProcess()
{
	int iReturn = 0;
	iReturn += LongProcess1();
	iReturn += LongProcess2();
	return iReturn;
}

public static int LongProcess1()
{
	Thread.Sleep(5000);
	return 5;
}

public static int LongProcess2()
{
	Thread.Sleep(7000);
	return 7;
}
