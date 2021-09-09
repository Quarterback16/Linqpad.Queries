<Query Kind="Program">
  <Reference>E:\FileSync\SyncProjects\GameLog\RosterService\bin\Release\GameLogService.dll</Reference>
  <Reference>E:\FileSync\SyncProjects\GameLog\RosterService\bin\Release\GridstatsEvents.json</Reference>
  <Reference>E:\FileSync\SyncProjects\GameLog\RosterService\bin\Release\RetroEvents.json</Reference>
  <Reference>E:\FileSync\SyncProjects\GameLog\RosterService\bin\Release\RosterService.dll</Reference>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>Utes</Namespace>
</Query>

void Main()
{
	// Write code to test your extensions here. Press F5 to compile and run. See MetaPage.linq for example Wiki generation code
	_utes = new DateUte();
	var table = new WikiTable();
	table.Columns.Add(
		new WikiColumn
		{
			Header = "**Day**"
		});
	table.Columns.Add(
		new WikiColumn
		{
			Header = "**AM** <br> 0600 - 0800"
		});
	table.Columns.Add(
		new WikiColumn
		{
			Header = "**WORK 1** <br> 0800 - 1200"
		});
	table.Columns.Add(
		new WikiColumn
		{
			Header = "**LUNCH** <br> 1200 - 1400"
		});
	table.Columns.Add(
		new WikiColumn
		{
			Header = "**WORK 2** <br> 1400 - 1700"
		});
	table.Columns.Add(
		new WikiColumn
		{
			Header = "**PM** <br> 1700 - 2000"
		});

	table.AddRows(7);  // one for each day

	for (int d = 0; d < 7; d++)
	{
		table.AddCell(
		   row:d+1, 
		   col:0, 
		   cellValue: DateCell(new DateTime(2021,2,1), d));
	}

	//  populate the cells

	table.Render();
}

private DateUte _utes;

string DateCell(DateTime startOfWeek, int d)
{
	var theDate = startOfWeek.AddDays(d);
	var theDay = theDate.Day;
	return $"**{theDate.ToString("dddd")}** <br> ({theDay:0#}) {_utes.IsHoliday(theDate)}";
}

public static class MyExtensions
{
	// Write custom extension methods here. They will be available to all queries.
	public static StringBuilder AppendFormattedLine(
		this StringBuilder @this,
		string format,
		params object[] args) => @this.AppendFormat(format, args).AppendLine();

	public static StringBuilder AppendWhen(
		this StringBuilder @this,
		Func<bool> predicate,
		Func<StringBuilder, StringBuilder> fn) => predicate() ? fn(@this) : @this;

	public static StringBuilder AppendSequence<T>(
		this StringBuilder @this,
		IEnumerable<T> sequence,
		Func<StringBuilder, T, StringBuilder> fn) => sequence.Aggregate(@this, fn);

	public static TResult Map<TSource, TResult>(
		this TSource @this,
		Func<TSource, TResult> fn) => fn(@this);

	public static T Tee<T>(
		this T @this,
		Action<T> action)
	{
		action(@this);
		return @this;
	}

    //  extend strings
	public static bool IsPalindrome(this string str)
	{
		char[] array = str.ToCharArray();
		Array.Reverse(array);
		string backwards = new string(array);
		return str == backwards;
	}

    //  extend any object
	public static void WriteToConsole(this object o, string objectName)
	{
		Console.WriteLine(
		   String.Format(
			  "{0}: {1}\n",
		   objectName,
		   o.ToString()));
	}
	
	public static bool IsPrime( this int i)
	{
		if ((i % 2) == 0)
		{
			return i == 2;
		}
		int sqrt = (int) Math.Sqrt(i);
		for (int t = 3; t <= sqrt; t=t+2)
		{
			if (i % t == 0)
			{
				return false;
			}			
		}
		return i != 1;
	}
	
	public static async Task<TResult> MapAsync<TSource, TResult>(
		this Task<TSource> @this,
		Func<TSource, Task<TResult>> fn)
			=> await fn(await @this);

	public static PatternMatchContext<TIn> Match<TIn>(
		this TIn value)
	{
		return new PatternMatchContext<TIn>(value);
	}

	public static string ConvertNflTeam(string teamName)
	{
		if (teamName == "San Francisco 49ers")
			return "SF";
		if (teamName == "New Orleans Saints")
			return "NO";
		if (teamName == "Green Bay Packers")
			return "GB";
		if (teamName == "Philadelphia Eagles")
			return "PE";
		if (teamName == "Kansas City Chiefs")
			return "KC";
		if (teamName == "Houston Texans")
			return "HT";
		if (teamName == "Baltimore Ravens")
			return "BR";
		if (teamName == "New England Patriots")
			return "NE";
		if (teamName == "Denver Broncos")
			return "DB";
		if (teamName == "Buffalo Bills")
			return "BB";
		if (teamName == "Tennessee Titans")
			return "TT";
		if (teamName == "Minnesota Vikings")
			return "MV";
		if (teamName == "Las Vegas Raiders")
			return "OR";
		if (teamName == "Seattle Seahawks")
			return "SS";
		if (teamName == "Pittsburgh Steelers")
			return "PS";
		if (teamName == "Dallas Cowboys")
			return "DC";
		if (teamName == "Detroit Lions")
			return "DL";
		if (teamName == "Carolina Panthers")
			return "CP";
		if (teamName == "Los Angeles Rams")
			return "LR";
		if (teamName == "New York Jets")
			return "NJ";
		if (teamName == "Cleveland Browns")
			return "CL";
		if (teamName == "Indianapolis Colts")
			return "IC";
		if (teamName == "Los Angeles Chargers")
			return "LC";
		if (teamName == "New York Giants")
			return "NG";
		if (teamName == "Chicago Bears")
			return "CH";
		if (teamName == "Atlanta Falcons")
			return "AF";
		if (teamName == "Miami Dolphins")
			return "MD";
		if (teamName == "Cincinnati Bengals")
			return "CI";
		if (teamName == "Jacksonville Jaguars")
			return "JJ";
		if (teamName == "Washington Redskins")
			return "WR";
		if (teamName == "Tampa Bay Buccaneers")
			return "TB";
		if (teamName == "Arizona Cardinals")
			return "AC";
		return teamName;
	}
	public static string ConvertNflCode(string teamCode)
	{
		if (teamCode == "SF")
			return "San Francisco 49ers";
		if (teamCode == "NO")
			return "New Orleans Saints";
		if (teamCode == "GB")
			return "Green Bay Packers";
		if (teamCode == "PE")
			return "Philadelphia Eagles";
		if (teamCode == "KC")
			return "Kansas City Chiefs";
		if (teamCode == "HT")
			return "Houston Texans";
		if (teamCode == "BR")
			return "Baltimore Ravens";
		if (teamCode == "NE")
			return "New England Patriots";
		if (teamCode == "DB")
			return "Denver Broncos";
		if (teamCode == "BB")
			return "Buffalo Bills";
		if (teamCode == "TT")
			return "Tennessee Titans";
		if (teamCode == "MV")
			return "Minnesota Vikings";
		if (teamCode == "OR")
			return "Las Vegas Raiders";
		if (teamCode == "SS")
			return "Seattle Seahawks";
		if (teamCode == "PS")
			return "Pittsburgh Steelers";
		if (teamCode == "DC")
			return "Dallas Cowboys";
		if (teamCode == "DL")
			return "Detroit Lions";
		if (teamCode == "CP")
			return "Carolina Panthers";
		if (teamCode == "LR")
			return "Los Angeles Rams";
		if (teamCode == "NJ")
			return "New York Jets";
		if (teamCode == "CL")
			return "Cleveland Browns";
		if (teamCode == "IC")
			return "Indianapolis Colts";
		if (teamCode == "LC")
			return "Los Angeles Chargers";
		if (teamCode == "NG")
			return "New York Giants";
		if (teamCode == "CH")
			return "Chicago Bears";
		if (teamCode == "AF")
			return "Atlanta Falcons";
		if (teamCode == "MD")
			return "Miami Dolphins";
		if (teamCode == "CI")
			return "Cincinnati Bengals";
		if (teamCode == "JJ")
			return "Jacksonville Jaguars";
		if (teamCode == "WR")
			return "Washington Redskins";
		if (teamCode == "TB")
			return "Tampa Bay Buccaneers";
		if (teamCode == "AC")
			return "Arizona Cardinals";
		return teamCode;
	}

}


