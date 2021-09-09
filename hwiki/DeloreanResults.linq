<Query Kind="Program">
  <Output>DataGrids</Output>
  <Namespace>Utes</Namespace>
</Query>

void Main()
{
	//  Generate a wiki table for tracking Fantasy Baseball results
	//  insert it into the Canberra Anomolies page
	
	var page = new WikiPage();
	DisplayDeckTable(
		page);
	page.RenderToConsole();
}

void DisplayDeckTable(
	WikiPage page)
{
	var weeksInSeason = 25;
	var startDate = new DateTime(2021,4,19);

	var table = new WikiTable();
	table.Columns.Add(new Utes.WikiColumn("Week"));
	table.Columns.Add(new Utes.WikiColumn("From"));
	table.Columns.Add(new Utes.WikiColumn("To"));
	table.Columns.Add(new Utes.WikiColumn("Place"));
	table.Columns.Add(new Utes.WikiColumn("Comments"));
	table.AddRows(
		weeksInSeason);  // one for each deck
	for (int r = 2; r < weeksInSeason; r++)
	{
		table.AddCell(
		   row: r + 1,
		   col: 0,
		   cellValue: (r+1).ToString());
		table.AddCell(
		   row: r + 1,
		   col: 1,
		   cellValue: FirstDateOut(r,startDate));
		table.AddCell(
		   row: r + 1,
		   col: 2,
		   cellValue: LastDateOut(r,startDate));
	}
	page.AddElement(
		table);
}

string FirstDateOut(
	int r, 
	DateTime startDate)
{
	var dateOut = startDate.AddDays((r - 2) * 7);
	return FormatDate(dateOut);
}

string LastDateOut(
	int r,
	DateTime startDate)
{
	var dateOut = startDate.AddDays(((r - 2) * 7) + 6);
	return FormatDate(dateOut);
}

string FormatDate(
   DateTime dateOut)
{
	return $"[[{dateOut.Year}-{dateOut.Month:0#}]]-{dateOut.Day:0#}";	   	
}

