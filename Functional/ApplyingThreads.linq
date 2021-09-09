<Query Kind="Program" />

void Main()
{
	AsynchronusProcess();
}

public static void AsynchronusProcess()
{
	Stopwatch sw = Stopwatch.StartNew();
	Console.WriteLine(
		"Start Asynchonous process now ...");
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
	int iResult1 = 0;
	Thread thread = new Thread(
		() => iResult1 = LongProcess1());
	thread.Start();
	int iResult2 = LongProcess2();
	thread.Join();
	return iResult1 + iResult2;
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
