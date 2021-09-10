<Query Kind="Program" />

void Main()
{
	Portfolio crypto = LoadPortfolio();
	//crypto.Dump();
	Console.WriteLine(crypto.Report());
	Console.WriteLine(crypto.TotalLine());
}

private Portfolio LoadPortfolio()
{
	var portfolio = new Portfolio();
	LoadCoins(portfolio);
	LoadCoinTransactions(portfolio);
	LoadPrices(portfolio);
	return portfolio;
}

void LoadPrices(Portfolio portfolio)
{
	portfolio.AddPrice(new DateTime(2021, 09, 10), "SOL", 262.16M);
	portfolio.AddPrice(new DateTime(2021, 09, 10), "ADA", 3.515329M);
	portfolio.AddPrice(new DateTime(2021, 09, 08), "BTC", 64283.93M);
	portfolio.AddPrice(new DateTime(2021, 09, 08), "SOL", 241.02M);	
	portfolio.AddPrice(new DateTime(2021, 09, 08), "ETH", 4769.95M);
	portfolio.AddPrice(new DateTime(2021, 09, 08), "ADA", 3.490953M);
	portfolio.AddPrice(new DateTime(2021, 09, 07), "ETH", 5432.02M);
	portfolio.AddPrice(new DateTime(2021, 09, 07), "BTC", 71918.04M);
	portfolio.AddPrice(new DateTime(2021, 09, 07), "SOL", 227.6M);
	portfolio.AddPrice(new DateTime(2021, 09, 07), "ADA", 3.9195M);
	portfolio.AddPrice(new DateTime(2021, 09, 07), "AVA", 6.3749M);
	portfolio.AddPrice(new DateTime(2021, 09, 07), "WAXP", 0.494084M);	
	portfolio.AddPrice(new DateTime(2021, 09, 06), "ADA", 3.906439M);
	portfolio.AddPrice(new DateTime(2021, 09, 06), "ETH", 5360.5M);
	portfolio.AddPrice(new DateTime(2021, 09, 06), "BTC", 67986.04M);
	portfolio.AddPrice(new DateTime(2021, 09, 06), "SOL", 191.75M);
	portfolio.AddPrice(new DateTime(2021, 08, 31), "SOL", 178.52M);
	portfolio.AddPrice(new DateTime(2021, 08, 30), "WAXP", 0.487911M);
	portfolio.AddPrice(new DateTime(2021, 09, 02), "ADA", 4.008387M);
	portfolio.AddPrice(new DateTime(2021, 09, 02), "BTC", 67293.91M);
	portfolio.AddPrice(new DateTime(2021, 09, 02), "ETH", 5446.27M);
	portfolio.AddPrice(new DateTime(2021, 08, 31), "SOL", 155.54M);
	portfolio.AddPrice(new DateTime(2021, 08, 30), "BTC", 67820.37M);	
	portfolio.AddPrice(new DateTime(2021, 08, 30), "ADA", 4.014973M);
	portfolio.AddPrice(new DateTime(2021, 08, 30), "WAXP", 0.509483M);
	portfolio.AddPrice(new DateTime(2021, 08, 30), "SOL", 135.94M);
	portfolio.AddPrice(new DateTime(2021, 08, 26), "WAXP", 0.471126M);	
	portfolio.AddPrice(new DateTime(2021, 08, 24), "ETH", 4743.71M);
	portfolio.AddPrice(new DateTime(2021, 08, 24), "BTC", 69769.72M);
	portfolio.AddPrice(new DateTime(2021, 08, 24), "SOL", 108.08M);
	portfolio.AddPrice(new DateTime(2021, 08, 24), "ADA", 4.164332M);	
	portfolio.AddPrice(new DateTime(2021, 08, 24), "AVA", 4.5239M);	
	portfolio.AddPrice(new DateTime(2021, 08, 24), "THOR", 16.3292M);
	portfolio.AddPrice(new DateTime(2021, 08, 24), "KSM", 469.51M);
	portfolio.AddPrice(new DateTime(2021, 08, 24), "JUVE", 19.03M);
}
		
