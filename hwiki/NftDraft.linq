<Query Kind="Program" />

void Main()
{
	var nftDraft = new NftDraft();
	nftDraft.LoadCollection();
	nftDraft.LoadSeason("2021");
	var query = nftDraft.BaseValues
		.Select(b => new
		{
			team = b.teamCode,
//			pts = b.def
			pts = b.qb1 + b.qb2 + b.rb1 + b.rb2 + b.rb3 + b.wr1 + b.wr2 + b.wr3 + b.wr4 + b.wr5 + b.te1 + b.te2 + b.te3 + b.def + b.k
		});
	//pts = b.wr1 + b.wr2 + b.wr3 + b.wr4 + b.wr5
	//pts = b.qb1 + b.qb2 + b.rb1 + b.rb2 + b.rb3 + b.wr1 + b.wr2 + b.wr3 + b.wr4 + b.wr5 + b.te1 + b.te2 + b.te3 + b.def + b.k
	query.OrderByDescending(q=>q.pts).Dump();

	Console.WriteLine($"Total Cap Value: {nftDraft.Cards.Sum(x => x.CapValue)}");
	Console.WriteLine($"Total NFTs: {nftDraft.Cards.Count()}");
	Console.WriteLine($"Total Invested: AU$ {nftDraft.Cards.Sum(c=>c.Cost):c}");
	
	var lineup = new NftLineup(nftDraft)
		.AddCard( "1099556437486", "Patrick Mahomes" )   // 1
		.AddCard( "1099555262472", "Zach Wilson" )       // 2
		.AddCard( "1099556904926", "SF Defence" )        // 3
		.AddCard( "1099556871651", "Michael Badgley" )   // 4
		.AddCard( "1099557079337", "Tyreek Hill" )        // 5
		.AddCard( "1099556658633", "Julio Jones" )       // 6
		.AddCard( "1099555446686", "Austin Ekeler" )     // 7
		.AddCard( "1099555229935", "SS RB 2 " )          // 8
		.AddCard( "1099555423885", "NJ WR 3" )           // 9
		.AddCard( "1099556882206", "CP TE" )             // 10
		.Validate();
		
	lineup.Dump();

}

public class NftLineup
{
	private readonly NftDraft NftDraft;
	public List<NftCard> Cards { get; set; }

	public NftLineup(NftDraft nftDraft)
	{
		NftDraft = nftDraft;
		Cards = new List<UserQuery.NftCard>();
	}

	public NftLineup AddCard(
		string id,
		string comment)
	{
		var selection = NftDraft.GetCard(id);
		selection.Comment = comment;
		Cards.Add(selection);
		return this;
	}

	internal NftLineup Validate()
	{
		var errorCount = 0;
		var qbCount = Cards.Count(c=>c.Position == "QB");
		var defCount = Cards.Count(c=>c.Position == "DK" || c.Position == "DF" );
		var kickerCount = Cards.Count(c=>c.Position == "PK" || c.Position == "DK" );
		var oneOfDfKDk = Cards.Count(c => c.Position == "DK" || c.Position == "DF" || c.Position == "PK");
		if (qbCount < 1)
		{
			Console.WriteLine("Not enough QBs");
			errorCount++;
		}
		if (qbCount > 2)
		{
			Console.WriteLine("Too many QBs");
			errorCount++;
		}
		if (defCount > 2)
		{
			Console.WriteLine("Too many Defenses");
			errorCount++;
		}
		if (kickerCount > 2)
		{
			Console.WriteLine("Too many Kickers");
			errorCount++;
		}
		if (oneOfDfKDk == 0)
		{
			Console.WriteLine("must enter one of the following: Defense, Defense+Kicker, or Kicker");
			errorCount++;			
		}
		if (Cards.Count < 10)
		{
			Console.WriteLine($"{10-Cards.Count} to go");
		}
		if (errorCount == 0 && Cards.Count == 10)
		{
			Console.WriteLine($"Lineup OK : {Cards.Count} cards");
		}
		return this;
	}
}

public class NftDraft
{
	public List<NftCard> Cards { get; set; }
	public List<TeamBaseValues> BaseValues { get; set; }
	
