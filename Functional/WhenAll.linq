<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	ReadTwoFileTask();
}

public static void ReadTwoFileTask()
{
	bool isFinish = false;
	Task readFile1 = ReadFileAsync(
		@"D:\temp\decks\Highlander Warrior.txt");
	Task readFile2 = ReadFileAsync(
		@"D:\temp\decks\Ramp Paladin.txt");
	//  when they are bone done
	Task.WhenAll( readFile1, readFile2)
		.ContinueWith(
			task => 
			{
				isFinish = true;
				Console.WriteLine(
					"All files read successfully");
			});

	// do other work while file is read
	int i = 0;
	do
	{
		Console.WriteLine(
			"Timer Counter: {0}",
			++i);
	}
	while (!isFinish);
	Console.WriteLine(
		"End of ReadTwoFileTask() method");
}

public static Task<int> ReadFileAsync(string filePath)
{
	FileStream fs = File.OpenRead(filePath);
	byte[] readBuffer = new byte[fs.Length];
	Task<int> readTask =
		fs.ReadAsync(
		readBuffer,
		0,
		(int)fs.Length);
		readTask.ContinueWith(task =>
		{
			if (task.Status == TaskStatus.RanToCompletion)
				Console.WriteLine(
			"Read {0} bytes from file {1}",
			task.Result,
			filePath);
			fs.Dispose();
		});
	return readTask;
}