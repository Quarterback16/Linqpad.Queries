<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
  <Namespace>Utes</Namespace>
</Query>

var startDate = new DateTime(2021,2,1);

var page = new WikiPage();
page.AddElement(
	new WikiHeading(
		1,
		$"Spitzys League {PrintYear(startDate)}"));

page.AddElement(
	new WikiBulletList(
		new string[] {
			"[[Distillery League]]",
			"{Yahoo League link link goes here}",
			"{Sleeper Draft link goes here}",
			"[[Fantasy Lineup Strategies]]",
			},
			null));

page.AddElement(
	new WikiHeading(
		2,
		$"Weekly results for [[Spitzys League]] in [[Future Log {startDate.Year}|{startDate.Year}"));

AddResultsTable(
	page);

page.AddElement(
	new WikiHeading(
		2,
		"Post Mortem"));

page.AddElement(
	new WikiBlank());
	
page.AddElement(
	new WikiThreading(
		$"Spitzys League {PreviousYear(startDate)}",
		$"Spitzys League {NextYear(startDate)}",
		"Spitzys-League"));

page.RenderToConsole();	
}

void AddResultsTable(
	WikiPage page)
{
	var table = new WikiTable();
	table.Columns.Add(new Utes.WikiColumn("Week"));
	table.Columns.Add(new Utes.WikiColumn("Opponent"));
	table.Columns.Add(new Utes.WikiColumn("Result"));
	table.Columns.Add(new Utes.WikiColumn("vs All"));
	table.Columns.Add(new Utes.WikiColumn("Comments"));
	table.AddRows(16);  // one for each week
	for (int r = 0; r < 16; r++)
	{
		var theRow = r + 1;
		table.AddCell(
		   row: theRow,
		   col: 0,
		   cellValue: $"{theRow:0#}");
	}
	page.AddElement(
		table);
}

int WeekNumber(DateTime theDate)
{
	DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(theDate);
    if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
        theDate = theDate.AddDays(3);

    // Return the week of our adjusted day
    return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(
		theDate, 
		CalendarWeekRule.FirstFourDayWeek, 
		DayOfWeek.Monday);
}


string PrintYear(DateTime printDate)
{
	return printDate.ToString("yyyy");
}

string PrintDate(DateTime printDate)
{
	return printDate.ToString("yyyy-MM-dd");
}

string CurrentMonth(DateTime printDate)
{
	return printDate.ToString("yyyy-MM");
}

string PreviousYear(DateTime printDate)
{
	return printDate.AddYears(-1).ToString("yyyy");
}

string NextYear(DateTime printDate)
{
	return printDate.AddYears(1).ToString("yyyy");
}

string FirstTwoLetters( DateTime printDate )
{
   return printDate.ToString("D").Substring(0,2);
}

int DaysInMonth( DateTime theDate )
{
   var theYear = theDate.Year;
   var theMonth = theDate.Month;
   return DateTime.DaysInMonth(theYear,theMonth);