public class PatternMatchContext<TIn>
{
	private readonly TIn _value;
	internal PatternMatchContext(TIn value)
	{
		_value = value;
	}

	public PatternMatchOnValue<TIn, TOut> With<TOut>(
		Predicate<TIn> condition,
		TOut result)
	{
		return new PatternMatchOnValue<TIn, TOut>(_value)
			.With(condition, result);
	}
}

public class PatternMatchOnValue<TIn, TOut>
{
	private readonly IList<PatternMatchCase> _cases =
		new List<PatternMatchCase>();
	private readonly TIn _value;
	private Func<TIn, TOut> _elseCase;
	internal PatternMatchOnValue(TIn value)
	{
		_value = value;
	}
	public PatternMatchOnValue<TIn, TOut> With(
		Predicate<TIn> condition,
		Func<TIn, TOut> result)
	{
		_cases.Add(
			new PatternMatchCase
			{
				Condition = condition,
				Result = result
			});
		return this;
	}

	public PatternMatchOnValue<TIn, TOut> With(
		Predicate<TIn> condition,
		TOut result)
	{
		return With(condition, x => result);
	}

	public PatternMatchOnValue<TIn, TOut> Else(
		Func<TIn, TOut> result)
	{
		if (_elseCase != null)
		{
			throw new InvalidOperationException(
			"Cannot have multiple else cases");
		}
		_elseCase = result;
		return this;
	}

	public PatternMatchOnValue<TIn, TOut> Else(
		TOut result)
	{
		return Else(x => result);
	}

	public TOut Do()
	{
		if (_elseCase != null)
		{
			With(x => true, _elseCase);
			_elseCase = null;
		}
		foreach (var test in _cases)
		{
			if (test.Condition(_value))
			{
				return test.Result(_value);
			}
		}
		throw new IncompletePatternMatchException();
	}

	private struct PatternMatchCase
	{
		public Predicate<TIn> Condition;
		public Func<TIn, TOut> Result;
	}
}

public class IncompletePatternMatchException : Exception
{
}

public static class StaticMeta 
{
	public static Meta GetMeta()
	{
		var decks = new List<Deck>();
		decks.Add(new Deck("Quest C'Thun", "AAECAea5AwTH3QO/4AP39gOcoAQN2cYD1tED3dMD+dUD8+MDlegD9fYDivcD9fgDmfkDs6AEtKAE7KAEAA==", 5));
		decks.Add(new Deck("Fel", "AAECAea5AwbDvAPQ3QOc7gON9wOZ+QOoigQM2cYDxd0D8+MDkOQDwvEDifcDjPcD9fgDg58Etp8E0p8E7KAEAA==", 5, "-1E Felgorger"));
		decks.Add(new Deck("Quest Druid", "AAECAZICBPXOA6P2A9j5A7CKBA2bzgPe0QPw1AOJ4AOK4AOi4QPR4QOM5AO27APR9gOA9wO4oAS5oAQA", 5, "-1 L Lost in the Park"));
		decks.Add(new Deck("Aggro Druid", "AAECAZICBqbhA9HhA/zoA/vtA9j5A6iKBAybzgO50gPw1AOM5AO57AOS7gOI9APJ9QOB9wOE9wOunwTWoAQA", 5, "-2E Composting, Oracle of Elune"));
		decks.Add(new Deck("Quest Hunter", "AAECAR8Gj+MD3OoD5e8D/fgD2PkDlPwDDILQA/7RA7nSA5boA5/sA9vtA83yA/f4A6mfBKqfBLqgBLugBAA=", 5, "-1L Defend the Dwarven District"));
		decks.Add(new Deck("Sword of a 1000 truths", "AAECAR8G1LoD5e8D5/AD2PkDqIoEvaAEDP+6A7nQA7nSA+rpA5/sA/DsA9vtA8j5A9P5A8T7A5T8A6mfBAA=", 5, "-1E Elwynn Boar"));
		decks.Add(new Deck("Quest Mage", "AAECAaoIBODMA5zOA67eA5egBA3buAOTuQPhzAPNzgPw1AOn3gOo3gOq3gOJ5APq5wONnwT5nwT+nwQA", 5, "-1L Sorcerer's Gambit"));
		decks.Add(new Deck("Fire Mage", "AAECAf0EBo27A+fwA7T3A7b3A9j5A6iKBAz4zAOFzQOk0QP30QPQ7AOn9wOu9wOy9wOz9wP0/AP8ngT9ngQA", 5, "-1L Astromancer Solarian"));
		decks.Add(new Deck("Quest Paladin", "AAECAZ8FCJXNA4feA/zoA+PrA7T2A9b5A9j5A6iKBAvKwQObzQOezQOi3gPM6wPN8gPw9gOV+QOuigTJoATKoAQA", 5, "-1L Rise to the Occasion"));
		decks.Add(new Deck("Handbuff Paladin", "AAECAZ8FCPy4A/voA5HsA6L4A9j5A9n5A6iKBKqKBAvKwQPK0QPM6wPj6wOH9APw9gPz9gON+AOq+APJoATWoAQA", 5, "-2E First Blade of Wrynn, Highlord Fordragon"));
		decks.Add(new Deck("Quest NZoth Priest", "AAECAa0GCsi+A5vYA/jjA/voA57rA9TtA/PuA6bvA932A6iKBAqTugOvugPLzQPXzgPj0QP+0QOW6AOa6wPN8gPM+QMA", 5, ""));
		decks.Add(new Deck("Shadow Priest", "AAECAa0GBMi+A8jvA7v3A9H5Aw3XzgPB0QPi3gP73wOW6AOb6wP08QOI9wOj9wOp9wOt9wPJ+QOtigQA", 5, "-1L Darkbishop Benedictus, -2E Voidtouched Attendant"));
		decks.Add(new Deck("Quest Rogue", "AAECAaIHBNnRA8PhA6P1A6b5Aw2qywPHzgOk0QPn3QPz3QOq6wOr6wOf9AOh9AOi9AOm9QP1nwT2nwQA", 5, "-1L Tenwu of the Red Smoke"));
		decks.Add(new Deck("Shuffle DR Rogue", "AAECAaIHBpXNA8fOA9nRA8PhA+fwA7CKBAyfzQPl3QPn3QPz3QOo6wOq6wOr6wPT8wON9AOO9APr9gP2nwQA", 5, "-1L Tenwu of the Red Smoke -1E Garrote"));
		decks.Add(new Deck("Evolve Shaman", "AAECAaoIBpzOA6beA/zoA9j5A4b6A7CKBAzbuAPduAPhuAOVzQPw1APc2wOp3gOq3gPj7gPj9gPG+QPJ+QMA", 5, "-1L Bolner Hammerbeak, -2E Tiny Toys"));
		decks.Add(new Deck("Bolner OTK Shaman", "AAECAaoICpPCA+HMA5zOA67SA/DUA/zeA9j5A4b6A6iKBP2fBArbuAOTuQOz3AOn3gOq3gPj7gPW9QPB9gPwhQTwoAQA", 5, "-2L Bolner Hammerbeak, Lurker Below"));
		decks.Add(new Deck("Quest Warlock", "AAECAf0GBPLtA4T7A4OgBJegBA2bzQPXzgOT5AOY6gPY7QPr7QPw7QPx7QOI7wOK7wO98QOD+wPnoAQA", 5, ""));
		decks.Add(new Deck("Handlock", "AAECAf0GBs/SA/jjA/LtA4f7A4OgBIWgBAysywO4zgPM0gPN0gP14wO98QPA+QPB+QPG+QP++gOC+wPnoAQA", 5, "-1L Anetheron"));
		decks.Add(new Deck("Quest Warrior", "AAECAQcIqtIDwd4Dle0D5/AD1fEDmPYDqIoEsIoEC7y5A/fUA4vVA7XeA47tA5X2A5b2A5f2A8/7A62gBK+gBAA=", 5, "-1L Raid the Docks"));
		decks.Add(new Deck("NZoth OTK Warrior", "AAECAQcMvrkD474D+cIDitADk9ADm9gDyOEDqu4Dj+8DlfYDzPkDiKAECbi5A82+A7beA8HeA4/tA9XxA5b2A/iABImgBAA=", 5, ""));
		return new Meta(
			"[[United in Stormwind]]",
			"US",
			decks);
	}
}



