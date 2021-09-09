<Query Kind="Program">
  <Output>DataGrids</Output>
  <Reference>E:\FileSync\SyncProjects\GerardGui\GerardGui\bin\x86\Release\RosterLib.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Configuration.dll</Reference>
  <Reference>E:\FileSync\SyncProjects\GerardGui\GerardGui\bin\x86\Release\TFLLib.dll</Reference>
  <Namespace>RosterLib</Namespace>
  <Namespace>RosterLib.Models</Namespace>
  <Namespace>RosterLib.Services</Namespace>
</Query>

void Main()
{
	//  Requires LinqPad 5
	var sb = new StringBuilder();
	
	var season = "2021";
	var playerId = "CLAYCH02";
	var name = "Chase Claypool";

	sb.AppendLine($"# {name}");
	sb.AppendLine();
	sb.AppendLine($"## Projection {season}");
	sb.AppendLine();
	
	var projection = GetProjectionForPlayer(
		season,
		playerId);
	
	//projection.GameMetrics.Dump();
	
	ProjectionsToMarkDown(
		projection,
		sb);
	Console.WriteLine(
		sb.ToString());

	Console.WriteLine(
		AsObsidianChart(
			projection,
			name,
			season));
}

string AsObsidianChart(
	Projection projection,
	string player,
	string season)
{
	var sb = new StringBuilder();

	sb.AppendLine($"- Points ({projection.TotalPoints})");
	sb.AppendLine($"- avg {AvgFpPerGame(projection):#0.0}");

	sb.AppendLine("");
	sb.AppendLine("```chart");
	sb.AppendLine("type: bar");
	sb.AppendLine("labels: [W01,W02,W03,W04,W05,W06,W07,W08,W09,W10,W11,W12,W13,W14,W15,W16,W17,W18]");
	sb.AppendLine("series:");
	sb.AppendLine($"\t- title: {player.Trim()}");
	sb.AppendLine($"\t- data: [{AsCsv(projection)}]");
	sb.AppendLine("width: 80%");
	sb.AppendLine("labelColors: true");
	sb.AppendLine("fill: false");
	sb.AppendLine("beginAtZero: true");
	sb.AppendLine("```");
	sb.AppendLine("");
	return sb.ToString();
}

decimal AvgFpPerGame(
	Projection projection)
{
	return projection.TotalPoints / projection.GameMetrics.Count;
}

void ProjectionsToMarkDown(
	Projection projection,
	StringBuilder sb)
{
	sb.AppendLine("| *Game* |  *FP*  |");
	sb.AppendLine("| --- | --- |");
	foreach (var game in projection.GameMetrics)
	{
		var g = new NFLGame(game.GameKey);
		sb.Append($"|  {g.GameName()}  ");  // gameout this
		sb.Append($"|  {game.ProjectedFantasyPoints,5}  "); 
		sb.AppendLine("|");
	}
}

string AsCsv(Projection stats)
{
	var fp = new decimal[18];
	for (int i = 0; i < 18; i++)
		fp[i] = 0.0M;
	foreach (var stat in stats.GameMetrics)
	{
		var index = int.Parse(stat.GameKey.Substring(5,2)) - 1;
		if (index > 17)
			continue;
		fp[index] = (int) stat.ProjectedFantasyPoints;
	}
	var sb = new StringBuilder();
	for (int i = 0; i < 18; i++)
	{
		sb.Append(fp[i].ToString());
		if (i == 16)
			break;
		sb.Append(",");
	}
	return sb.ToString();
}

Projection GetProjectionForPlayer(
	string season,
	string playerId)
{
	var ps = new ProjectionService(
		new DbfPlayerGameMetricsDao());
	var projection = ps.GetProjectionFor(
				playerId,
				season);
	return projection; 
}