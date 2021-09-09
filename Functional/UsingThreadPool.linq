<Query Kind="Program" />

void Main()
{
	ThreadPoolProcess();
}

public static void ThreadPoolProcess()
{
	Stopwatch sw = Stopwatch.StartNew();
	Console.WriteLine(
		"Start Threadpool Process now...");
	int iResult = RunInThreadPool();
	Console.WriteLine(
		"The Result = {0}",
		iResult);
	Console.WriteLine(
		"Total Time = {0} seconds(s)!",
		sw.ElapsedMilliseconds / 1000);
}

public static int RunInThreadPool()
{
	int iResult1 = 0;
	ThreadPool.QueueUserWorkItem(
		(t) => iResult1 = LongProcess1());
	int iResult2 = LongProcess2();
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