namespace Utes
{

	public class Meta
	{
		public string Name { get; set; }
		public string Tag { get; set; }
		public List<Deck> Decks { get; set; }
		public Meta(
			string name,
			string tag)
		{
			Name = name;
			Tag = tag;
		}
		public Meta(
			string name,
			string tag,
			List<Deck> decks)
		{
			Name = name;
			Tag = tag;
			Decks = decks;
		}
	}
	public class Deck
	{
		public string Name { get; set; }
		public string Code { get; set; }
		public int Tier { get; set; }
		public string Comments { get; set; }
		public Deck(
			string name,
			string code,
			int tier,
			string comments = "")
		{
			Name = name;
			Code = code;
			Tier = tier;
			Comments = comments;
		}
	}
	public class DateUte
	{
		public string IsEventDay(DateTime theDate)
		{
			var eventDay = string.Empty;
			eventDay = IsHoliday(theDate);
			//TODO: also look for birthdays and other special days
			return eventDay;
		}
		
		public string IsHoliday(DateTime printDate)
		{
			var theYear = printDate.Year;
			var theHoliday = string.Empty;
			if (printDate == new DateTime(theYear, 1, 1))
				theHoliday = "New Year's Day";
			if (printDate == new DateTime(theYear, 1, 26))
				theHoliday = "Australia Day";
			if (printDate == new DateTime(theYear, 2, 8))
				theHoliday = "Superbowl Day";
			if (printDate == new DateTime(theYear, 3, 8))
				theHoliday = "Canberra Day";
			if (printDate == new DateTime(theYear, 4, 2))
				theHoliday = "Good Friday";
			if (printDate == new DateTime(theYear, 4, 5))
				theHoliday = "Easter Monday";
			if (printDate == new DateTime(theYear, 4, 25))
				theHoliday = "Anzac Day Holiday";
			if (printDate == new DateTime(theYear, 5, 31))
				theHoliday = "Reconciliation Day";
			if (printDate == new DateTime(theYear, 6, 14))
				theHoliday = "Queen's Birthday";
			if (printDate == new DateTime(theYear, 10, 4))
				theHoliday = "Labour Day";
			if (printDate == new DateTime(theYear, 12, 27))
				theHoliday = "Christmas Day Holiday";
			if (printDate == new DateTime(theYear, 12, 28))
				theHoliday = "Boxing Day Holiday";
			return string.IsNullOrEmpty(theHoliday) ? string.Empty : $"{theHoliday}";
		}
	}
	public class LinqpadFile
	{
		public string FileName { get; set; }
		
		public LinqpadFile( string fileName)
		{
			FileName = fileName;
		}
		public string FileOut()
		{
			return $"{Environment.NewLine}* _{FileName}.linq_";
		}
	}
	public class WikiTable : WikiElement
	{
		public List<WikiColumn> Columns { get; set; }
		public Dictionary<int, string[]> RowData { get; set; }
		public WikiTable()
		{
			Columns = new List<Utes.WikiColumn>();
			RowData = new Dictionary<int, string[]>();
		}
		public override void Render()
		{
			RenderHeader();
			int rowNumber = 0;
			foreach (var row in RowData)
			{
				rowNumber++;
				RenderRow(rowNumber);
			}
			Console.WriteLine();
		}
		private void RenderRow(
			int rowNumber)
		{
			var sb = new StringBuilder();
			sb.Append("|");
			var rowData = RowData[rowNumber];
			var colNumber = 0;
			foreach (var col in Columns)
			{
				var cellValue = rowData[colNumber] ?? string.Empty;
				sb.AppendFormat("  {0}  |", cellValue.PadRight(MaxColWidth(col)));
				colNumber++;
			}
			Console.WriteLine(sb.ToString());
		}
		private void RenderHeader()
		{
			var sb = new StringBuilder();
			sb.Append( "|" );
			foreach (var col in Columns)
			{
				if (col.Header.Length > 0)
					col.Header = $"**{col.Header}**";
				sb.AppendFormat("  {0}  |",col.Header.PadRight(MaxColWidth(col)));
			}
			sb.AppendLine();
			sb.Append("|");
			foreach (var col in Columns)
			{
				sb.Append(" --- |");
			}
			Console.WriteLine(sb.ToString());
		}
		public void AddRows( int numberOfRows )
		{
			var existingRows = RowData.Count();
			for (int i = 1; i < numberOfRows+1; i++)
			{
				var arr =  new string[Columns.Count];
				for (int j = 0; j < Columns.Count; j++)
				{
					arr[j] = string.Empty;
				}
				RowData.Add( existingRows + i, arr );
			}
		}
		public void AddCell( 
			int row, 
			int col, 
			string cellValue )
		{
			var rowContents = RowData[row];
			rowContents[col] = cellValue;
			RowData[row] = rowContents;
		}
		private int MaxColWidth(WikiColumn col)
		{
			var max = col.Header.Length;
			var colNumber = ColumnNumber(col);
			for (int r = 1; r < RowData.Count + 1; r++)
			{
				var rowContents = RowData[r];
				var cell = rowContents[colNumber-1];
				if (!string.IsNullOrEmpty(cell))
				{
					if (cell.Length > max)
						max = cell.Length;
				}
			}
			return max;
		}
		private int ColumnNumber( WikiColumn col )
		{
			var colNumber = 0;
			foreach (var column in Columns)
			{
				colNumber++;
				if (col.Equals(column))
				{
					return colNumber;
				}
			}		
			return 1;
		}
		private int MaxColWidth(int colNumber)
		{
			var max = Column(colNumber).Header.Length;
			for (int r = 1; r < RowData.Count+1; r++)
			{
				var rowContents = RowData[r];
				var cell = rowContents[colNumber];
				if (cell.Length > max )
				   max = cell.Length;
			}
			return max;
		}
		private WikiColumn Column(int colNumber)
		{
			var colNo = 0;
			foreach (var col in Columns)
			{
				colNo++;
				if ( colNo.Equals(colNumber) )
				   return col;
			}	
			return new WikiColumn();
		}
	}
	public class WikiColumn
	{
		public string Header { get; set; }
		public WikiColumn()
		{
			Header = string.Empty;
		}
		public WikiColumn(
			string header)
		{
			Header = header;
		}
	}
	public class WikiPage
	{
		public List<WikiElement> Elements { get; set; }
		public string Title { get; set; }
		public WikiPage()
		{
			Elements = new List<WikiElement>();
		}
		public void AddElement(
			WikiElement element)
		{
			Elements.Add(element);
		}
		public void RenderToConsole()
		{
			foreach (var element in Elements)
			{
				element.Render();
			}
		}
		public void RenderToMarkdownFile()
		{
			var pageContents = PageContents();
			// determine title from H1
			Title = DetermineTitle();
			var filePath = $"d:\\Dropbox\\Obsidian\\ChestOfNotes\\{Title}.md";

			using (StreamWriter outputFile = new StreamWriter(filePath))
			{
				outputFile.WriteLine(pageContents);
			}
		}

		private string PageContents()
		{
			//TODO
			return string.Empty;
		}