void LoadCoinTransactions(Portfolio portfolio)
{
	portfolio.AddCoinTransaction(
		new CoinTransaction(
			code: "ADA",
			quantity: 56.531084M,
			rate: 3.536826M,
			when: new DateTime(2021, 9, 10),
			aussieDollars: 201.94M
		));
		
	portfolio.AddCoinTransaction(
	new CoinTransaction(
		code: "SOL",
		quantity: -0.938739M,
		rate: 216.10101M,
		when: new DateTime(2021, 9, 8),
		aussieDollars: -200.83M
	));
	
	portfolio.AddCoinTransaction(
		new CoinTransaction(
			code: "ADA",
			quantity: 21.7077024M,
			rate: 1370.392929M,
			when: new DateTime(2021, 9, 07),
			aussieDollars: 84.68M
		));

	portfolio.AddCoinTransaction(
		new CoinTransaction(
			code: "ETH",
			quantity: -0.016M,
			rate: 5431.42M,
			when: new DateTime(2021, 9, 07),
			aussieDollars: -84.68M
		));

	portfolio.AddCoinTransaction(
		new CoinTransaction(
			code: "SOL",
			quantity: 0.266368M,
			rate: 185.851488M,
			when: new DateTime(2021, 9, 03),
			aussieDollars: 50.00M
		));
		
	portfolio.AddCoinTransaction(
		new CoinTransaction(
			code: "SOL",
			quantity: 0.297527M,
			rate: 159.732683M,
			when: new DateTime(2021, 9, 02),
			aussieDollars: 48.00M
		));
		
	portfolio.AddCoinTransaction(
		new CoinTransaction(
			code: "SOL",
			quantity: 0.372195M,
			rate: 133.247527M,
			when: new DateTime(2021, 8, 30),
			aussieDollars: 50.09M
		));
		
	portfolio.AddCoinTransaction(
		new CoinTransaction(
			"WAXP",
			99.047126M,
			0.489816M,
			new DateTime(2021, 8, 26),
			49M
		));
		
	portfolio.AddCoinTransaction(
		new CoinTransaction(
			"BTC",
			0.00114M,
			43430.347755M,
			new DateTime(2021, 6, 23),
			50M
		));

	portfolio.AddCoinTransaction(
		new CoinTransaction(
			"BTC",
			0.001185M,
			43883.291842M,
			new DateTime(2021, 6, 9),
			52.5M
		));

	portfolio.AddCoinTransaction(
		new CoinTransaction(
			"BTC",
			0.000777M,
			49785.78358M,
			new DateTime(2021, 5, 26),
			39.09M
		));

	portfolio.AddCoinTransaction(
		new CoinTransaction(
			"BTC",
			0.000625M,
			51176.75624M,
			new DateTime(2021, 5, 25),
			32.28M
		));
	portfolio.AddCoinTransaction(
		new CoinTransaction(
			"BTC",
			0.001749M,
			56112.78273M,
			new DateTime(2021, 5, 19),
			99.1M
		));
	portfolio.AddCoinTransaction(
		new CoinTransaction(
			"BTC",
			0.000866M,
			68602.83691M,
			new DateTime(2021, 2, 18),
			60M
		));
	portfolio.AddCoinTransaction(
		new CoinTransaction(
			"BTC",
			0.00014672M,
			68602.83691M,
			new DateTime(2021, 2, 17),
			0M
		));

	portfolio.AddCoinTransaction(
		new CoinTransaction(
			"ETH",
			0.009948M,
			4214.1119051M,
			new DateTime(2021, 8, 13),
			42.34M
		));
		
	portfolio.AddCoinTransaction(
		new CoinTransaction(
			"ETH",
			0.001713M,
			0M,
			new DateTime(2021, 8, 2),
			0M
		));

	portfolio.AddCoinTransaction(
		new CoinTransaction(
			"ETH",
			0.01717M,
			2886.733981M,
			new DateTime(2021, 6, 30),
			50.06M
		));
	portfolio.AddCoinTransaction(
		new CoinTransaction(
			"ETH",
			-0.009612M,
			3392.141414M,
			new DateTime(2021, 5, 25),
			-32.28M
		));
	portfolio.AddCoinTransaction(
		new CoinTransaction(
			"ETH",
			0.009612M,
			2436.219089M,
			new DateTime(2021, 2, 18),
			23.65M
		));
	portfolio.AddCoinTransaction(
		new CoinTransaction(
			"SOL",
			1.00265M,
			56.049505M,
			new DateTime(2021, 8, 13),
			56.76M
		));
	portfolio.AddCoinTransaction(
		new CoinTransaction(
			"ADA",
			19.539703M,
			2.026846M,
			new DateTime(2021, 5, 26),
			40.00M
		));
	portfolio.AddCoinTransaction(
		new CoinTransaction(
			"AVA",
			11.79693M,
			4.196427M,
			new DateTime(2021, 6, 18),
			50.00M
		));
	portfolio.AddCoinTransaction(
		new CoinTransaction(
			"THOR",
			-3.5M,
			15.407686M,
			new DateTime(2021, 6, 10),
			-53.39M
		));
	portfolio.AddCoinTransaction(
		new CoinTransaction(
			"THOR",
			6.42011M,
			7.710919M,
			new DateTime(2021, 3, 9),
			50.00M
		));
	portfolio.AddCoinTransaction(
		new CoinTransaction(
			"JUVE",
			0.990151M,
			15.079208M,
			new DateTime(2021, 2, 18),
			15.08M
		));
	portfolio.AddCoinTransaction(
		new CoinTransaction(
			"KSM",
			-0.075M,
			674.262626M,
			new DateTime(2021, 6, 10),
			-50.06M
		));
	portfolio.AddCoinTransaction(
		new CoinTransaction(
			"KSM",
			0.152987M,
			320.158421M,
			new DateTime(2021, 3, 9),
			49.47M
		));
}

