<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

var startDate = new DateTime(2021, 01, 1);
Console.WriteLine($"|||||| //**{startDate.ToString("yyyy")}**// ||");
MonthLine(1,startDate);	
MonthLine(4,startDate);	
MonthLine(7,startDate);	
MonthLine(10,startDate);	
Resolutions(startDate);
Teams(startDate);
Console.WriteLine("#year");
Console.WriteLine("");
Console.WriteLine("----");
Console.WriteLine($"  * < [FutureLog_{PreviousYear(startDate)} {PreviousYear(startDate)}] (m) [FutureLog_{NextYear(startDate)} {NextYear(startDate)}] >");	
}

void Teams(DateTime theYear)
{
	var teams = new List<string>();
	teams.Add("Juventus");
	teams.Add("Arsenal");
	teams.Add("PittsburghPirates");
	teams.Add("SpitzysLeague");
	teams.Add("ColonnasComanches");
	teams.Add("Civ_VI_GameOfTheMonth");

	Console.WriteLine("");
	Console.WriteLine("=== My Teams ===");
	foreach (var team in teams)
	{
		Console.WriteLine($"  * [[{team}_{theYear.Year}]]");		
	}
	Console.WriteLine("");
}


void Resolutions(DateTime theYear)
{
	Console.WriteLine("");
	Console.WriteLine($"  * [[Resolutions_{theYear.Year}]]");
	Console.WriteLine("");
}

void MonthLine(int starter, DateTime yearDate)
{
	for (int i = starter; i < starter+3; i++)
	{
		string monthName = new DateTime(yearDate.Year, i, 1)
			.ToString("MMMM", CultureInfo.InvariantCulture);
		Console.Write($"||  **[[{yearDate.Year}-{i:0#}]] {monthName}**  ");
	}
	Console.WriteLine("  ||");
	for (int i = starter; i < starter + 3; i++)
	{
		Console.Write($"||  {Items(i,yearDate)}  ");
	}
	Console.WriteLine("  ||");
}

string Items(int month, DateTime startDate)
{
	var items = new StringBuilder();
	var events = new List<string>();
	switch (month)
	{
		case 1:
		    events.Add("Australia Day");

			break;
		case 2:
			events.Add("Mo 08 [[Superbowl]]");
			events.Add("Su 14 [BenColonna Bens] BD ");			

			break;
		case 3:
			events.Add("Canberra Day");

			break;
		case 4:
			events.Add("Easter Monday");
			events.Add("Good Friday");			
			events.Add("Fr 23 [LonnieColonna Lonnies] BD ");
			events.Add($"Fr 23 {NflDraftLink(startDate)} ");			
			events.Add("Sa 24 [AylaVenslovas Aylas] BD ");

			break;
		case 5:
			events.Add("Mo 08 [[Superbowl]]");
			events.Add("Sa 22 [EmilyColonna Ems] BD ");
			events.Add("[[NFL]] schedule");
			events.Add("FaCup");
			
			break;
		case 6:
			events.Add("Sa 12 [NickColonna Nicks] BD ");
			events.Add("Queens Birthday");	
			
			break;
		case 7:


			break;
		case 8:
			events.Add("Su 01 NflGamePass renews");
			events.Add("Su 01 [[NFL]] Preseason");
			events.Add("HardKnocks");
			events.Add("[[EPL]] starts");

			break;
		case 9:
			events.Add("Tu 21 [MargaretColonna Mums] BD ");

			break;
		case 10:
			events.Add("Labour Day");

			break;
		case 11:
			events.Add("Mo 08 [SteveColonna Steves] BD ");
			events.Add("Sa 13 [StevenVenslovas The Stephens] BD ");
			events.Add("Sa 13 Our Anniversary ");

			break;
		case 12:
			events.Add("Christmas Day");
			events.Add("Boxing Day");

			break;
	}
	foreach (var e in events)
	{
		items.Append(e + " <br>");
	}
	return items.ToString();
}