		private string DetermineTitle()
		{
			var title = string.Empty;
			foreach (var element in Elements)
			{
				if (element.Type == "Heading")
				{
					title = element.Value;
				}
			}
			return title;
		}
	}
	public class WikiElement
	{
		public string Type { get; set; }
		public string Value { get; set; }
		public virtual void Render()
		{		
		}
	}
	public class WikiLine : WikiElement
	{
		public string LineText { get; set; }
		public WikiLine(
			string lineText)
		{
			Type = "Line";
			LineText = lineText;
		}
		public override void Render()
		{
			Console.WriteLine(LineText);
		}
	}
	public class WikiHorizontalRule : WikiElement
	{
		public override void Render()
		{
			Console.WriteLine("---");
		}
	}
	public class WikiHeading : WikiElement
	{
		public int Level { get; set; }
		public string HeaderText { get; set; }
		public WikiHeading(
			int level,
			string header)
		{
			Type = "Heading";
			HeaderText = header;
			Level = level;
			Value = header;
		}
		public override void Render()
		{
			Console.WriteLine($"{HeaderLevel(Level)} {HeaderText}");
			Console.WriteLine();
		}

		private string HeaderLevel(
			int level)
		{

			if (level == 1)
				return "#";
			if (level == 2)
				return "##";
			if (level==3)
				return "###";
			return "####";
		}
	}
	public class WikiBlank : WikiElement
	{
		public WikiBlank()
		{
			Type = "Blank-Line";
		}
		public override void Render()
		{
			Console.WriteLine();
		}
	}
	public class WikiBullet : WikiElement
	{
		public string Text { get; set; }
		public WikiBullet(
			string text)
		{
			Type = "Bullet";
			Text = text;
		}
		public override void Render()
		{
			Console.WriteLine($" * {Text}");
		}
	}
	public class WikiBulletList : WikiElement
	{
		public string[] Bullets { get; set; }
		public WikiHeading Header { get; set; }
		public WikiBulletList(
			string[] bullets,
			WikiHeading header)
		{
			Type = "BulletList";
			Bullets = bullets;
			Header = header;
		}
		public override void Render()
		{
			if (Header != null )
			{
				Header.Render();
			}
			foreach (var bullet in Bullets)
			{
				Console.WriteLine($" * {bullet}");
			}
			Console.WriteLine();
		}
	}
	public class WikiThreading : WikiElement
	{
		public string BackLink { get; set; }
		public string ForwardLink { get; set; }
		public LinqpadFile LinqFile { get; set; }
		
		public WikiThreading(
			string backLink,
			string forwardLink,
			string fileName = "")
		{
			Type = "Threading";
			BackLink = backLink;
			ForwardLink = forwardLink;
			if (!string.IsNullOrEmpty(fileName))
				LinqFile = new LinqpadFile(fileName);
		}
		public override void Render()
		{
			Console.WriteLine();
			Console.WriteLine("---");
			Console.WriteLine($"<< [[{BackLink}]] (m) [[{ForwardLink}]] >>");
			if (LinqFile != null)
			{
				Console.WriteLine();
				Console.WriteLine(LinqFile.FileOut());
				Console.WriteLine();
			}
		}
	}
}



namespace Gridstats
{

	public class RosterContext
	{
		public int LosingPoints { get; set; }
		public int Protect { get; set; }
		public int RunBlock { get; set; }
		public int PassRush { get; set; }
		public int PassDefence { get; set; }
		public int RunDefence { get; set; }
	}
	
	public class TurnSheet
	{
		public Round Round { get; set; }
		public int[] OldStarters { get; set; }
		public int[] OldBackups { get; set; }
		public int[] Starters { get; set; }
		public int[] Backups { get; set; }
		public List<SpecialAction> Actions { get; set; }
		public List<FreeAgentBid> Bids { get; set; }
		public RosterService.IRosterService RosterService { get; set; }
		public RosterContext RosterContext { get; set; }
		public List<int> HoldoutPlayers { get; set; }
		public int[] WeeksThatCount { get; set; }
		public Dictionary<int, List<GameLogService.Model.GameStats>> PlayerStats { get; set; }
		public bool IsRetro { get; set; }
		public string TeamCode { get; set; }
		public int[] SkipWeeks { get; set; }		

		public TurnSheet(
			Round round,
			RosterService.IRosterService rosterService,
			RosterContext rosterContext,
			(int[], int[]) oldLineup,
			bool isRetro = false,
			int[] skipWeeks = null
			)
		{
			PlayerStats = new Dictionary<int, List<GameLogService.Model.GameStats>>();
			OldStarters = oldLineup.Item1;
			Starters = new int[] { 0, 0, 0, 0, 0, 0, 0 };
			OldBackups = oldLineup.Item2;
			Backups = new int[] { 0, 0, 0, 0, 0, 0, 0 };
			Round = round;
			RosterService = rosterService;
			IsRetro = isRetro;
			TeamCode = isRetro ? "CD": "CL";
			SkipWeeks = skipWeeks;
		}

		public string ToMarkdown(string teamName)
		{
			var sb = new StringBuilder();
			sb.Append(Header(teamName));
			sb.Append(RosterDump());
			if (IsRetro)
				sb.Append(RosterDump("DD"));			
			sb.Append(RosterCounts());
			sb.Append(Tips());
			sb.Append(Lineup());
			sb.Append(FreeAgentBids());
			sb.Append(SpecialActions(IsRetro));
			sb.Append(ValidationErrors(this));
			sb.Append(Threading());
			sb.AppendLine();
			sb.AppendLine();
			sb.AppendLine(LinqFile());
			return sb.ToString();
		}

		private string LinqFile()
		{
			if (IsRetro)
				return "[[RetroTurnSheet.linq]]";
			return "[[GridstatsTurnsheet.linq]]";
		}

		private string RosterCounts()
		{
			var rosterCounts = new RosterCounts();
			var roster = RosterService.GetRoster(
				TeamCode);
			foreach (var plyr in roster)
			{
				rosterCounts.Increase(
					PositionOf(plyr));
			}
			return rosterCounts.RosterCountsOut();
		}

		private string RosterDump(string teamCode = "CL")
		{
			var sb = new StringBuilder();
			sb.AppendLine("```");
			sb.AppendLine(
				RosterService.RosterDump(
					teamCode: teamCode,
					toConsole: false,
					positionFilter: "",
					SkipWeeks));
			sb.AppendLine("```");
			return sb.ToString();
		}

		private string Threading()
		{
			var sb = new StringBuilder();
			sb.AppendLine();
			sb.AppendLine("---");
			sb.Append($"<< {Round.PreviousTurn(TeamCode)} (m) {Round.NextTurn(TeamCode)} >>");
			return sb.ToString();
		}

		public TurnSheet Merchandising(
			int amount,
			string rationale = "")
		{
			if (Actions is null)
				Actions = new List<SpecialAction>();
			Actions.Add(
				new SpecialAction
				{
					ActionType = "MERC",
					LosingPoints = amount.ToString(),
					Rationale = rationale + "<br> on win, reduce MERC by 10% but add Y of double that amt; 5,4,3,2,1"
				});
			return this;
		}

		public TurnSheet Marketing(
			int amount,
			string rationale = "")
		{
			if (Actions is null)
				Actions = new List<SpecialAction>();
			Actions.Add(
				new SpecialAction
				{
					ActionType = "MARK",
					LosingPoints = amount.ToString(),
					Rationale = rationale + " <br> earn sq root of amt <br> halved at end of season"
				});
			return this;
		}

		public TurnSheet Waive(
			int playerNumber,
			string rationale = "")
		{
			if (Actions is null)
				Actions = new List<SpecialAction>();
			Actions.Add(
				new SpecialAction
				{
					ActionType = "WAIVE",
					PlayerNum = playerNumber,
					Rationale = rationale
				});
			return this;
		}

		public TurnSheet Contract(
			int playerNumber,
			int newLpValue,
			string rationale = "")
		{
			if (Actions is null)
				Actions = new List<SpecialAction>();
			Actions.Add(
				new SpecialAction
				{
					ActionType = "CONTRACT",
					PlayerNum = playerNumber,
					LosingPoints = newLpValue.ToString(),
					Rationale = rationale
				});
			return this;
		}

		public TurnSheet Fast(
			int playerNumber,
			int lp = 1,
			string rationale = "")
		{
			if (Actions is null)
				Actions = new List<SpecialAction>();
			Actions.Add(
				new SpecialAction
				{
					ActionType = "FAST",
					PlayerNum = playerNumber,
					LosingPoints = lp.ToString(),
					Rationale = rationale
				});
			return this;
		}

