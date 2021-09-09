<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
  <Namespace>Utes</Namespace>
</Query>

var startDate = new DateTime(2021,2,1);

var page = new WikiPage();
page.AddElement(
	new WikiHeading(
		1,
		$"[[NFL]] Season {PrintYear(startDate)}"));

page.AddElement(
	new WikiBulletList(
		new string[] {
			$"[[NFL Rookie Draft {startDate.Year}]]",
			$"Culminates in [[Super bowl {SuperbowlNumber(startDate)}]]",			
			},
			null));

page.AddElement(
	new WikiHeading(
		2,
		"Predictions"));

page.AddElement(
	new WikiBulletList(
		new string[] {
			$"[[Colonnas Comanches {startDate.Year}]]",
			$"[[San Francisco Forty Niners {startDate.Year}]]",  
			$"[[Annual Nfl Summary {PrintYear(startDate)}]]"
			},
		new WikiHeading(2,"Related")));

page.AddElement(
	new WikiHeading(
		2,
		"Links"));

page.AddElement(
	new WikiBlank());
	
page.AddElement(
	new WikiThreading(
		$"Nfl Season {PreviousYear(startDate)}",
		$"Nfl Season {NextYear(startDate)}",
		"NFL-Season"));

page.RenderToConsole();	
}

int SuperbowlNumber(DateTime startDate)
{
	return startDate.Year + 35 - 2000;
}

int WeekNumber( DateTime theDate)
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