void LoadCoins(Portfolio portfolio)
{
	portfolio.Coins.Add( 
		new Coin
		{
			Name = "Bitcoin",
			Code = "BTC",
			CoinTransactions = new List<UserQuery.CoinTransaction>(),
			Prices = new List<UserQuery.Price>()
		});
	portfolio.Coins.Add(
		new Coin
		{
			Name = "Ethereum",
			Code = "ETH",
			CoinTransactions = new List<UserQuery.CoinTransaction>(),
			Prices = new List<UserQuery.Price>()
		});
	portfolio.Coins.Add(
		new Coin
		{
			Name = "Solana",
			Code = "SOL",
			CoinTransactions = new List<UserQuery.CoinTransaction>(),
			Prices = new List<UserQuery.Price>()
		});
	portfolio.Coins.Add(
		new Coin
		{
			Name = "Cardano",
			Code = "ADA",
			CoinTransactions = new List<UserQuery.CoinTransaction>(),
			Prices = new List<UserQuery.Price>()
		});
	portfolio.Coins.Add(
		new Coin
		{
			Name = "Travala",
			Code = "AVA",
			CoinTransactions = new List<UserQuery.CoinTransaction>(),
			Prices = new List<UserQuery.Price>()
		});
	portfolio.Coins.Add(
		new Coin
		{
			Name = "THORChain",
			Code = "THOR",
			CoinTransactions = new List<UserQuery.CoinTransaction>(),
			Prices = new List<UserQuery.Price>()
		});
	portfolio.Coins.Add(
		new Coin
		{
			Name = "Kusama",
			Code = "KSM",
			CoinTransactions = new List<UserQuery.CoinTransaction>(),
			Prices = new List<UserQuery.Price>()
		});
	portfolio.Coins.Add(
		new Coin
		{
			Name = "Juventus Fan Token",
			Code = "JUVE",
			CoinTransactions = new List<UserQuery.CoinTransaction>(),
			Prices = new List<UserQuery.Price>()
		});
	portfolio.Coins.Add(
		new Coin
		{
			Name = "WAX",
			Code = "WAXP",
			CoinTransactions = new List<UserQuery.CoinTransaction>(),
			Prices = new List<UserQuery.Price>()
		});
}

public class Portfolio
{
	public List<Coin> Coins { get; set; }
	public Portfolio()
	{
		Coins = new List<Coin>();
	}
	public void AddCoinTransaction(
		CoinTransaction transaction)
	{
		var coin = GetCoin(transaction.Code);
		coin.CoinTransactions.Add(transaction);	
	}
	
	private Coin GetCoin(
		string coinCode)
	{
		var coinFound = new Coin();
		var found = false;
		foreach (var c in Coins)
		{
			if (c.Code.Equals(coinCode) )
			{
				coinFound = c;
				found = true;
				break;
			}
		}		
		if (!found)
		{
			coinFound.Code = coinCode;
			coinFound.CoinTransactions = new List<UserQuery.CoinTransaction>();
		}
		return coinFound;
	}

	internal void AddPrice(
		DateTime priceOn, 
		string code, 
		decimal price)
	{
		var coin = GetCoin(code);
		coin.Prices.Add( new Price( priceOn, code, price ));
	}

	internal string Report()
	{
	
		var sb = new StringBuilder();
		sb.AppendLine( "Code  Name                     Amount        Rate         Worth         Invested");		
		foreach (var coin in Coins)
		{
			sb.AppendLine( coin.ToString() );
		}
		return sb.ToString();
	}

	public string TotalLine()
	{
		return $"                                                       {TotalMarketValue():c}        {TotalInvested():c}         {TotalProfit():c}   {TotalROI():0.00#} ROI";
	}

	internal string BottomLine()
	{
		var sb = new StringBuilder();
		var total = 0M;
		foreach (var coin in Coins)
		{
			total += coin.MarketValue();
		}
		sb.AppendLine($"{total:c}");
		return sb.ToString();
	}