		public TurnSheet Poach(
			int playerNumber,
			int lp = 0,
			string rationale = "")
		{
			if (Actions is null)
				Actions = new List<SpecialAction>();
			Actions.Add(
				new SpecialAction
				{
					ActionType = "POACH",
					PlayerNum = playerNumber,
					LosingPoints = lp.ToString(),
					Rationale = rationale
				});
			return this;
		}

		public TurnSheet Key(
			int playerNumber,
			string rationale = "")
		{
			if (Actions is null)
				Actions = new List<SpecialAction>();
			Actions.Add(
				new SpecialAction
				{
					ActionType = "KEY",
					PlayerNum = playerNumber,
					Rationale = rationale
				});
			return this;
		}

		public TurnSheet Coverage(
			string rationale = "")
		{
			if (Actions is null)
				Actions = new List<SpecialAction>();
			Actions.Add(
				new SpecialAction
				{
					ActionType = "COVERAGE",
					Rationale = rationale
				});
			return this;
		}

		public TurnSheet Stuff(
			string rationale = "")
		{
			if (Actions is null)
				Actions = new List<SpecialAction>();
			Actions.Add(
				new SpecialAction
				{
					ActionType = "STUFF",
					Rationale = rationale
				});
			return this;
		}

		public TurnSheet AddAction(
			string actionType,
			int playerNumber,
			int lp = 0,
			string rationale = "")
		{
			if (Actions is null)
				Actions = new List<SpecialAction>();
			Actions.Add(
				new SpecialAction
				{
					ActionType = actionType,
					PlayerNum = playerNumber,
					LosingPoints = lp.ToString(),
					Rationale = rationale
				});
			return this;
		}

		public TurnSheet Q1(
			int playerNumber)
		{
			Starters[0] = playerNumber;
			return this;
		}

		public TurnSheet Q2(
			int playerNumber)
		{
			Backups[0] = playerNumber;
			return this;
		}

		//  RB starter 1
		public TurnSheet A1(
		int playerNumber)
		{
			Starters[1] = playerNumber;
			return this;
		}


		public TurnSheet A2(
			int playerNumber)
		{
			Backups[1] = playerNumber;
			return this;
		}

		//  RB starter 2
		public TurnSheet B1(
		int playerNumber)
		{
			Starters[2] = playerNumber;
			return this;
		}

		public TurnSheet B2(
			int playerNumber)
		{
			Backups[2] = playerNumber;
			return this;
		}

		public TurnSheet X1(
			int playerNumber)
		{
			Starters[3] = playerNumber;
			return this;
		}

		public TurnSheet X2(
			int playerNumber)
		{
			Backups[3] = playerNumber;
			return this;
		}

		public TurnSheet Y1(
			int playerNumber)
		{
			Starters[4] = playerNumber;
			return this;
		}

		public TurnSheet Y2(
			int playerNumber)
		{
			Backups[4] = playerNumber;
			return this;
		}

		public TurnSheet Z1(
			int playerNumber)
		{
			Starters[5] = playerNumber;
			return this;
		}

		public TurnSheet Z2(
			int playerNumber)
		{
			Backups[5] = playerNumber;
			return this;
		}

		public TurnSheet K1(
			int playerNumber)
		{
			Starters[6] = playerNumber;
			return this;
		}

		public TurnSheet K2(
			int playerNumber)
		{
			Backups[6] = playerNumber;
			return this;
		}

		public TurnSheet Bid(
			int playerNumber,
			int lp = 14,
			string rationale = "his wages are too high")
		{
			if (Bids is null)
				Bids = new List<FreeAgentBid>();
			Bids.Add(
				new FreeAgentBid
				{
					PlayerNum = playerNumber,
					Bid = lp,
					Rationale = rationale
				});
			return this;
		}

		public TurnSheet Bid(
			string surname,
			string forename,
			string teamCode,
			int lp = 14,
			string rationale = "his wages are too high")
		{
			if (Bids is null)
				Bids = new List<FreeAgentBid>();
			Bids.Add(
				new FreeAgentBid
				{
					Surname = surname,
					Forename = forename,
					TeamCode = teamCode,
					Bid = lp,
					Rationale = rationale
				});
			return this;
		}

		public TurnSheet Rebid(
			int playerNumber,
			int lp = 14,
			string rationale = "his wages are too high")
		{
			if (Actions is null)
				Actions = new List<SpecialAction>();
			if (Bids is null)
				Bids = new List<FreeAgentBid>();
			Bids.Add(
				new FreeAgentBid
				{
					ReBid = true,
					PlayerNum = playerNumber,
					Bid = lp,
					Rationale = rationale
				});
			Actions.Add(
				new SpecialAction
				{
					ActionType = "WAIVE",
					PlayerNum = playerNumber,
					Rationale = rationale
				});
			return this;
		}

		private string ValidationErrors(
			TurnSheet currentTurn)
		{
			var sb = new StringBuilder();
			var errors = new List<ValidationError>();

			foreach (var sa in Actions)
				sa.Validate(
					errors,
					RosterService,
					TeamCode);
			if (Bids != null)
			{
				foreach (var bid in Bids)
					bid.Validate(
						errors,
						RosterService,
						currentTurn);
			}
			ValidateRosterLimits(
				errors,
				RosterService);
			ValidateLineup(
				errors,
				RosterService);
			if (errors.Any())
				OutputErrors(sb, errors);
			return sb.ToString();
		}

		void ValidateLineup(
			List<ValidationError> errors,
			RosterService.IRosterService rosterService)
		{
			var seconds = SecondsLineup();
			foreach (var s in StartingLineup())
			{
				if (s == 0)
					continue;
				if (seconds.Contains(s))
					errors.Add(
						new ValidationError
						{
							Message = $"Player {s} in multiple spots"
						});
			}
		}

		private void ValidateRosterLimits(
			List<ValidationError> errors,
			RosterService.IRosterService rosterService)
		{
			var rosterCounts = new RosterCounts();
			var roster = rosterService.GetRoster(
				TeamCode);
			foreach (var plyr in roster)
			{
				rosterCounts.Increase(
					PositionOf(plyr));
			}
			var actionCount = 0;
			foreach (var act in Actions)
			{
				if (actionCount == 6)
					break;
				var player = rosterService.GetPlayer(
					act.PlayerNum.ToString());
				if (act.ActionType.Equals("WAIVE"))
					rosterCounts.Decrease(player.Position);
				if (act.ActionType.Equals("FAST"))
					rosterCounts.Increase(player.Position);
				actionCount++;
			}
			if (rosterCounts.Get("TOT") > 20)
				errors.Add(
					new ValidationError
					{
						Message = "Roster limit exceeded"
					});
			var wrCount = rosterCounts.Get("WR");
			var teCount = rosterCounts.Get("TE");
			if ( wrCount + teCount < 6)
				errors.Add(
					new ValidationError
					{
						Message = $"Not enough Receivers, after actions - WR:{wrCount} TE:{teCount}"
					});
			if (rosterCounts.Get("RB") < 4)
				errors.Add(
					new ValidationError
					{
						Message = "Not enough RBs"
					});
			if (rosterCounts.Get("QB") < 2)
				errors.Add(
					new ValidationError
					{
						Message = "Not enough QBs"
					});
			if (rosterCounts.Get("KK") < 2)
				errors.Add(
					new ValidationError
					{
						Message = "Not enough Kickers"
					});
		}

		string PositionOf(string plyr)
		{
			var part = plyr.Split(
				new Char[] { ' ' },
				StringSplitOptions.RemoveEmptyEntries);
			return part[1];
		}

		string IdOf(string plyr)
		{
			var part = plyr.Split(
				new Char[] { ' ' },
				StringSplitOptions.RemoveEmptyEntries);
			return part[0];
		}

