<Query Kind="Program" />

void Main()
{
	var roster = LoadRoster();
	DisplayBatters(roster);
}

public Roster LoadRoster()
{
	var moves = new List<Move>();
	moves.Add(new Move(1, "C", "T d'Arnaud"));
	moves.Add(new Move(1, "1B", "C Bellinger"));
	moves.Add(new Move(1, "2B", "J Altuve"));
	moves.Add(new Move(1, "3B", "M Machado"));
	moves.Add(new Move(1, "SS", "J Baez"));
	moves.Add(new Move(1, "2B/SS", "M Muncy"));
	moves.Add(new Move(1, "1B/3B", "V Guerrero Jr"));
	moves.Add(new Move(1, "OF1", "A Judge"));
	moves.Add(new Move(1, "OF2", "J Gallo"));
	moves.Add(new Move(1, "OF3", "B Buxton"));
	moves.Add(new Move(1, "OF4", "M Brantley"));
	moves.Add(new Move(1, "OF5", "R Tapia"));
	moves.Add(new Move(1, "UTIL", "Y Alvarez"));
	moves.Add(new Move(2, "1B", "C Santana"));
	moves.Add(new Move(2, "OF5", "J Profar"));
	moves.Add(new Move(3, "2B", "L Arraez"));
	moves.Add(new Move(3, "UTIL", "F Reyes"));
	moves.Add(new Move(4, "OF2", "J Winker"));	
	var roster = new Roster(moves);
	return roster;
}

void DisplayBatters(Roster roster)
{
	var slots = new string[] { "C", "1B", "2B", "3B", "SS", "2B/SS", "1B/3B", "OF1", "OF2", "OF3", "OF4", "OF5", "UTIL" };
	var weeksInSeason = 4;
	DisplayHeader(weeksInSeason);
	foreach (var position in slots)
	{
		Console.Write($"||  {position,-7}  ||");
		for (int w = 1; w < weeksInSeason+1; w++)
		{
			Console.Write($" {PlayerType(roster.PlayerAt(position,w)),-15}  ||");
		}
		Console.Write($"   {Comment(position)}  ||");
		Console.WriteLine();
	}
}

private string PlayerType(string player)
{
	if (IsElite(player))
		player = $"(*) {player}";
	if (IsQuestionable(player))
		player = $"? {player}";
	return player;
}

bool IsQuestionable(string player)
{
	if (player == "C Bellinger")
		return true;
	if (player == "J Altuve")
		return true;
	if (player == "T d'Arnaud")
		return true;
	if (player == "J Baez")
		return true;
	if (player == "J Gallo")
		return true;
	return false;
}

bool IsElite(string player)
{
	if (player == "M Brantley")
		return true;
	if (player == "A Judge")
		return true;
	if (player == "M Machado")
		return true;
	return false;
}

private string Comment(
	string position)
{
	if (position == "SS")
		return "hot Joey Wendle?";

	if (position=="1B")
		return "Cody's spot if hes healthy";
	if (position == "2B")
		return "Altuve's spot if hes healthy";
	if (position == "3B")
		return "fixture";
	if (position == "OF1")
		return "fixture";
	if (position == "OF4")
		return "fixture";
	return "";
}

void DisplayHeader(
	int weeksInSeason)
{
	Console.Write("||  **POS**  ||");
	for (int w = 0; w < weeksInSeason; w++)
	{
		Console.Write($"  WK{w+1,-13:0#} ||");
	}
	Console.Write("	**Comments**  ||");
	Console.WriteLine();
}

public class Roster
{
	public List<Move> Moves { get; set; }	
	public Roster(
		List<Move> moves)
	{
		Moves = moves;
	}
	
	public string PlayerAt(
		string position,
		int week)
	{
		var player = "???";
		foreach (var move in Moves)
		{
			if (move.Week > week)
				break;
			if (move.Position == position)
				player = move.Player;
		}
		return player;
	}

}

public class Move
{
	public int Week { get; set; }
	public string Player { get; set; }
	public string Position { get; set; }
	public Move(
		int week,
		string position,		
		string player)
	{
		Week = week;
		Player = player;
		Position = position;
	}
}