	public NftDraft()
	{
		
	}
	
	public void LoadCollection()
	{
		Cards = new List<UserQuery.NftCard>();
		Cards.Add(new NftCard("1099556437486", 20, "KC", "QB", 1, new DateTime(2021, 8, 31), 8.61M * 1.37M));
		Cards.Add(new NftCard("1099557042702", 20, "GB", "QB", 1, new DateTime(2021, 8, 26)));
		Cards.Add(new NftCard("1099555262472", 17, "NJ", "QB", 1, new DateTime(2021, 8, 26)));
		Cards.Add(new NftCard("1099555374824", 17, "SF", "QB", 1, new DateTime(2021, 9, 3), 1.40M * 1.37M));
		Cards.Add(new NftCard("1099556975321", 16, "TB", "QB", 1, new DateTime(2021, 9, 3), 4.62M * 1.37M));
		Cards.Add(new NftCard("1099557026847", 16, "CH", "QB", 1, new DateTime(2021, 9, 3), 1.39M * 1.37M));
		Cards.Add(new NftCard("1099555519146", 16, "CP", "QB", 1, new DateTime(2021, 8, 28), .54M));
		Cards.Add(new NftCard("1099559569323", 5, "IC", "QB", 2, new DateTime(2021, 8, 26)));
		Cards.Add(new NftCard("1099556849100", 4, "DC", "QB", 2, new DateTime(2021, 8, 28), .54M));

		Cards.Add(new NftCard("1099555446686", 19, "SD", "RB", 1, new DateTime(2021, 8, 25)));
		Cards.Add(new NftCard("1099555360917", 18, "PE", "RB", 1, new DateTime(2021, 8, 26)));
		Cards.Add(new NftCard( "1099555360917", 15, "BB", "RB", 1, new DateTime(2021,8,26) ));
		Cards.Add(new NftCard("1099559460760", 15, "BB", "RB", 1, new DateTime(2021, 8, 26)));
		Cards.Add(new NftCard("1099557044332", 15, "PS", "RB", 1, new DateTime(2021, 9, 3), 4.60M * 1.37M));
		Cards.Add(new NftCard("1099557237306", 14, "SF", "RB", 1, new DateTime(2021, 8, 26), .69M * 1.37M));		
		Cards.Add(new NftCard("1099555229935", 8, "SS", "RB", 2, new DateTime(2021, 8, 26)));
		
		Cards.Add(new NftCard("1099557079337", 20, "KC", "WR", 1, new DateTime(2021, 8, 31), 3.43M * 1.37M));
		Cards.Add(new NftCard("1099559458206", 20, "SS", "WR", 1, new DateTime(2021, 8, 26)));
		Cards.Add(new NftCard("1099556827524", 18, "SS", "WR", 2, new DateTime(2021, 8, 25)));
		Cards.Add(new NftCard("1099557049040", 18, "LR", "WR", 2, new DateTime(2021, 8, 26)));
		Cards.Add(new NftCard("1099556658633", 15, "TT", "WR", 2, new DateTime(2021, 8, 26)));
		Cards.Add(new NftCard("1099555584936", 9, "BB", "WR", 3, new DateTime(2021, 8, 28), .54M));
		Cards.Add(new NftCard("1099555423885", 8, "NJ", "WR", 3, new DateTime(2021, 8, 28), .09M * 1.37M));
		
		Cards.Add(new NftCard("1099557007259", 19, "LV", "TE", 1, new DateTime(2021, 8, 26)));
		Cards.Add(new NftCard("1099559456492", 19, "LV", "TE", 1, new DateTime(2021, 8, 26)));
		Cards.Add(new NftCard("1099558119606", 19, "LV", "TE", 1, new DateTime(2021, 8, 26)));
		Cards.Add(new NftCard("1099558133652", 9, "LR", "TE", 2, new DateTime(2021, 8, 28), .54M));
		Cards.Add(new NftCard("1099556882206", 8, "CP", "TE", 1, new DateTime(2021, 8, 28), .15M * 1.37M));

		Cards.Add(new NftCard("1099555335006", 17, "KC", "DK", 1, new DateTime(2021, 8, 26)));
		Cards.Add(new NftCard("1099555004345", 15, "IC", "DK", 1, new DateTime(2021, 8, 30), .14M * 1.37M));
		Cards.Add(new NftCard("1099556855344", 15, "PS", "DK", 1, new DateTime(2021, 8, 30), .34M * 1.37M));	
		Cards.Add(new NftCard("???", 15, "GB", "DK", 1, new DateTime(2021, 8, 31), .34M * 1.37M));		
		Cards.Add(new NftCard("1099555405804", 14, "AC", "DK", 1, new DateTime(2021, 8, 28), .54M));

		Cards.Add(new NftCard("1099556871651", 10, "SD", "PK", 1, new DateTime(2021, 8, 26)));

		Cards.Add(new NftCard("1099556904926", 10, "SF", "DF", 1, new DateTime(2021, 8, 26)));
		Cards.Add(new NftCard("1099556834895", 10, "SF", "DF", 1, new DateTime(2021, 8, 26)));
		Cards.Add(new NftCard("1099556704965", 9, "LR", "DF", 1, new DateTime(2021, 8, 26)));

		

	}