		private void OutputErrors(
			StringBuilder sb,
			List<ValidationError> errors)
		{
			sb.AppendLine();
			sb.Append(H2("Validation Messages"));
			sb.AppendLine();
			foreach (var err in errors)
				sb.AppendLine($"- {err.Message}");
		}

		private string Lineup()
		{
			var sb = new StringBuilder();
			sb.Append(H2("Lineup"));
			sb.AppendLine();
			sb.AppendLine("Starters (1-7):");
			sb.Append(" - ");
			for (int i = 0; i < 7; i++)
			{
				sb.Append($"[  {OldStarters[i],3}  ]   ");
			}
			sb.AppendLine();
			sb.Append(" - ");
			for (int i = 0; i < 7; i++)
			{
				sb.Append($"[  {NewStarter(i)}  ]   ");
			}
			sb.AppendLine();
			sb.AppendLine();

			if (IsRetro) DumpLineup(sb, StarterNumber, StarterName, true);

			sb.AppendLine();
			sb.AppendLine("Backups (8-14):");
			sb.Append(" - ");
			for (int i = 0; i < 7; i++)
			{
				sb.Append($"[  {OldBackups[i],3}  ]   ");
			}
			sb.AppendLine();
			sb.Append(" - ");
			for (int i = 0; i < 7; i++)
			{
				sb.Append($"[  {NewBackup(i)}  ]   ");
			}
			sb.AppendLine();
			sb.AppendLine();

			if (IsRetro) DumpLineup(sb, BackupNumber, BackupName, false);

			if (IsRetro) Scores(sb);

			return sb.ToString();
		}

		void Scores(StringBuilder sb)
		{
			var starters = StartingLineup();
			var backups = SecondsLineup();
			sb.Append($"|       Projected Scores           |");
			foreach (var w in WeeksThatCount)
			{
				var tdp = StatsFor(starters[0], w).PassingTds;
				var tdc = 0;
				var tds = 0;
				for (int i = 0; i < 6; i++)
				{
					// catches by slot
					var tdcByRec = StatsFor(starters[i], w).ReceivingTds;
					if (tdcByRec == 0)
						tdcByRec = StatsFor(backups[i], w).ReceivingTds;
					tdc += tdcByRec;
					if (tdc == tdp)
						break;
				}
				var passingPoints = tdp * 6;
				tds += tdp;
				var totTdr = 0;
				for (int i = 0; i < 6; i++)
				{
					// runs by slot
					var tdr = StatsFor(starters[i], w).RushingTds;
					if (tdr == 0)
						tdr = StatsFor(backups[i], w).RushingTds;
					totTdr += tdr;
				}
				var rushingPoints = totTdr * 6;
				tds += totTdr;
				var kickingPoints = StatsFor(starters[6], w).FieldGoalsMade * 3;
				var pats = Math.Min(tds, StatsFor(starters[6], w).ExtraPointsMade);
				kickingPoints += pats;
				sb.Append($"     {passingPoints + rushingPoints + kickingPoints,2}    |");
			}
			sb.AppendLine();
		}

		private GameLogService.Model.GameStats StatsFor(
			int playerId, 
			int week)
		{
			var gameStats = PlayerStats[playerId];
			return gameStats.Where(s => s.Week == week).FirstOrDefault();
		}

		void DumpLineup(
			StringBuilder sb,
			Func<int, int> playerFn,
			Func<int, string> playerNameFn,
			bool starters)
		{
			AddTableHeader(sb);
			for (int i = 0; i < 7; i++)
			{
				var playerId = playerFn(i);
				var stats = RosterService.GetStats(
					playerId,
					Round.Season,
					WeeksThatCount);
				SaveStats(playerId, stats);
				sb.Append($"|  {PosSpot(i, starters)} | {playerNameFn(i).PadRight(25)}  |");
				foreach (var w in WeeksThatCount)
				{
					var stat = stats.Where(s => s.Week == w).FirstOrDefault();
					if (i == 0)
						sb.Append($"    {stat.PassingTds,3}    |");
					if (i == 1 || i == 2)
						sb.Append($"    {stat.RushingTds,3}    |");
					if (i == 3 || i == 4 || i == 5)
						sb.Append($"    {stat.ReceivingTds,3}    |");
					if (i == 6)
						sb.Append($"  {stat.FieldGoalsMade,2} / {stat.ExtraPointsMade,2}  |");
				}
				sb.AppendLine();
			}
			sb.AppendLine();
		}

		string PosSpot(int i, bool starters)
		{
			var spot = "Q";
			var side = 1;
			if (!starters)
				side = 2;
			if (i == 1)
				spot = "A";
			if (i == 2)
				spot = "B";
			if (i == 3)
				spot = "X";
			if (i == 4)
				spot = "Y";
			if (i == 5)
				spot = "Z";
			if (i == 6)
				spot = "K";
			return $"{spot}{side}";
		}

		void SaveStats(int playerId, List<GameLogService.Model.GameStats> stats)
		{
			PlayerStats[playerId] = stats;
		}

		void AddTableHeader(StringBuilder sb)
		{
			sb.Append("|     | Player                     |");
			foreach (var w in WeeksThatCount)
			{
				sb.Append($"   Wk {w:0#}   |");
			}
			sb.AppendLine();
			sb.Append("| --- | -------------------------- |");
			foreach (var w in WeeksThatCount)
			{
				sb.Append($" --------  |");
			}
			sb.AppendLine();
		}

		public int[] StartingLineup()
		{
			var lineup = new int[] { 0, 0, 0, 0, 0, 0, 0 };
			for (int i = 0; i < 7; i++)
			{
				lineup[i] = Starters[i] > 0 ? Starters[i] : OldStarters[i];
			}
			return lineup;
		}

		public int[] SecondsLineup()
		{
			var lineup = new int[] { 0, 0, 0, 0, 0, 0, 0 };
			for (int i = 0; i < 7; i++)
			{
				lineup[i] = Backups[i] > 0 ? Backups[i] : OldBackups[i];
			}
			return lineup;
		}

		private string BackupName(
			int i)
		{
			if (Backups[i] > 0)
				return $"{PlayerOut(Backups[i])}";
			if (OldBackups[i] > 0)
				return $"{PlayerOut(OldBackups[i])}";
			return "   ";
		}

		private int BackupNumber(int i)
		{
			if (Backups[i] > 0)
				return Backups[i];
			if (OldBackups[i] > 0)
				return OldBackups[i];
			return 0;
		}

		private string StarterName(int i)
		{
			if (Starters[i] > 0)
				return $"{PlayerOut(Starters[i])}";
			if (OldStarters[i] > 0)
				return $"{PlayerOut(OldStarters[i])}";
			return "   ";
		}

		private int StarterNumber(int i)
		{
			if (Starters[i] > 0)
				return Starters[i];
			if (OldStarters[i] > 0)
				return OldStarters[i];
			return 0;
		}

		private string PlayerOut(int id)
		{
			return $"{id,3} {PlayerName(id)}";
		}

		private string NewStarter(int i)
		{
			if (Starters[i] > 0)
				return $"{Starters[i],3}";
			return "   ";
		}

		private string NewBackup(int i)
		{
			if (Backups[i] > 0)
				return $"{Backups[i],3}";
			return "   ";
		}

		private string SpecialActions(
			bool isRetro)
		{
			var sb = new StringBuilder();
			sb.Append(H2("Special Actions"));
			sb.AppendLine();
			sb.AppendLine("|  **Action**  | **LP Amt** | **Plr Num** | **Player** | **Comment** |");
			sb.AppendLine("| :----------- | ---------- | ----------- | ---------- | ----------- |");
			var actionCount = 0;
			foreach (var sa in Actions)
			{
				var rationale = sa.Rationale;
				if (!string.IsNullOrEmpty(sa.PlayerNumOut()))
					rationale += $" {PlayerCfo(sa,isRetro)}";
				if (sa.LosingPoints == "0")
					sa.LosingPoints = string.Empty;
				if (actionCount == 5)
					sb.AppendLine("|              |            |             |                    |             |");
				sb.AppendLine(
					$@"| {
					sa.ActionType,-12
					} |     {
					sa.LosingPointsOut(),3
					}    |     {
					sa.PlayerNumOut()
					}     |  {PlayerName(sa),-17} | {
					rationale
					} |");
				actionCount++;
			}
			return sb.ToString();
		}

