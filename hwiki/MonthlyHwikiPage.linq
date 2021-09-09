<Query Kind="Statements">
  <Reference>E:\FileSync\SyncProjects\TipIt\ScheduleService\bin\Release\netcoreapp3.1\ScheduleService\epl-schedule-2021.json</Reference>
  <Reference>E:\FileSync\SyncProjects\TipIt\ScheduleService\bin\Release\netcoreapp3.1\ScheduleService\nfl-schedule-2021.json</Reference>
  <Reference>E:\FileSync\SyncProjects\TipIt\ScheduleService\bin\Release\netcoreapp3.1\ScheduleService\sra-schedule-2021.json</Reference>
  <Reference>E:\FileSync\SyncProjects\TipIt\ScheduleService\bin\Release\netcoreapp3.1\TipIt.dll</Reference>
  <Namespace>ScheduleService</Namespace>
  <Namespace>System.Globalization</Namespace>
</Query>

var startDate = new DateTime(2021, 09, 1);

var scheduleService = new ScheduleService.ScheduleMaster();

    Console.WriteLine($"# {startDate.ToString("MMMM")} [[Future Log {startDate.Year}|{startDate.Year}]] Objectives");
	Console.WriteLine();
	Console.WriteLine("1. reading (health)");
	Console.WriteLine($"1. [[Hearthstone-{startDate.ToString("yyyy-MM")}]] (fun)");
	Console.WriteLine();
	Console.WriteLine($" * [[{startDate.AddYears(-1).ToString("yyyy-MM")}]]");
	Console.WriteLine();
	Console.WriteLine("## My [[To Do List|Activities]]");
	Console.WriteLine("[[Things To Do]]");
	DateLine(startDate,"Check [[Margaret Colonna|Mums]] [[Arcare]] bill");
	for	(int i = 0; i < DaysInMonth(startDate); i++ )
	{
		var iDate = startDate.AddDays(i);
		var isMon = IsStartOfWeek(iDate);
	    if (!string.IsNullOrEmpty(isMon))
			WeekHeader(iDate, isMon);
		var isHol = IsHoliday(iDate);
		if (!string.IsNullOrEmpty(isHol))
	        DateLine(iDate,isHol);	
	   var isSpec = IsSpecialDay(iDate);
	   if (!string.IsNullOrEmpty(isSpec))
	      DateLine(iDate,isSpec);	
	   var isBirt = IsBirthDay(iDate);
	   if (!string.IsNullOrEmpty(isBirt))
	      DateLine(iDate,isBirt);
		  
	   var isRetro = IsRetroDay(iDate);	  
	   if (!string.IsNullOrEmpty(isRetro))
	      DateLine(iDate,isRetro);
	   var isGridStats = IsGridStatsDay(iDate);	  
	   if (!string.IsNullOrEmpty(isGridStats))
		DateLine(iDate, isGridStats);
		
		var isGameDay = IsGameDay("Arsenal","EPL",iDate,scheduleService);
		if (!string.IsNullOrEmpty(isGameDay))
			DateLine(iDate, isGameDay);

	isGameDay = IsGameDay("Juventus", "S-A", iDate, scheduleService);
	if (!string.IsNullOrEmpty(isGameDay))
		DateLine(iDate, isGameDay);

	isGameDay = IsGameDay("SF", "NFL", iDate, scheduleService);
	if (!string.IsNullOrEmpty(isGameDay))
		DateLine(iDate, isGameDay);

	// can expand this into full Calender Todo system
	   var isBill = IsBillDueDay(iDate);
	   if (!string.IsNullOrEmpty(isBill))
	      DateLine(iDate,isBill);	   
	   //  IsTurnSheetDay()
	   //  IsTeamGameDay()
	}
	Console.WriteLine(
		$"\t1. [ ] Sa : ({LastSaturday(startDate)}) : [[Monthly Planning|Plan next month]] [[{startDate.AddMonths(1).ToString("yyyy-MM")}]]");
	
	WeeklyNflScript(
		startDate);
	
	WorkInProgress(
		startDate);
	NextProjects(
		startDate);	

	Console.WriteLine();
	Console.WriteLine("## [[Budget 2020-21|Bills]]");
	Console.WriteLine("* Opening Balance: $?,????");
	//for	(int i = 0; i < DaysInMonth(startDate); i++ )
	//{
	//   var iDate = startDate.AddDays(i);
	//   var bill = IsBillDay(iDate);
	//   if (!string.IsNullOrEmpty(bill.theEvent))
	//      BillLine(iDate,bill);	
	//}	
	
	Console.WriteLine();
	Console.WriteLine("## Discoveries and Curiosities");
	Console.WriteLine("1.");
	Console.WriteLine();
	Console.WriteLine("## Ideas");
	Console.WriteLine("1.");
	Console.WriteLine();
	Console.WriteLine("## Replenish Supplies");
	Console.WriteLine("1.");
	Console.WriteLine();
	Console.WriteLine("## Media of the Month");
	Console.WriteLine("1. [[Reading Strategy|Books]]");
	Console.WriteLine("2. Games");
	Console.WriteLine("3. Purchases");
	Console.WriteLine("4. [[TV Recommendations]]");
	Console.WriteLine("5. [[Software Recommendations]]");
	Console.WriteLine();
	Console.WriteLine("[[MonthlyWikiPage.linq]]");
	Console.WriteLine();
	Console.WriteLine("---");
	Console.WriteLine($"  * < [[{PreviousMonth(startDate)}]] (m) [[{NextMonth(startDate)}]] >");	
}

