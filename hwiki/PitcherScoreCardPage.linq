<Query Kind="Program">
  <Output>DataGrids</Output>
  <Namespace>Utes</Namespace>
</Query>

void Main()
{
	var week = 21;
	var year = 2021;
	var page = new WikiPage();
	page.AddElement( 
		new WikiHeading(
			1,
			$"Week {week} [[Canberra Anomolies {year}]]"));
	DisplayPitcherTable(
	    monday: new DateTime(year, 8, 23),
		page: page);
	Threading(
		page,
		BackwardLink(week),
		ForwardLink(week));
	page.RenderToConsole();
}

public List<Pitcher> LoadPitchers()
{
	var pitchers = new List<Pitcher>
	{
		new Pitcher
		{
			Name = "Jacob de Grom",
			TeamCode = "NYM",
			SeedDate = new DateTime(2021, 6, 16),
			Status = "X"				
		},
		new Pitcher
		{
			Name = "Robbie Ray",
			TeamCode = "Tor",
			SeedDate = new DateTime(2021, 6, 18),
			Status = "S"			
		},
		new Pitcher
		{
			Name = "Chris Bassitt",
			TeamCode = "Oak",
			SeedDate = new DateTime(2021, 6, 19),
			Status = "I"
		},
		new Pitcher
		{
			Name = "Pablo Lopez",
			TeamCode = "Mia",
			SeedDate = new DateTime(2021, 6, 19),
			Status = "I"			
		},
		new Pitcher
		{
			Name = "Hyun Jin Ryu",
			TeamCode = "Tor",
			SeedDate = new DateTime(2021, 6, 20),
			Status = "X"
		},
		new Pitcher
		{
			Name = "Kenta Maeda",
			TeamCode = "Min",
			SeedDate = new DateTime(2021, 6, 20),
			Status = "S"
		},
		new Pitcher
		{
			Name = "Zack Wheeler",
			TeamCode = "Phi",
			SeedDate = new DateTime(2021, 6, 16)
		},
		new Pitcher
		{
			Name = "Brandon Woodruff",
			TeamCode = "Mil",
			SeedDate = new DateTime(2021, 6, 17)
		},
		new Pitcher
		{
			Name = "Alex Manoah",
			TeamCode = "Tor",
			SeedDate = new DateTime(2021, 6, 4),
			Status = "X"			
		},
		new Pitcher
		{
			Name = "Tarik Skubal",
			TeamCode = "Det",
			SeedDate = new DateTime(2021, 6, 17),
			Status = "X"
		},
		new Pitcher
		{
			Name = "Jon Gray",
			TeamCode = "Col",
			SeedDate = new DateTime(2021, 7, 26),
			Status = "X"
		},
		new Pitcher
		{
			Name = "Patrick Sandoval",
			TeamCode = "LAA",
			SeedDate = new DateTime(2021, 7, 31),
			Status = "X"
		},
		new Pitcher
		{
			Name = "Logan Webb",
			TeamCode = "SF",
			SeedDate = new DateTime(2021, 8, 7),
			Status = "S"
		},
	};
	return pitchers;
}

string BackwardLink(int week)
{
	return LinkFor(week-1);
}

string ForwardLink(int week)
{
	return LinkFor(week+1);
}

string LinkFor(int week)
{
	return $"Canberra Anomolies 2021 Week{week:0#} Pitching Score Card";
}

void Threading(
	WikiPage page, 
	string forwardLink, 
	string backLink)
{
	page.AddElement(
		new WikiThreading(
			forwardLink,
			backLink ));
}

void DisplayPitcherTable(
    DateTime monday,
	WikiPage page)
{
	var table = new WikiTable();
	table.Columns.Add(new Utes.WikiColumn("Date"));
	table.Columns.Add(new Utes.WikiColumn("Pts"));
	table.Columns.Add(new Utes.WikiColumn("Starter"));
	table.Columns.Add(new Utes.WikiColumn("Opp"));
	table.Columns.Add(new Utes.WikiColumn("Results"));
	table.Columns.Add(new Utes.WikiColumn("IP"));
	table.Columns.Add(new Utes.WikiColumn("ER"));
	table.Columns.Add(new Utes.WikiColumn("K"));
	table.Columns.Add(new Utes.WikiColumn("QS"));
	table.Columns.Add(new Utes.WikiColumn("Comments"));

	AddRows(
		monday,
		table);	
	page.AddElement(
		table);
}

void AddRows(
	DateTime monday, 
	WikiTable table)
{
	var topRow = 1;
	for (int d = 0; d < 7; d++)
	{
		var theDate = monday.AddDays(d);
		var rowsToAdd = RowsToAdd(theDate);
		for (int r = 0; r < rowsToAdd; r++)
		{
			table.AddRows(
				1);
			table.AddCell(
			   row: topRow,
			   col: 0,
			   cellValue: DateOut(theDate));
			table.AddCell(
			   row: topRow+r,
			   col: 2,
			   cellValue: PitcherFor(theDate,r));
		}
		topRow += rowsToAdd;
	}
}

string PitcherFor(
	DateTime theDate, 
	int r)
{
	var pitchers = LoadPitchers();
	var pitcher = pitchers
		.Where(p => (p.PitchesOn(theDate))
			&& p.IsAvailable())
		.Skip(r)
		.Select(p => p)
		.FirstOrDefault();  //  could be more than 1
	if (pitcher == null)
		return string.Empty;
	var pitcherName = pitcher.NameOut();
	return pitcherName;
}

int RowsToAdd(
	DateTime theDate)
{
	var rowsToAdd = 1;
	var firstPitcher = true;
	var pitchers = LoadPitchers();
	foreach (var p in pitchers)
	{
		if (p.Status == "X" || p.Status == "I")
			continue;
		if (p.PitchesOn(theDate))
		{
			if (firstPitcher)
			{
				firstPitcher = false;
				continue;
			}
			rowsToAdd++;
		}
	}
	return rowsToAdd;
}

public string PitcherFor(DateTime theDate)
{
	List<Pitcher> pitchers = LoadPitchers();
	foreach (var p in pitchers)
	{
		if (p.Status != "X" && p.Status != "I")
			continue;
		if (p.PitchesOn(theDate))
		{
			return p.NameOut();
		}
	}
	return string.Empty;
}


string DateOut(DateTime date)
{
	return $"{date.ToString("ddd")}-[[{date.Year}-{date.Month:0#}]]-{date.Day:0#}";
}

public class Pitcher
{
	public string Name { get; set; }
	public string TeamCode { get; set; }
	public string Status { get; set; }	
	public DateTime SeedDate { get; set; }
	
	public Pitcher()
	{
		Status = "S";
	}
	
	public string NameOut()
	{
		var nameOut = $"{Name} ({TeamCode})";
		if (Status == "B")
			nameOut = $"_{nameOut}_";
		return nameOut;
	}

	public bool PitchesOn(DateTime theDate)
	{
		var seeddate = SeedDate;
		while (seeddate < theDate)
		{
			seeddate = seeddate.AddDays(5);
			if (theDate == seeddate)
				return true;
		}
		return false;
	}

	internal bool IsAvailable()
	{
		if (Status == "S")
			return true;
		if (Status == "B")
			return true;
		return false;
	}
}