		private string PlayerName(int id)
		{
			return RosterService.GetPlayer(
				id.ToString())
				.Name;
		}

		private string PlayerName(SpecialAction sa)
		{
			if (!sa.IsPlayerRelated())
				return string.Empty;
			var player = RosterService.GetPlayer(
				sa.PlayerNum.ToString());
			var result = player.Name;
			if (sa.ActionType == "POACH")
			   result += $" ({RosterService.GetOwnerOf(player.Name)})";
			return result;
		}

		private string PlayerCfo(
			SpecialAction sa, 
			bool isRetro)
		{
			if (!sa.IsPlayerRelated() || !isRetro)
				return string.Empty;
			var player = RosterService.GetPlayer(
				sa.PlayerNum.ToString());
			RosterService.TallyPlayer(player, "1988", "1989");
			return $"({player.CurrentScores,2}-{player.FutureScores,2})";
		}

		private string FreeAgentBids()
		{
			if (Bids is null)
				return string.Empty;
			var sb = new StringBuilder();
			sb.Append(H2("Free Agent Bids"));
			sb.AppendLine();
			foreach (var bid in Bids)
			{
				sb.AppendLine(bid.BidLine(RosterService, IsRetro));
				sb.AppendLine();
			}
			if (BlankBids() > 0)
			{
				var blankBid = new FreeAgentBid();
				for (int i = 0; i < BlankBids(); i++)
				{
					sb.AppendLine(blankBid.BidLine(RosterService, IsRetro));
					sb.AppendLine();
				}
			}
			return sb.ToString();
		}

		private int BlankBids()
		{
			var blanks = 2 - Bids.Count();
			if (blanks < 1)
				return 0;
			return blanks;
		}


		private string Tips()
		{
			var sb = new StringBuilder();
			sb.Append(H2("Tips"));
			sb.AppendLine();
			AddAdvice(sb);
			sb.AppendLine($"Total Events: {RosterService.GetEventCount()}");
			return sb.ToString();
		}

		void AddAdvice(
			StringBuilder sb)
		{
			if (Round.WeekCode.Equals("P01") || Round.WeekCode.Equals("P02"))
			{
				sb.AppendLine($"- Re-Bid Overpaid players (wont have them in WK 01)");
				sb.AppendLine($"- Fast/Bid the good Free Agents");
				sb.AppendLine($"- Poach Undervalued Players from other teams - see [[Gridstats Retro Poachables]]");
				sb.AppendLine($"- Cut High Salary Players unless they are STARS");
				sb.AppendLine($"- cut roster size down to 15");
				sb.AppendLine($"- Cut non-contributors");
				sb.AppendLine($"- Dont worry about result its Pre-season");
				if (!IsRetro)
				{
					sb.AppendLine($"- get the rookie RBs ");
					sb.AppendLine($"- get the rookie PKs ");					
					sb.AppendLine($"- Fast Starting Free Agents on Playoff quality teams");
					if (Round.WeekCode.Equals("P02"))
						sb.AppendLine($"- Rebid players will be unavailable in Week 1");					
				}
			}
			if (Round.WeekCode.Equals("W01") || Round.WeekCode.Equals("W02"))
			{
				sb.AppendLine($"- use ur coaching before the AI catches up");
				sb.AppendLine($"- cut roster size down to 15");
				sb.AppendLine($"- Cut non-contributors");
				sb.AppendLine($"- Poach Undervalued Players from other teams");
				sb.AppendLine($"- Fast/Bid the good Free Agents");
			}
			if (IsRetro)
			{
				sb.AppendLine(QuarterBackSuggestion());
				sb.AppendLine(RunningBackSuggestions());
				sb.AppendLine(WideReceiverSuggestions());
				sb.AppendLine(KickerSuggestions());
			}
		}
		string QuarterBackSuggestion()
		{
			var sb = new StringBuilder();
			var roster = RosterService.GetRoster(
				TeamCode);
			var possibleWRs = new List<RosterService.Player>();
			foreach (var plyr in roster)
			{
				if (PositionOf(plyr) == "QB")
				{
					var player = RosterService.GetPlayer(
						IdOf(plyr));
					var stats = RosterService.GetStats(
						player.Id,
						Round.Season,
						WeeksThatCount);
					player.CurrentScores += stats.Sum(s => s.RushingTds)
										  + stats.Sum(s => s.ReceivingTds)
										  + stats.Sum(s => s.PassingTds);
					possibleWRs.Add(player);
				}
			}
			var query = possibleWRs
				.OrderByDescending(p => p.CurrentScores)
				.Take(1);
			sb.Append("- Top QB is ");
			foreach (var p in query)
			{
				sb.Append($"{p.Name} with {p.CurrentScores} scores ");
			}
			sb.AppendLine();
			return sb.ToString();
		}

		string RunningBackSuggestions()
		{
			var sb = new StringBuilder();
			var roster = RosterService.GetRoster(
				TeamCode);
			var possibleRBs = new List<RosterService.Player>();
			foreach (var plyr in roster)
			{
				if (PositionOf(plyr) == "RB")
				{
					var player = RosterService.GetPlayer(
						IdOf(plyr));
					var stats = RosterService.GetStats(
						player.Id,
						Round.Season,
						WeeksThatCount);
					player.CurrentScores += stats.Sum(s => s.RushingTds)
										  + stats.Sum(s => s.ReceivingTds)
										  + stats.Sum(s => s.PassingTds);
					possibleRBs.Add(player);
				}
			}
			var query = possibleRBs
				.OrderByDescending(p => p.CurrentScores)
				.Take(2);
			sb.Append("- Top 2 RBs are ");
			foreach (var p in query)
			{
				sb.Append($"{p.Name} with {p.CurrentScores} scores ");
			}
			sb.AppendLine();
			return sb.ToString();
		}

		string WideReceiverSuggestions()
		{
			var sb = new StringBuilder();
			var roster = RosterService.GetRoster(
				TeamCode);
			var possibleWRs = new List<RosterService.Player>();
			foreach (var plyr in roster)
			{
				if (PositionOf(plyr) == "WR" || PositionOf(plyr) == "TE")
				{
					var player = RosterService.GetPlayer(
						IdOf(plyr));
					var stats = RosterService.GetStats(
						player.Id,
						Round.Season,
						WeeksThatCount);
					player.CurrentScores += stats.Sum(s => s.RushingTds)
										  + stats.Sum(s => s.ReceivingTds)
										  + stats.Sum(s => s.PassingTds);
					possibleWRs.Add(player);
				}
			}
			var query = possibleWRs
				.OrderByDescending(p => p.CurrentScores)
				.Take(3);
			sb.Append("- Top 3 WRs are ");
			foreach (var p in query)
			{
				sb.Append($"{p.Name} with {p.CurrentScores} scores ");
			}
			sb.AppendLine();
			return sb.ToString();
		}

		string KickerSuggestions()
		{
			var sb = new StringBuilder();
			var roster = RosterService.GetRoster(
				TeamCode);
			var possibleWRs = new List<RosterService.Player>();
			foreach (var plyr in roster)
			{
				if (PositionOf(plyr) == "KK")
				{
					var player = RosterService.GetPlayer(
						IdOf(plyr));
					var stats = RosterService.GetStats(
						player.Id,
						Round.Season,
						WeeksThatCount);
					player.CurrentScores += stats.Sum(s => s.KickingPoints());
					possibleWRs.Add(player);
				}
			}
			var query = possibleWRs
				.OrderByDescending(p => p.CurrentScores)
				.Take(1);
			sb.Append("- Top K is ");
			foreach (var p in query)
			{
				sb.Append($"{p.Name} with {p.CurrentScores} pts ");
			}
			sb.AppendLine();
			return sb.ToString();
		}

		private string Header(string teamName)
		{
			return $"# [[{teamName} {Round.Season}]] {RoundOut()}{Environment.NewLine}";
		}