string IsBillDueDay(DateTime theDate)
{
   var bill = string.Empty;
   var billdue = IsBillDay(theDate);
   if (!string.IsNullOrEmpty(billdue.theEvent) )
   {
       bill = $"pay {billdue.theEvent} {billdue.theAmount}";
   }
   return bill;
}

void WeeklyNflScript(DateTime startDate)
{
	if (IsNflSeason(startDate))
	{
		Console.WriteLine();
		Console.WriteLine("* [[Weekly Nfl Script]]");
	}
}

bool IsNflSeason(DateTime theDate)
{
	if (theDate.Month > 8) 
	   return true;
	return false;
}

bool IsEplSeason(DateTime theDate)
{
	if (theDate.Month > 8 || theDate.Month < 6)
		return true;
	return false;
}

bool IsSerieASeason(DateTime theDate)
{
	if (theDate.Month > 8 || theDate.Month < 6)
		return true;
	return false;
}

bool IsMlbSeason(DateTime theDate)
{
	if (theDate.Month > 3 || theDate.Month < 11)
		return true;
	return false;
}

void NextProjects(DateTime startDate)
{
	Console.WriteLine("## [[Next Projects|Projects]] 5 max");
	Console.WriteLine("1. [[Reading Strategy|Reading]] :");	
	Console.WriteLine("2. [[Next Learning Project|Learning]] :");
	Console.WriteLine("3. [[Next Coding Project|Coding]] :");	
	Console.WriteLine();
}

void WorkInProgress(DateTime startDate)
{
	Console.WriteLine();
	Console.WriteLine("## WIP");
	Console.WriteLine("Remember [[Steves Development Approach]]");
	Console.WriteLine();
	Console.WriteLine( "1. maintain [[Product Portfolio]]");
	Console.WriteLine( "1. [[Steves Games]]");
	Console.WriteLine($"  1. [[Hearthstone-{startDate.ToString("yyyy-MM")}]]");
	if (!IsNflSeason(startDate))
	{
		Console.WriteLine($"  1. [[Civ VI Game Of The Month {startDate.ToString("yyyy")}]] ");
		Console.WriteLine("  1. [[Anno 1800]]");
		Console.WriteLine("  1. [[Gathering Storm]]");
		Console.WriteLine("  1. [[True Steam Achievements]]");
	}
	Console.WriteLine( "1. [[Steves Sports]]");
	if (IsNflSeason(startDate))
	{
		Console.WriteLine($"  1. [[San Francisco Forty Niners {startDate.Year}]]");
		Console.WriteLine( "    * [[Weekly Nfl Script]]");
	}
	if (IsEplSeason(startDate))
		Console.WriteLine($"  1. [[Arsenal {startDate.Year}]]");
	if (IsSerieASeason(startDate))
		Console.WriteLine($"  1. [[Juventus {startDate.Year}]]");	
	if (IsMlbSeason(startDate))
		Console.WriteLine($"  1. [[Pittsburgh Pirates {startDate.Year}]]");			
	Console.WriteLine( "  1. [[Socceroos 2022]]");
	Console.WriteLine( "1. Steves Fantasies");	
	if (!IsNflSeason(startDate))
		Console.WriteLine($"  1. [[Colonnas De Loreans {startDate.Year - 34}]]");
	if (IsNflSeason(startDate))
		Console.WriteLine($"  1. [[7x7ers {startDate.Year}]]");
	if (IsNflSeason(startDate))		
		Console.WriteLine($"  1. [[Colonnas Comanches {startDate.Year}]]");
	if (IsMlbSeason(startDate))
		Console.WriteLine($"  1. [[Canberra Anomolies {startDate.Year}]]");
	Console.WriteLine();
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

int WeekNumber(
	DateTime theDate)
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

string IsStartOfWeek(
   DateTime theDate )
{
	if (IsMonday(theDate))
		return $"[[Win The Week {theDate.ToString("yyyy-MM-dd")}]]";
	return string.Empty;
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
	var theYear = printDate.Year;
	var theHoliday = string.Empty;
	if (printDate == new DateTime(theYear, 1, 1))
       theHoliday =  "New Year's Day";
    if (printDate == new DateTime(theYear,1,26))
       theHoliday =  "Australia Day";
    if (printDate == new DateTime(theYear,2,3))
       theHoliday =  "Superbowl Day";	   
    if (printDate == new DateTime(theYear, 3, 8))
       theHoliday =  "Canberra Day";
    if (printDate == new DateTime(theYear, 4, 2))
       theHoliday =  "Good Friday";
    if (printDate == new DateTime(theYear, 4, 5))
       theHoliday =  "Easter Monday";
    if (printDate == new DateTime(theYear, 4, 25))
       theHoliday =  "Anzac Day Holiday";
    if (printDate == new DateTime(theYear, 5, 31))
       theHoliday =  "Reconciliation Day";
    if (printDate == new DateTime(theYear, 6, 14))
       theHoliday =  "Queen's Birthday";
    if (printDate == new DateTime(theYear, 10, 4))
       theHoliday =  "Labour Day";
    if (printDate == new DateTime(theYear, 12, 27))
       theHoliday =  "Christmas Day Holiday";
    if (printDate == new DateTime(theYear, 12, 28))
       theHoliday =  "Boxing Day Holiday";

	return string.IsNullOrEmpty(theHoliday) ? string.Empty : $"() {theHoliday}";
}

string IsRetroDay(DateTime theDate)
{
   var retro = string.Empty;
   if (IsSaturday(theDate))
   {
       retro = $"Do [[Colonnas De Loreans {theDate.Year-35}]] turnsheet";
   }
   return retro;
}

string IsGameDay(
    string team,
	string league,
	DateTime theDate,
	ScheduleService.IScheduleService scheduleService)
{
	var response = string.Empty;
	var result = scheduleService.GetGame(team,theDate,league,theDate.Year);
	if (result.Round > 0)
	{
		response = $@"{result.GameDate.ToString("HH:mm")} {
			result.League
			} Round {
			result.Round
			} : {
			result.AwayTeam
			}  @ {
			result.HomeTeam
			}";
	}
	return response;
}

