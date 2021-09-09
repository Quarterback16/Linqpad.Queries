<Query Kind="Program" />

void Main()
{
	//var metrics = new NftDraftMetrics{
	//	PassingYards = 300,
	//	PassingTds = 2,
	//	RushingYards = 60,
	//	RushingTds = 1,
	//	Interceptions = 1,
	//	FGsMade = new int[] { 37, 45, 51 },
	//	FGsMissed = new int[] { 54 },
	//	PatsMade = 5,
	//	PatsMissed = 1
	//};
	var metrics = new NftDraftMetrics
	{
		PassingYards = 0,
		PassingTds = 0,
		RushingYards = 0,
		RushingTds = 0,
		Interceptions = 0,
		FGsMade = new int[] { },
		FGsMissed = new int[] { },
		PatsMade = 0,
		PatsMissed = 0,
		DefensePointsAllowed = 15
	};

	Console.WriteLine(
		metrics.CalculateFP());
	
}

public class NftDraftMetrics
{
	public int PassingYards { get; set; }
	public int Interceptions { get; set; }
	public int Fumbles { get; set; }
	public int RushingYards { get; set; }
	public int PassingTds { get; set; }
	public int RushingTds { get; set; }
	public int[] FGsMade { get; set; }
	public int[] FGsMissed { get; set; }
	public int PatsMade { get; set; }
	public int PatsMissed { get; set; }
	public int DefensePointsAllowed { get; set; }
	public int Sacks { get; set; }
	public int DefensiveIntercepts { get; set; }
	public int FumbleRecoveries { get; set; }
	public int BlockedKick { get; set; }
	public int DefensiveTouchdowns { get; set; }
	public int Safeties { get; set; }




	public decimal CalculateFP()
	{
		var ydp = PassingYards / 25;
		var tdp = PassingTds * 4;
		var passingBonus = (PassingYards > 299) ? 3 : 0;
		var ydr = RushingYards / 10;
		var tdr = RushingTds * 6;
		var ints = Interceptions * -2;
		var fumbles = Fumbles * -2;
		var kpts = CalculateKicking();	
		var defpts = CalculateDefense();
		defpts += Sacks;
		defpts += DefensiveIntercepts * 2;
		defpts += FumbleRecoveries * 2;
		defpts += BlockedKick * 2;
		defpts += Safeties * 2;
		defpts += DefensiveTouchdowns * 6;


		return ydp 
			  + tdp 
			  + passingBonus 
			  + ydr 
			  + tdr 
			  + ints 
			  + fumbles
			  + defpts
			  + kpts;
	}
	
	private int CalculateKicking()
	{
		var kpts = 0;
		foreach (var fg in FGsMade)
		{
			if (fg < 40)
				kpts += 3;
			else if (fg < 50)
				kpts += 4;
			else
				kpts += 5;
		}
		kpts -= FGsMissed.Length;
		kpts += PatsMade;
		kpts -= PatsMissed;
		return kpts;
	}

	private int CalculateDefense()
	{
		switch (DefensePointsAllowed)
		{
			case 0:
				return 10;
			case < 7:
				return 7;
			case < 14:
				return 4;
			case < 21:
				return 1;
			case < 28:
				return 0;
			case < 35:
				return -1;
			case > 34:
				return -4;
		}
	}
}