	internal decimal TotalMarketValue()
	{
		var total = 0M;
		foreach (var coin in Coins)
		{
			total += coin.MarketValue();
		}
		return total;
	}

	internal decimal TotalInvested()
	{
		var total = 0M;
		foreach (var coin in Coins)
		{
			total += coin.TotalDollarCost();
		}
		return total;
	}

	internal string Profits()
	{
		var sb = new StringBuilder();
		var total = 0M;
		foreach (var coin in Coins)
		{
			total += coin.Profit();
		}
		sb.AppendLine($"{total:c}");
		return sb.ToString();
	}

	internal decimal TotalProfit()
	{
		var total = 0M;
		foreach (var coin in Coins)
		{
			total += coin.Profit();
		}
		return total;
	}

	internal decimal TotalROI()
	{
		var totalProfit = 0M;
		var totalInvested = 0M;
		foreach (var coin in Coins)
		{
			totalProfit += coin.Profit();
			totalInvested += coin.TotalDollarCost();
		}
		return totalProfit / totalInvested;
	}
	
	internal string ROI()
	{
		var sb = new StringBuilder();
		var totalProfit = 0M;
		var totalInvested = 0M;
		foreach (var coin in Coins)
		{
			totalProfit += coin.Profit();
			totalInvested += coin.TotalDollarCost();
		}
		sb.AppendLine($"ROI: {totalProfit/totalInvested:0.0#}");
		return sb.ToString();
	}

}

public class Price
{
	public DateTime PriceOn { get; set; }
	public string Code { get; set; }
	public decimal PricedAt { get; set; }

	public Price(
		DateTime priceOn,
		string code,
		decimal price)
	{
		PriceOn = priceOn;
		Code = code;
		PricedAt = price;
	}
}

public class Coin
{
	public string Name { get; set; }
	public string Code { get; set; }
	public string WikiPage { get; set; }
	public List<Price> Prices { get; set; }
	public List<CoinTransaction> CoinTransactions { get; set; }
	public override string ToString()
	{
		return $"{Code,-4} {Name,-20} {BalanceOut(),12} {RateOut(),12} {MarketValueOut(),12}   {Invested(),12}   {WinLose(),-4}  {ProfitOut().Trim(),7}  {RoiOut(),7}";
	}
	
	public decimal MarketValue()
	{
		return Balance() * Rate();
	}
	
	public decimal TotalDollarCost()
	{
		var totalInvested = CoinTransactions.Sum(t => t.DollarCost);
		if (totalInvested < 0M)
			totalInvested = 0;
		return totalInvested;
	}

	public decimal Profit()
	{
		return MarketValue() - TotalDollarCost();
	}

	private string Invested()
	{
		var invested = TotalDollarCost();
		if (invested < 0M)
			invested = 0M;
		return $"{invested:c}";
	}
	
	private decimal CoinRoi()
	{
		if (TotalDollarCost() == 0M )
			return 0M;
		return Profit() / TotalDollarCost();
	}

	private string WinLose()
	{
		var profit = Profit();
		string win = string.Empty;
		if (profit > 0.0M)
			win = " up ";
		else
			win = "down";
		return win;
	}

	private string ProfitOut()
	{
		var profit = Profit();
		return $"{profit:c}";
	}

	private string RoiOut()
	{
		var roi = CoinRoi();
		if (roi <= 0M)
			return string.Empty;
		return $"{roi:0.0##}";
	}

	private string MarketValueOut()
	{
		var valAsDollars = $"{MarketValue():c}";
		return valAsDollars;
	}

	private string RateOut()
	{
		var rateAsDollars = $"{Rate():c}";
		return rateAsDollars;
	}

	private string BalanceOut()
	{
		var balAsDollars = $"{Balance():0.0#####}";
		return balAsDollars;
	}

	public decimal Balance()
	{
		var balance = 0M;
		foreach (var transaction in CoinTransactions)
		{
			balance += transaction.Quantity;
		}
		return balance;
	}

	public decimal Rate()
	{
		var rate = 0M;
		var sortedPrices = Prices.OrderByDescending(p => p.PriceOn).ToList();
		rate = sortedPrices.FirstOrDefault().PricedAt;
		return rate;
	}
}

public class CoinTransaction
{
	public string Code { get; set; }
	public decimal Quantity { get; set; }
	public decimal Rate { get; set; }
	public DateTime When { get; set; }
	public decimal DollarCost { get; set; }

	public CoinTransaction(
		string code,
		decimal quantity,
		decimal rate,
		DateTime when,
		decimal aussieDollars)
	{
		Code = code;
		Quantity = quantity;
		Rate = rate;
		When = when;
		DollarCost = aussieDollars;
	}
}

