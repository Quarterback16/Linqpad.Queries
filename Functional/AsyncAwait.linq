<Query Kind="Program" />

void Main()
{
	AsyncAwaitReadFile();
}

static bool IsFinish;

public static void AsyncAwaitReadFile()
{
	IsFinish = false;
	ReadFileAsync();
	int i = 0;
	do
	{
		Console.WriteLine(
			"Timer Counter: {0}",
			++i);
	}
	while (!IsFinish);
	Console.WriteLine(
		"End of AsyncAwaitReadFile() method");
}

public static async void ReadFileAsync()
{
	FileStream fs = File.OpenRead(
		@"D:\temp\decks\Highlander Warrior.txt");
	byte[] buffer = new byte[fs.Length];
	
	int totalBytes = await fs.ReadAsync(
		buffer,
		0,
		(int) fs.Length);
		
	Console.WriteLine(
		"Read {0} bytes",
		totalBytes);
	IsFinish = true;
	fs.Dispose();
}