	public NftCard GetCard(string id)
	{
		var selectedCard = Cards.Where(c=>c.Id == id).FirstOrDefault();
		return selectedCard;
	}

	public void LoadSeason(string season)
	{
		BaseValues = new List<UserQuery.TeamBaseValues>();
		//                                      Q1 Q2 RB1 R2 R3 WR1  W2  W3 W4 W5 T1 T2 T3  DK  D  PK
		BaseValues.Add(new TeamBaseValues("AC", 18, 4, 17, 8, 4, 19, 13, 12, 6, 5, 7, 5, 3, 14, 8, 10));
		BaseValues.Add(new TeamBaseValues("AF", 18, 3, 14, 8, 3, 19, 19, 11, 5, 3,17, 6, 3, 16, 7, 10));
		BaseValues.Add(new TeamBaseValues("BR", 17, 3, 19, 9, 5, 15,  9,  6, 6, 3,15, 5, 4, 15,10, 11));
		BaseValues.Add(new TeamBaseValues("BB", 20, 4, 15,15, 3, 20, 14,  9, 9, 7,11, 5, 3, 16,10, 10));
		BaseValues.Add(new TeamBaseValues("CP", 16, 7, 20, 6, 3, 18, 15, 14, 5, 4, 8, 4, 3, 15, 7, 10));
		BaseValues.Add(new TeamBaseValues("CH", 16, 3, 19,15, 6, 19, 13,  8, 4, 3,10, 7, 3, 15, 8, 10));
		BaseValues.Add(new TeamBaseValues("CI", 15, 4, 19, 6, 3, 18, 18, 10, 6, 5, 9, 8, 3, 15, 8, 10));
		BaseValues.Add(new TeamBaseValues("CL", 16, 3, 20,14, 5, 18, 15,  7, 4, 3,11, 6, 4, 14,10, 10));
		BaseValues.Add(new TeamBaseValues("DC", 16, 4, 20, 9, 4, 18, 18, 15, 5, 4,10, 7, 4, 15, 7, 10));
		BaseValues.Add(new TeamBaseValues("DB", 16, 3, 17, 8, 6, 17, 17,  8, 7, 4,15, 6, 4, 15, 9, 12));
		BaseValues.Add(new TeamBaseValues("DL", 16, 3, 18,10, 6, 18, 13,  9, 6, 5,15, 5, 3, 12, 7, 10));
		BaseValues.Add(new TeamBaseValues("GB", 20, 3, 20,10, 5, 20, 15, 12, 5, 5,15, 4, 4, 14, 9, 10));
		BaseValues.Add(new TeamBaseValues("HT", 17, 4, 15, 6, 5, 18, 17, 10, 8, 5, 9, 5, 5, 15,10, 10));
		BaseValues.Add(new TeamBaseValues("IC", 16, 5, 20,15,10, 15, 15, 10, 7, 3, 8, 8, 3, 15,10, 10));
		BaseValues.Add(new TeamBaseValues("JJ", 16, 4, 19, 7, 4, 17, 15,  8, 6, 5, 7, 5, 3, 13, 8, 10));
		BaseValues.Add(new TeamBaseValues("KC", 20, 3, 20,10, 5, 20, 14, 10, 5, 3,20, 5, 3, 17, 7, 12));
		BaseValues.Add(new TeamBaseValues("LV", 16, 4, 20,13, 5, 15, 15,  8, 8, 6,19, 7, 3, 13, 7, 10));
		BaseValues.Add(new TeamBaseValues("LR", 16, 4, 19, 9, 5, 18, 18,  9, 9, 3,10, 6, 4, 15, 9, 12));
		BaseValues.Add(new TeamBaseValues("MD", 15, 5, 17, 8, 7, 17, 16, 10, 7, 3,14, 4, 3, 16, 9, 10));
		BaseValues.Add(new TeamBaseValues("MV", 17, 3, 20, 9, 5, 19, 18,  6, 4, 3,10, 7, 3, 15, 8, 10));
		BaseValues.Add(new TeamBaseValues("NE", 16, 4, 15,14, 8, 13, 10,  7, 6, 3,11,10, 4, 15, 9, 10));
		BaseValues.Add(new TeamBaseValues("NO", 16, 9, 20, 6, 3, 19,  9,  9, 6, 5, 9, 5, 3, 14, 9, 10));
		BaseValues.Add(new TeamBaseValues("NG", 16, 4, 20,11, 6, 15, 13, 11, 4, 3,14, 8, 3, 15, 7, 11));
		BaseValues.Add(new TeamBaseValues("NJ", 17, 3, 14, 9, 7, 15, 15,  8, 4, 3,10, 4, 3, 13, 8, 10));
		BaseValues.Add(new TeamBaseValues("PE", 16, 3, 18, 9, 7, 17, 14, 10, 4, 3,15, 9, 3, 12, 7, 10));
		BaseValues.Add(new TeamBaseValues("PS", 17, 4, 15, 9, 3, 18, 18, 14, 7, 5,12, 4, 3, 15,10, 10));
		BaseValues.Add(new TeamBaseValues("LC", 17, 7, 19, 8, 7, 19, 15,  8, 7, 3,15, 8, 4, 12, 7, 10));
		BaseValues.Add(new TeamBaseValues("SF", 17, 7, 14,12, 6, 18, 18,  6, 6, 5,19, 4, 3, 15,10, 10));
		BaseValues.Add(new TeamBaseValues("SS", 17, 3, 18, 8, 6, 20, 18,  5, 3, 3, 8, 8, 3, 15, 7, 11));
		BaseValues.Add(new TeamBaseValues("TB", 16, 3, 19,14, 8, 19, 19, 15, 7, 3,11,10, 4, 15,12, 10));
		BaseValues.Add(new TeamBaseValues("TT", 17, 3, 20, 8, 5, 20, 15,  8, 6, 5,15, 6, 3, 14, 8, 10));
		BaseValues.Add(new TeamBaseValues("WR", 15, 4, 19,14, 5, 19,  8,  4, 4, 3,15, 4, 3, 14, 9, 10));
	}
}

public record TeamBaseValues(
	string teamCode,
	int qb1,
	int qb2,
	int rb1,
	int rb2,
	int rb3,
	int wr1,
	int wr2,
	int wr3,
	int wr4,
	int wr5,
	int te1,
	int te2,
	int te3,
	int dk,
	int def,
	int k);

public class NftCard
{
	public string Id { get; set; }
	public string TeamCode { get; set; }
	public string Position { get; set; }
	public string Rarity { get; set; }

	public int Depth { get; set; }
	public int CapValue { get; set; }
	public decimal Cost { get; set; }
	public DateTime Acquired { get; set; }
	public string Comment { get; set; }
	
	public NftCard(
		string id, 
		int capValue,
		string teamCode, 
		string position, 
		int depth, 
		DateTime dateTime,
		decimal cost = 1.00M,
		string rarity = "C")
	{
		Id = id;
		TeamCode = teamCode;
		Position  = position;
		Depth = depth;
		Acquired = dateTime;
		Rarity = rarity;
		CapValue = capValue;
		Cost = cost;
	}


}