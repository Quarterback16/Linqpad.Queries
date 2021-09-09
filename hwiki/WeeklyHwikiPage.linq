<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
  <Namespace>Utes</Namespace>
</Query>

//
//  Win the Week pages
//
    //var startOfWeek = DateTime.Now.AddDays(1);
	var startOfWeek = new DateTime(2021, 08, 30);
	var pageName = "Win The Week";
	_utes = new DateUte();

	Console.WriteLine($"### Plan for the Week Starting [[{Month(startOfWeek)}]]-{startOfWeek.Day:0#}");
	Console.WriteLine();

	WeekTable(startOfWeek);

	Console.WriteLine();
	WeeklyWins(startOfWeek);
	
	Console.WriteLine();
	Console.WriteLine("[[WeeklyWikiPage.linq]]");

	Console.WriteLine("---");
	Console.WriteLine($" * < [[{pageName} {PreviousWeek(startOfWeek)}]] (m) [[{pageName} {NextWeek(startOfWeek)}]] >");	
}

void WeeklyWins(
	DateTime startDate)
{
	Console.WriteLine("### Wins for the Week");
//	Console.WriteLine("1. [ ] Delivering: [[Cdp Activity Redevelopment]]: Fix Release");
	Console.WriteLine($"1. [ ] Learning: {LatestBook()}");
	Console.WriteLine("1. [ ] Learning: [[Vue.Js]]");
	Console.WriteLine("1. [ ] Learning: Build a .NET Core API");
	//	Console.WriteLine("1. [ ] Diverting: [[Civ VI Portugal Game 2]]");
	Console.WriteLine($"1. [ ] Diverting: {GameProject(startDate)}");
	Console.WriteLine();
	Console.WriteLine("You should be Delivering, Creating or Learning before Entertaining ur self");
	Console.WriteLine();
}

private string Month(DateTime theDate)
{
	return $"{theDate.ToString("yyy")}-{theDate.Month:0#}";
}

private DateUte _utes;

void WeekTable(
	DateTime startOfWeek)
{
	var table = new WikiTable();
	table.Columns.Add(
		new WikiColumn
		{
			Header = "Day"
		});
	table.Columns.Add(
		new WikiColumn
		{
			Header = "AM : 0600 - 0800"
		});
	table.Columns.Add(
		new WikiColumn
		{
			Header = "WORK 1 : 0800 - 1200"
		});
	table.Columns.Add(
		new WikiColumn
		{
			Header = "LUNCH : 1200 - 1400"
		});
	table.Columns.Add(
		new WikiColumn
		{
			Header = "WORK 2 : 1400 - 1700"
		});
	table.Columns.Add(
		new WikiColumn
		{
			Header = "PM : 1700 - 2000"
		});

	table.AddRows( 7 );  // one for each day
		
	for (int d = 0; d < 7; d++)
	{
		table.AddCell(
		   row: d + 1,
		   col: 0,
		   cellValue: DateCell(startOfWeek, d));
	}

	//  populate the cells
	// Mon night
	table.AddCell(1, 3, "[[Canberra Anomolies 2021]] lineup");
	// Mon AM
	table.AddCell(1, 2, "[[Vue.js]]");
	// Mon PM
	table.AddCell(1, 4, "[[Vue.js]]");
	// Tue AM
	table.AddCell(2, 2, "[[Vue.js]]");
	// Tue PM
	table.AddCell(2, 4, "[[Vue.js]]");
	// Tue night
	table.AddCell(1, 5, "[[Tip It]]");
	// Wed AM
	table.AddCell(3, 2, "[[Vue.js]]");
	// Wed PM
	table.AddCell(3, 4, "[[Vue.js]]");
	// Thu AM
	table.AddCell(4, 2, "[[Vue.js]]");
	// Thu PM
	table.AddCell(4, 4, "[[Vue.js]]");
	// Fri AM
	table.AddCell(5, 2, "[[Vue.js]]");
	// Fri PM
	table.AddCell(5, 4, "[[Vue.js]]");
	// Sat AM
	table.AddCell(6, 2, "[[Colonnas De Loreans 1988]]");
	// Sat PM
	table.AddCell(6, 3, "[[Colonnas Comanches 1988]]");
	// Sun AM
	table.AddCell(7, 1, "Win the Week");
	// Sun PM
	table.AddCell(7, 3, "Ring [[Margaret Colonna|Mum]]");
	// Early
	//for (int r = 1; r < 6; r++)
	//	table.AddCell(r, 1, LatestBook());
	// Night	
	for (int r = 2; r < 6; r++)
		table.AddCell(r, 5, GameProject(startOfWeek));
	table.Render();
}

string LatestBook()
{
	return "[[Eloquent JavaScript]]";
	//return "[[Enterprise Application Development]]";
	//return "LinqSuccinctly";	
}

string GameProject(
	DateTime theDate)
{
	//return "[[Anno Tourists Game 1]]";
	return $"[[Hearthstone-2021-{theDate.Month:0#}]]";
}

string DateCell( DateTime startOfWeek, int d )
{
	var theDate = startOfWeek.AddDays(d);
	var theDay = theDate.Day;
	return $"{theDate.ToString("ddd")}  ({theDay:0#}) {_utes.IsEventDay(theDate)}";
}

string IsBillDueDay(DateTime theDate)
{
   var bill = string.Empty;
   var billdue = IsBillDay(theDate);
   if (!string.IsNullOrEmpty(billdue.theEvent) )
   {
       bill = $"[ ] pay {billdue.theEvent} {billdue.theAmount}";
   }
   return bill;
}

