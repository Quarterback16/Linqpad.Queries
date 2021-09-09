<Query Kind="Program" />

void Main()
{
	var week = 3;
	Console.WriteLine($"# NFL 2021 Preseason Week {week} Notes");
	Console.WriteLine($"## Week {week}");
	SpitGame(new DateTime(2021, 08, 28, 9,  0, 0), "IC", "DL");
	SpitGame(new DateTime(2021, 08, 28, 9, 30, 0), "PS", "CP");
	SpitGame(new DateTime(2021, 08, 28, 9, 30, 0), "PE", "NJ");
	SpitGame(new DateTime(2021, 08, 28, 10, 0, 0), "MV", "KC");
	SpitGame(new DateTime(2021, 08, 29, 3,  0, 0), "GB", "BB");
	SpitGame(new DateTime(2021, 08, 29, 8,  0, 0), "BR", "WR");
	SpitGame(new DateTime(2021, 08, 29, 9,  0, 0), "CH", "TT");
	SpitGame(new DateTime(2021, 08, 29, 10, 0, 0), "AC", "NO");
	SpitGame(new DateTime(2021, 08, 29, 10, 0, 0), "TB", "HT");
	SpitGame(new DateTime(2021, 08, 29, 11, 5, 0), "LR", "DB");
	SpitGame(new DateTime(2021, 08, 29, 12, 0, 0), "LC", "SS");
	SpitGame(new DateTime(2021, 08, 30, 3,  0, 0), "JJ", "DC");
	SpitGame(new DateTime(2021, 08, 30, 6,  0, 0), "MD", "CI");
	SpitGame(new DateTime(2021, 08, 30, 6,  0, 0), "LV", "SF");
	SpitGame(new DateTime(2021, 08, 30, 8,  0, 0), "NE", "NG");
	SpitGame(new DateTime(2021, 08, 30, 10, 0, 0), "CL", "AF");

	Console.WriteLine();
	Console.WriteLine("[[preseason-notes.linq]]");
}

void SpitGame(DateTime gameDate, string awayTeam, string homeTeam)
{
	Console.WriteLine($"### {gameDate.ToString("yyyy-MM-dd HH:mm")} : [[{awayTeam}]] @ [[{homeTeam}]]");
	Console.WriteLine();
	Console.Write($"\t- ({awayTeam })  ");
	Console.WriteLine("Q:  R:  W:  T:  K:");
	Console.Write($"\t- ({homeTeam })  ");
	Console.WriteLine("Q:  R:  W:  T:  K:");
	Console.WriteLine();
	var sb = new StringBuilder();
	sb.Append( "|" + Cell("TM") );
	for (int c = 1; c < 7; c++)
	{
		sb.Append(Cell($"  {c}  ") );
	}
	sb.AppendLine("    H   |");

	sb.Append("|" + Cell("---"));
	for (int c = 1; c < 7; c++)
	{
		sb.Append(Cell("-----"));
	}
	sb.AppendLine(" ------ |");
	
	sb.Append("|" + Cell(awayTeam));
	for (int c = 1; c < 7; c++)
	{
		sb.Append(Cell("     "));
	}
	sb.AppendLine("        |");

	sb.Append("|" + Cell(homeTeam));
	for (int c = 1; c < 7; c++)
	{
		sb.Append(Cell("     "));
	}
	sb.AppendLine("        |");

	Console.WriteLine(sb.ToString());
	Console.WriteLine("\t*");
	Console.WriteLine();
}

string Cell(string text)
{
	if (text.Length == 2)
		return $" {text}  |";
	return $" {text} |";
}

// You can define other methods, fields, classes and namespaces here