		private string H2(
			string header)
		{
			return $"{Environment.NewLine}## {header}{Environment.NewLine}";
		}

		private string RoundOut()
		{
			var roundType = "Week";
			if (Round.WeekCode.StartsWith("P"))
				roundType = "Pre";
			return $"{roundType} {Round.WeekCode.Substring(1, 2)}";
		}

		public TurnSheet Holdouts(params int[] holdouts)
		{
			if (HoldoutPlayers is null)
				HoldoutPlayers = new List<int>();
			foreach (var ho in holdouts)
			{
				HoldoutPlayers.Add(ho);
			}
			return this;
		}

		public TurnSheet WeeksUsed(params int[] weeks)
		{
			WeeksThatCount = weeks;
			return this;
		}
	}

	public class SpecialAction
	{
		public string ActionType { get; set; }
		public string LosingPoints { get; set; }
		public int PlayerNum { get; set; }
		public string Rationale { get; set; }

		internal bool IsPlayerRelated()
		{
			if (ActionType.Equals("WAIVE"))
				return true;
			if (ActionType.Equals("POACH"))
				return true;
			if (ActionType.Equals("FAST"))
				return true;
			if (ActionType.Equals("CONTRACT"))
				return true;
			return false;
		}

		internal string LosingPointsOut()
		{
			if (LosingPoints == "0")
				return string.Empty;
			return LosingPoints;
		}

		internal string PlayerNumOut()
		{
			if (PlayerNum == 0)
				return "   ";
			return $"{PlayerNum,3}";
		}

		internal void Validate(
			List<ValidationError> errors,
			RosterService.IRosterService rosterService,
			string teamCode)
		{
			if (ActionTypeIsOnRosteredPlayer())
			{
				var p = rosterService.GetPlayer(PlayerNum.ToString());
				if (rosterService.GetOwnerOf(
					p.Name) != teamCode)
				{
					errors.Add(
					   new ValidationError
					   {
						   Message = $"Player Num {PlayerNum} Not on the Roster!"
					   });
				}
			}
			if (ActionTypeIsOnFreeAgent())
			{
				var p = rosterService.GetPlayer(
					PlayerNum.ToString());
				if (rosterService.GetOwnerOf(
					p.Name) != "FA")
				{
					errors.Add(
					   new ValidationError
					   {
						   Message = $"Player Num {PlayerNum} is not a Free Agent!"
					   });
				}
			}
		}

		private bool ActionTypeIsOnFreeAgent()
		{
			if (ActionType.Equals("FAST"))
				return true;
			return false;
		}

		private bool ActionTypeIsOnRosteredPlayer()
		{
			if (ActionType.Equals("WAIVE"))
				return true;
			return false;
		}
	}

	public class RosterCounts
	{
		public Dictionary<string, int> PosCount { get; set; }

		public RosterCounts()
		{
			PosCount = new Dictionary<string, int>();
			PosCount.Add("QB", 0);
			PosCount.Add("RB", 0);
			PosCount.Add("WR", 0);
			PosCount.Add("TE", 0);
			PosCount.Add("KK", 0);
			PosCount.Add("TOT", 0);
		}

		internal void Decrease(string position)
		{
			if (string.IsNullOrEmpty(position))
				return;
			PosCount[position]--;
			PosCount["TOT"]--;
		}

		internal void Increase(string position)
		{
			if (string.IsNullOrEmpty(position) )
				return;
			PosCount[position]++;
			PosCount["TOT"]++;
		}

		internal void Set(string count, int value)
		{
			PosCount[count] = value;
		}

		internal int Get(string count)
		{
			return PosCount[count];
		}
		
		public string RosterCountsOut()
		{
			var sb = new StringBuilder();
			foreach (var element in PosCount)
			{
				sb.Append($"{element.Key}:{element.Value.ToString(),2} ");
			}
			sb.AppendLine();
			return sb.ToString();
		}
	}

	public class Round
	{
		public int Season { get; set; }
		public string WeekCode { get; set; }
		public Round(int season, string weekCode)
		{
			Season = season;
			WeekCode = weekCode;
		}

		internal bool IsAfter(Round round)
		{
			if (Season == 1988 && WeekCode == "P01")
				return false;
			return true;
		}

		internal string AsCode()
		{
			return $"{Season}:{WeekCode}";
		}

		internal string NextTurn(string teamCode)
		{
			var thePhase = WeekCode.Substring(0, 1);
			var nWeek = int.Parse(WeekCode.Substring(1, 2)) + 1;
			return $"[[{teamCode} {Season} {thePhase}{nWeek:0#}]]";
		}

		internal string PreviousTurn(string teamCode)
		{
			var thePhase = WeekCode.Substring(0, 1);
			var nWeek = int.Parse(WeekCode.Substring(1, 2)) - 1;
			if (nWeek == 0)
			{
				thePhase = "P";
				nWeek = 1;
			}

			return $"[[{teamCode} {Season} {thePhase}{nWeek:0#}]]";
		}
	}
	
	public class FreeAgentBid
	{
		public int PlayerNum { get; set; }
		public bool ReBid { get; set; }
		public int Bid { get; set; }
		public string Surname { get; set; }
		public string Forename { get; set; }
		public string TeamCode { get; set; }
		public string Rationale { get; set; }

		internal string BidLine(
			RosterService.IRosterService rosterService,
			bool isRetro)
		{
			var player = rosterService.GetPlayer(
				PlayerNum.ToString());
			if (string.IsNullOrEmpty(Forename))
				Forename = ForenameFrom(player.Name);
			if (string.IsNullOrEmpty(Surname))
				Surname = SurnameFrom(player.Name, Forename);
			if (string.IsNullOrEmpty(TeamCode))
				TeamCode = player.NflTeamCode;

			return $@"PLR [ {
				PlayerNumOut()
				} ]  BID [ {
				PlayerBidOut()
				} ]  SURNAME [ {
				Surname,-10
				} ]  FORENAME [ {
				Forename,-7
				} ]  TEAM [ {
				TeamCode,-2
				} ]{Environment.NewLine}- {
				Rationale
				} {PlayerCfo(player,rosterService,isRetro)}";
		}

		string PlayerCfo(
			RosterService.Player player,
			RosterService.IRosterService rosterService,
			bool isRetro)			
		{
			if (!isRetro)
				return string.Empty;
			rosterService.TallyPlayer(player, "1988", "1989");
			return $"({player.CurrentScores,2}-{player.FutureScores,2})";
		}

		string ForenameFrom(string name)
		{
			var part = name.Split(
				new Char[] { ' ' },
				StringSplitOptions.RemoveEmptyEntries);
			return part[0];
		}

		string SurnameFrom(string name, string forename)
		{
			return name.Replace(forename, "").Trim();
		}

		internal void Validate(
			List<ValidationError> errors,
			RosterService.IRosterService rosterService,
			TurnSheet turn)
		{
			if (!ReBid)
			{
				var playerName = $"{Forename} {Surname}";
				var owner = rosterService.GetOwnerOf(
					playerName);
				if (owner != "FA")
				{
					var msg = $"Warning: Possible Invalid BID: Player Num {PlayerNum} is not a Free Agent! (owned by {owner})";
					if (turn.HoldoutPlayers.Contains(PlayerNum))
						msg = $"BID OK Player Num {PlayerNum} is a holdout";
					errors.Add(
					   new ValidationError
					   {
						   Message = msg
					   });
				}
			}
		}

		private string PlayerNumOut()
		{
			if (PlayerNum.Equals(0))
				return "   ";
			return $"{PlayerNum,3}";
		}

		private string PlayerBidOut()
		{
			if (Bid.Equals(0))
				return "   ";
			return $"{Bid,3} ({OverBid(Bid)})";
		}

		private int OverBid(int bid)
		{
			var extra1 = bid % 2;
			return bid + (bid / 2) + extra1;
		}
	}

	public class ValidationError
	{
		public string Message { get; set; }
	}
}
#region Advanced - How to multi-target

// The NET5 symbol is active when the query runs on .NET 5 or later.

#if NET5
// Code that requires .NET 5 or later
#endif

#endregion