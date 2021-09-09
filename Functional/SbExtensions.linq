<Query Kind="Program" />

void Main()
{
	//byte[] buffer;
	//using (var stream = GeneratePlanetsStream())
	//{
	//	buffer = new byte[stream.Length];
	//	stream.Read(buffer, 0, (int)stream.Length);
	//}
	Disposable.Using( 
		GeneratePlanetsStream,
		stream => new byte[stream.Length]
		.Tee( b => stream.Read(b, 0, (int) stream.Length)))
		.Map(Encoding.UTF8.GetString)
		.Split(
			new[] { Environment.NewLine }, 
			StringSplitOptions.RemoveEmptyEntries)
		.Select( (s, ix) => Tuple.Create(ix, s))
		.ToDictionary( k => k.Item1, v => v.Item2)  //options
		.Map( options => GenerateOrderedList ( options, "thePlanets", true))  // string
		.Tee(Console.WriteLine);
		
	//var options = Encoding.UTF8
	//	.GetString(buffer2)
	//	.Split(new[] { Environment.NewLine, },
	//	StringSplitOptions.RemoveEmptyEntries)
	//	.Select((s, ix) => Tuple.Create(ix, s))
	//	.ToDictionary(k => k.Item1, v => v.Item2);
	//	
	//var orderedList = GenerateOrderedList(
	//	options, 
	//	"thePlanets", 
	//	true);
		
	//Console.WriteLine(orderedList);
	
}

//  We now have a function that has bodies as lambda-like expressions instead of statement blocks.
public static string GenerateOrderedList(
	IDictionary<int, string> options,
	string id,
	bool includeSun) =>
	 new StringBuilder()
		.AppendFormattedLine("<ol id='{0}'>", id)
		.AppendWhen(
			() => includeSun, 
			sb => sb.AppendLine("\t<li>The Sun/li>"))
		.AppendSequence(
			options,
			(sb, opt) => sb.AppendFormattedLine(
				"\t<li value='{0}'>{1}</li>",
				opt.Key,
				opt.Value))
		.AppendLine("</ol>")
		.ToString();


public static Stream GeneratePlanetsStream()
{
	var planets = String.Join(
		Environment.NewLine,
		new[] 
		{
			"Mercury", 
			"Venus", 
			"Earth",
			"Mars", 
			"Jupiter", 
			"Saturn",
			"Uranus", 
			"Neptune"
		});
	var buffer = Encoding.UTF8.GetBytes(planets);
	var stream = new MemoryStream();
	stream.Write(buffer, 0, buffer.Length);
	stream.Position = 0L;
	return stream;
}

public static class Disposable
{
	public static TResult Using<TDisposable, TResult>(
		Func<TDisposable> factory,
		Func<TDisposable, TResult> fn)
		
		where TDisposable : IDisposable
		{
			using (var disposable = factory())
			{
				return fn(disposable);
			}
		}
}
