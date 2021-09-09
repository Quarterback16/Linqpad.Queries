<Query Kind="Program" />

void Main()
{
	 //ReadFile();
	 //ReadAsyncFile();
	 ReadAsyncFileAnonymousMethod();
}

public static void ReadAsyncFileAnonymousMethod()
{
	FileStream fs = File.OpenRead(
		@"D:\temp\decks\Ramp Paladin.txt");
	byte[] buffer = new byte[fs.Length];
	IAsyncResult result = fs.BeginRead(
		buffer,
		0,
		(int)fs.Length,
		asyncResult =>
		{
			int totalBytes = fs.EndRead(asyncResult);
			Console.WriteLine(
				"Read {0} bytes.",
				totalBytes);
		},
		null);
	int i = 0;
	do
	{
		Console.WriteLine(
			"Timer Counter: {0}",
			++i);
	}
	while (!result.IsCompleted);
	fs.Dispose();	
}

public static void ReadFile()
{
	FileStream fs = File.OpenRead(
		@"D:\temp\decks\Ramp Paladin.txt");
	byte[] buffer = new byte[fs.Length];
	int totalBytes = fs.Read(
		buffer,
		0,
		(int) fs.Length);
	Console.WriteLine(
		"Read {0} bytes.",
		totalBytes);
	fs.Dispose();	
}

public static void ReadAsyncFile()
{
	FileStream fs = File.OpenRead(
		@"D:\temp\decks\Ramp Paladin.txt");
	byte[] buffer = new byte[fs.Length];
	IAsyncResult result = fs.BeginRead(
		buffer,
		0,
		(int)fs.Length,
		OnReadComplete,
		fs);
		
	// do other work while file is read
	int i = 0;
	do 
	{
		Console.WriteLine(
			"Timer Counter: {0}",
			++i);
	}
	while (!result.IsCompleted);
	fs.Dispose();
}

private static void OnReadComplete(IAsyncResult result)
{
	FileStream fStream = (FileStream)result.AsyncState;
	int totalBytes = fStream.EndRead(result);
	Console.WriteLine(
		"Read {0} bytes.", 
		totalBytes); 
	fStream.Dispose();
}
