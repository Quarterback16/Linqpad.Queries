<Query Kind="Program" />

void Main()
{
	//Prog.CovarianceStreamWriterInvoke();
	Prog.CovarianceStringWriterInvoke();
}

public static class Prog
{
	private delegate TextWriter CovarianceDelegate();

	private static StreamWriter StreamWriterMethod()
	{
		DirectoryInfo[] arrDir = new DirectoryInfo(
			@"C:\Windows\")
				.GetDirectories(
					"s*",
					SearchOption.TopDirectoryOnly);
		StreamWriter sw = new StreamWriter(
			Console.OpenStandardOutput());
			
		foreach (DirectoryInfo dir in arrDir)
		{	
			sw.WriteLine(dir.Name);
		}
		return sw;			
	}

	private static StringWriter StringWriterMethod()
	{
		StringWriter strWriter = new StringWriter();
		string[] arrString = new string[]
		{
			"Covariance",
			"example",
			"using",
			"StringWriter",
			"object"
		};
		foreach (string str in arrString)
		{
			strWriter.Write(str);
			strWriter.Write(' ');
		}
		return strWriter;
	}
	
	public static void CovarianceStreamWriterInvoke()
	{
		CovarianceDelegate covDelegate;
		Console.WriteLine(
			"Invoking CovarianceStreamWriterInvoke method:");
		covDelegate = StreamWriterMethod;
		StreamWriter sw = (StreamWriter) covDelegate();
		sw.AutoFlush = true;
		Console.SetOut(sw);
	}
	public static void CovarianceStringWriterInvoke()
	{
		CovarianceDelegate covDelegate;
		Console.WriteLine(
			"Invoking CovarianceStringWriterInvoke method:");
		covDelegate = StringWriterMethod;
		StringWriter sw = (StringWriter)covDelegate();
		Console.WriteLine(sw.ToString());
	}
}