void WeeklyNflScript(DateTime startDate)
{
	if (IsNflSeason(startDate))
	{
		Console.WriteLine();
		Console.WriteLine(" * [[Weekly Nfl Script]]");
	}
}

bool IsNflSeason(DateTime theDate)
{
	if (theDate.Month > 8) 
	   return true;
	return false;
}

string LastSaturday(DateTime startDate)
{
    var theSaturday = startDate;
	for	(int i = 0; i < DaysInMonth(startDate); i++ )
	{
		var queryDate = startDate.AddDays(i);
	    if (IsSaturday(queryDate) )
	    {
	       theSaturday = queryDate;
	    }
	}
	return theSaturday.ToString("dd");
}

void WriteScheduleLinks(DateTime startDate)
{
	for	(int i = 0; i < DaysInMonth(startDate); i++ )
	{
		var queryDate = startDate.AddDays(i);
	    if (IsMonday(queryDate) )
	    {
	       Console.WriteLine( $" 1. [RecSessions_{queryDate.ToString("yyyy_MM_dd")} Week {WeekNumber(queryDate)} schedule]");
	    }
	}
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

string IsRetroDay(DateTime theDate)
{
   var retro = string.Empty;
   if (IsSaturday(theDate))
   {
       retro = "[ ] Do GridstatsRetro [[ColonnasDeLoreans_1988]] turnsheet";
   }
   return retro;
}

string IsGridStatsDay(DateTime theDate)
{
   var response = string.Empty;
   if (IsSunday(theDate))
   {
       response = "[ ] Do [[Grid Stats]] turnsheet";
   }
   return response;
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
	return $"{thePerson}'s [[Gift Ideas|Birthday]] ({Age(theDate,dob)})";	
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

              theEvent = $"[[MLB]] season starts [[Pitsburgh Pirates {theYear}]]";

       if (theMonth == 4 && theDay == 18)

              theEvent = "[[NBA]] playoffs";

       if (theMonth == 4 && theDay == 24)

              theEvent = $"[[NflDraft_{theYear}]]";

       if (theMonth == 8 && theDay == 7)

              theEvent = "Hard Knocks";

       if (theMonth == 8 && theDay == 11)

              theEvent = $"[[EPL]] begins [[Arsenal {theYear}]]";

       if (theMonth == 8 && theDay == 13)

              theEvent = "[[Grid Stats]] turn sheet P1 due";

       if (theMonth == 8 && theDay == 18)

              theEvent = $"[[Serie A]] begins [[Juventus {theYear}]]";

       if (theMonth == 8 && theDay == 19)

              theEvent = "[[Distillery League]] draft";

       if (theMonth == 9 && theDay == 1)

              theEvent = "[[Nfl Game Pass]] renews";

       if (theMonth == 11 && theDay == 13)

              theEvent = "Our Aniversary";

       return theEvent;   

}

(string theEvent, decimal theAmount) IsBillDay(DateTime theDate)
{
    (string theEvent, decimal theAmount) result = (string.Empty,0.0M);
    var theMonth = theDate.Month;
	var theDay = theDate.Day;
	if (theDay == 1)
	{
		result = ("MyWay top up", 50.0M);
	}
	if (theDay == 9)
	{
       result = ("Home Loan", 3389.34M);
	}
	if (theDay == 9 
	     && (theMonth == 2 || theMonth == 5 || theMonth == 8 || theMonth == 11) )
		 UtilityBills(theDate);
	if (theDay == 8 
	     && (theMonth == 4 || theMonth == 7 || theMonth == 10 || theMonth == 1) )
		 Rates(theDate);		 
	if (theDay == 23 
	     && theMonth == 3 )
       result = ("Registration", 500.00M);		 
	return result;	
}

void Rates(
   DateTime iDate)
{
   Console.WriteLine($" 1. [ ] {FirstTwoLetters(iDate)} : ({iDate.Day:0#}) : [KingsmillRates Rates] : {610.00M:c} ");	
}

void UtilityBills(
   DateTime iDate)
{
   Console.WriteLine($" 1. [ ] {FirstTwoLetters(iDate)} : ({iDate.Day:0#}) : [[Kingsmill Electricity|Electricity] : {428.50M:c} ");	
   Console.WriteLine($" 1. [ ] {FirstTwoLetters(iDate)} : ({iDate.Day:0#}) : [[Kingsmill Gas|Gas] : {249.62M:c} ");	
   Console.WriteLine($" 1. [ ] {FirstTwoLetters(iDate)} : ({iDate.Day:0#}) : [[Kingsmill Water And Sewerage|Water and Sewerage] : {248.03M:c} ");
}

void BillLine(
   DateTime iDate,
   (string theEvent, decimal theAmount ) bill)
{
   Console.WriteLine($"  * [ ] {FirstTwoLetters(iDate)} : ({iDate.Day:0#}) : {bill.theEvent} : {bill.theAmount:c} ");	
}

void DateLine(
   DateTime iDate,
   string commentPart )
{
   Console.WriteLine($" 1. {FirstTwoLetters(iDate)} : ({iDate.Day:0#}) : {commentPart}");	
}

string PrintDate(DateTime printDate)
{
	return printDate.ToString("yyyy-MM-dd");
}

string PreviousWeek(DateTime printDate)
{
	return printDate.AddDays(-7).ToString("yyyy-MM-dd");
}

string NextWeek(DateTime printDate)
{
	return printDate.AddDays(7).ToString("yyyy-MM-dd");
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