string IsGridStatsDay(DateTime theDate)
{
	var response = string.Empty;
	if (theDate.Month == 1 || theDate.Month > 7)
	{
		if (IsSunday(theDate))
		{
			response = "Do [[GridStats]] turnsheet";
		}
	}
   return response;
}

string IsBirthDay(DateTime theDate)
{
    var thePerson = string.Empty;
	var dob = string.Empty;
    var theMonth = theDate.Month;
    var theDay = theDate.Day;
	if (theMonth == 2 && theDay == 12)
	{
       thePerson = "Andrew";
	   dob = "1990-02-12";
	}
	if (theMonth == 2 && theDay == 14)
	{
		thePerson = "Ben";
		dob = "1990-02-14";
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

              theEvent = $"[[Nfl Draft {theYear}]]";

       if (theMonth == 8 && theDay == 7)

              theEvent = "[[Hard Knocks]]";

       if (theMonth == 8 && theDay == 11)

              theEvent = $"[[EPL]] begins [[Arsenal {theYear}]]";

       if (theMonth == 8 && theDay == 13)

              theEvent = "[[GridStats]] turn sheet P1 due";

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
		result = ("[[My Way]] top up", 50.0M);
	}
	if (theDay == 9)
	{
       result = ("[[Home Loan]]", 3389.34M);
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
   Console.WriteLine($"1. [ ] {FirstTwoLetters(iDate)} : ({iDate.Day:0#}) : [[Kingsmill Rates|Rates][ : {610.00M:c} ");	
}

void UtilityBills(
   DateTime iDate)
{
   Console.WriteLine($"1. [ ] {FirstTwoLetters(iDate)} : ({iDate.Day:0#}) : [[Kingsmill Electricity|Electricity]] : {428.50M:c} ");	
   Console.WriteLine($"1. [ ] {FirstTwoLetters(iDate)} : ({iDate.Day:0#}) : [[Kingsmill Gas|Gas]] : {249.62M:c} ");	
   Console.WriteLine($"1. [ ] {FirstTwoLetters(iDate)} : ({iDate.Day:0#}) : [[Kingsmill Water And Sewerage|Water and Sewerage]] : {248.03M:c} ");	;
}

void BillLine(
   DateTime iDate,
   (string theEvent, decimal theAmount ) bill)
{
   Console.WriteLine($"  * [ ] {FirstTwoLetters(iDate)} : ({iDate.Day:0#}) : {bill.theEvent} : {bill.theAmount:c} ");	
}

void WeekHeader(
   DateTime iDate,
   string commentPart)
{
	Console.WriteLine($"1. {commentPart}");
}

void DateLine(
   DateTime iDate,
   string commentPart )
{
   Console.WriteLine($"\t1. [ ] {FirstTwoLetters(iDate)} : ({iDate.Day:0#}) : {commentPart}");	
}

string PrintDate(DateTime printDate)
{
	return printDate.ToString("yyyy-MM-dd");
}

string PreviousMonth(DateTime printDate)
{
	return printDate.AddMonths(-1).ToString("yyyy-MM");
}

string NextMonth(DateTime printDate)
{
	return printDate.AddMonths(1).ToString("yyyy-MM");
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