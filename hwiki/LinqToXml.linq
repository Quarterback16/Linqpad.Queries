<Query Kind="Program" />

void Main()
{
	var season = "2020";
	var playerId = "SHEPST01";
	var name = "Sterling Sheppard";
	
	Console.WriteLine($"# {name}");
	Console.WriteLine();
		
	XDocument doc = XDocument.Load("d:\\Dropbox\\GridStat\\xml\\YahooOutput.xml");

	while (!string.IsNullOrEmpty(season))
	{
		var results = GetStatsForPlayer(
			doc,
			season,
			playerId);

		if (!results.Any())
		{
			season = "";
			continue;
		}

	//	results.Dump();

		Console.WriteLine(
			AsObsidianChart(
				results,
				new Player
				{
					Id = playerId,
					Name = name,
					Stats = results
				},
				season));
				
		var nSeason = int.Parse(season)-1;
		season = nSeason.ToString();
	};
	Console.WriteLine();
	Console.WriteLine("[[LinqToXml.linq]]");
}

string AsObsidianChart(
	List<XmlStat> results,
	Player player,
	string season)
{
	var sb = new StringBuilder();

	sb.AppendLine($"## {season} ({player.TotalPts()})");
	sb.AppendLine($"- avg {player.Avg():#0.0}");
	sb.AppendLine($"- dnp {player.Dnp()}");

	sb.AppendLine("");
	sb.AppendLine("```chart");
	sb.AppendLine("type: bar");
	sb.AppendLine("labels: [W01,W02,W03,W04,W05,W06,W07,W08,W09,W10,W11,W12,W13,W14,W15,W16,W17]");
	sb.AppendLine("series:");
	sb.AppendLine($"  - title: {player.Name}");
	sb.AppendLine($"  - data: [{AsCsv(results)}]");
	sb.AppendLine("width: 80%");
	sb.AppendLine("labelColors: true");
	sb.AppendLine("fill: false");	
	sb.AppendLine("beginAtZero: true");
	sb.AppendLine("```");
	sb.AppendLine("");
	return sb.ToString();
}

string AsCsv(List<XmlStat> stats)
{
	var fp = new decimal[17];
	for (int i = 0; i < 17; i++)
		fp[i] = 0.0M;
	foreach (var stat in stats)
	{
		var index = int.Parse(stat.Week) - 1;
		if (index > 16)
			continue;
		fp[index] = stat.Qty;
	}
	var sb = new StringBuilder();
	for (int i = 0; i < 17; i++)
	{
		sb.Append(fp[i].ToString());
		if (i == 16)
			break;
		sb.Append(",");
	}
	return sb.ToString();	
}

List<XmlStat> GetStatsForPlayer(
	XDocument doc,
	string season,
	string playerId)
{
	var xquery = doc.Descendants("stat")
		.Where(
			n => n.Attribute("season").Value == season
			&& n.Attribute("id").Value == playerId)
		.Select(no => new XmlStat
		{
			Season = no.Attribute("season").Value,
			Week = no.Attribute("week").Value,
			Id = no.Attribute("id").Value,
			Qty = GetQty(no)
		})
		.ToList();
		
	return xquery.OrderBy(x => x.Week).ToList();
}

List<XmlStat> GetStatsForWeek(
	XDocument doc,
	string season,
	string week)
{
	var xquery = doc.Descendants("stat")
		.Where(
			n => n.Attribute("season").Value == season
			&& n.Attribute("week").Value == week)
		.Select(no => new XmlStat
		{
			Season = no.Attribute("season").Value,
			Week = no.Attribute("week").Value,
			Id = no.Attribute("id").Value,
			Qty = GetQty(no)
		})
		.ToList();

	return xquery.OrderByDescending(x => x.Qty).ToList();
}

decimal GetQty(XElement no)
{
	var amt = 0.0M;
	bool success = Decimal.TryParse(no.Attribute("qty").Value, out amt);
	return amt;
}

// You can define other methods, fields, classes and namespaces here
public class XmlStat
{
	public string Season { get; set; }
	public string Week { get; set; }	
	public string Id { get; set; }
	public decimal Qty { get; set; }
}

public class Player
{
	public string Id { get; set; }
	public string Name { get; set; }
	public List<XmlStat> Stats {get; set;}

	public decimal Avg()
	{
		return Stats.Average(s => s.Qty);
	}
	
	public int TotalPts()
	{
		return (int)Math.Round(Stats.Sum(s => s.Qty));
	}
	
	public int Dnp()
	{
		return 17 - Stats.Count;
	}
}