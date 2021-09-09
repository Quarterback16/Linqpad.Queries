<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	 ReadFileTask();
}

public static void ReadFileTask()
{
	bool isFinish = false;
	
	FileStream fs = File.OpenRead(
		@"D:\temp\decks\Highlander Warrior.txt");
	byte[] readBuffer = new byte[fs.Length];
	
	//  method chain specifying Action<Task<T>> which is the ContinueWith()
	fs.ReadAsync(
		readBuffer,
		0,
		(int) fs.Length).ContinueWith(
			task => 
			{
				if (task.Status == TaskStatus.RanToCompletion)
				{
					isFinish = true;
					Console.WriteLine(
						"Read {0} bytes.",
						task.Result);
				}
				fs.Dispose();
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
		"End of ReadFileTask() method");
}