string NflDraftLink(DateTime theDate)
{
	return $"[[NflDraft_{theDate.Year}]]";
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


bool IsMonday(DateTime theDate)
{
   return theDate.DayOfWeek == DayOfWeek.Monday;
}

bool IsSaturday(DateTime theDate)
{
   return theDate.DayOfWeek == DayOfWeek.Saturday;
}

bool IsSunday(DateTime theDate)
{
   return theDate.DayOfWeek == DayOfWeek.Sunday;
}


string IsHoliday(DateTime printDate)
{
	if (printDate == new DateTime(2020, 1, 1))
       return "New Year's Day";
    if (printDate == new DateTime(2020,1,27))
       return "Australia Day";
    if (printDate == new DateTime(2020,2,3))
       return "Superbowl Day";	   
    if (printDate == new DateTime(2020, 3, 9))
       return "Canberra Day";
    if (printDate == new DateTime(2020, 4, 10))
       return "Good Friday";
    if (printDate == new DateTime(2020, 4, 13))
       return "Easter Monday";
    if (printDate == new DateTime(2020, 4, 27))
       return "Anzac Day Holiday";
    if (printDate == new DateTime(2020, 6, 1))
       return "Reconciliation Day";
    if (printDate == new DateTime(2020, 6, 8))
       return "Queen's Birthday";
    if (printDate == new DateTime(2020, 10, 5))
       return "Labour Day";
    if (printDate == new DateTime(2020, 12, 25))
       return "Christmas Day";
    if (printDate == new DateTime(2020, 12, 28))
       return "Boxing Day Holiday";
   return string.Empty;
}

string IsBirthDay(DateTime theDate)
{
    var thePerson = string.Empty;
	var dob = string.Empty;
    var theMonth = theDate.Month;
    var theDay = theDate.Day;
	if (theMonth == 2 && theDay == 14)
	{
       thePerson = "Ben";
	   dob = "1990-12-14";
	}
	if (theMonth == 4 && theDay == 23)
	{
       thePerson = "Lonnie";
	   dob = "1960-04-23";
	}
	if (theMonth == 4 && theDay == 24)
	{
       thePerson = "Ayla";	
	   dob = "1988-04-24";
	}
	if (theMonth == 5 && theDay == 22)
	{
       thePerson = "Emily";
	   dob = "1993-05-22";
	}
	if (theMonth == 6 && theDay == 12)
	{
       thePerson = "Nick";	
	   dob = "1995-06-12";
	}
	if (theMonth == 6 && theDay == 23)
	{
       thePerson = "Tanya";	
	   dob = "1963-06-23";
	}
	if (theMonth == 8 && theDay == 23)
	{
       thePerson = "Dad";
	   dob = "1932-08-23";
	}
	if (theMonth == 9 && theDay == 21)
	{
       thePerson = "Mum";		   
	   dob = "1937-09-21";
	}
	if (theMonth == 11 && theDay == 8)
	{
       thePerson = "Luciano";			   
	   dob = "1959-11-08";
	}
	if (theMonth == 11 && theDay == 13)
	{
       thePerson = "Steven";			   
	   dob = "1990-11-13";
	}
	if (string.IsNullOrEmpty(thePerson))   
   		return string.Empty;
	return $"{thePerson}'s [GiftIdeas Birthday] ({Age(theDate,dob)})";	
}

string Age( DateTime theDate, string dob )
{
	var age = string.Empty;
	var ts = theDate - Convert.ToDateTime( dob );
	var nAge = ( ts.Days / 365 );
	age = string.Format( "{0}", nAge );
	return age;
}

string IsSpecialDay(DateTime theDate)

{

    var theEvent = string.Empty;

    var theMonth = theDate.Month;

    var theDay = theDate.Day;

       var theYear = theDate.Year;

       if (theMonth == 2 && theDay == 14)

              theEvent = "Valentines Day";

       if (theMonth == 3 && theDay == 13)

              theEvent = "[[NFL]] Free Agency begins";

       if (theMonth == 3 && theDay == 28)

              theEvent = $"[[MLB]] season starts [[PitsburghPirates_{theYear}]]";

       if (theMonth == 4 && theDay == 18)

              theEvent = "[[NBA]] playoffs";

       if (theMonth == 4 && theDay == 24)

              theEvent = $"[[NflDraft_{theYear}]]";

       if (theMonth == 8 && theDay == 7)

              theEvent = "Hard Knocks";

       if (theMonth == 8 && theDay == 11)

              theEvent = $"[[EPL]] begins [[Arsenal_{theYear}]]";

       if (theMonth == 8 && theDay == 13)

              theEvent = "GridStats turn sheet P1 due";

       if (theMonth == 8 && theDay == 18)

              theEvent = $"SerieA begins [[Juventus_{theYear}]]";

       if (theMonth == 8 && theDay == 19)

              theEvent = "DistilleryLeague draft";

       if (theMonth == 9 && theDay == 1)

              theEvent = "NflGamePass renews";

       if (theMonth == 11 && theDay == 13)

              theEvent = "Our Aniversary";

       return theEvent;   

}


void DateLine(
   DateTime iDate,
   string commentPart )
{
   Console.WriteLine($"  1. {FirstTwoLetters(iDate)} : ({iDate.Day:0#}) : {commentPart}");	
}

string PrintDate(DateTime printDate)
{
	return printDate.ToString("yyyy-MM-dd");
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