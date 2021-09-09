<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

var theDay = DateTime.Now;
Console.WriteLine($"=== {theDay.ToString("dddd")} {PrintDate(theDay)} ===");
Console.WriteLine();

Console.WriteLine($"==== Highlights ====");
Console.WriteLine("  1. {one thing that would be good to accomplish today}");
Console.WriteLine();


Console.WriteLine("|| **Timeslot**  ||  **Activity**  ||  **Comments**   ||");

if (IsSunday(theDay))
{
	GridStatsHour( 9, theDay );
	TimeSlot(10, "Ring MargaretColonna; walk");
	TimeSlot(11, "[NextCodingProject Coding Hour]");
	TimeSlot(12, "[ReadingStrategy Reading Hour]" );
	TimeSlot(13, "[CivilizationVI CIV 6 Hour]");
	TimeSlot(14, $"{HearthstoneLink(theDay)} [[Hearthstone]] Hour");
	TimeSlot(15, "[[Anno_1800]] Hour");	
	TimeSlot(16, "[[GalacticCivilizations_3]] hour" );
}
if (IsSaturday(theDay))
{
	GridStatsHour(9, theDay);
	TimeSlot(10, "[NextCodingProject Coding Hour]");
	TimeSlot(11, "[DeckDetector Deck Detector Coding Hour]");
	TimeSlot(12, "[ReadingStrategy Reading Hour]");
	TimeSlot(13, $"{HearthstoneLink(theDay)} [[Hearthstone]] Hour");
	TimeSlot(14, "[CivilizationVI CIV 6 Hour]");
	TimeSlot(15, "[[Anno_1800]] Hour");
	TimeSlot(16, "[[GalacticCivilizations_3]] hour");
}
TimeSlot(21, "Reading hour to sleep" );

Console.WriteLine();
Console.WriteLine("#day");
}

string HearthstoneLink(DateTime theDay)
{
	return $"[[Hearthstone-{TheMonth(theDay)}]]";

}
void GridStatsHour( int when, DateTime theDay )
{
	var gridstatsType = "GridStats";
	if (IsSaturday(theDay))
	{
		gridstatsType = "GridstatsRetro";
	}
	TimeSlot( when, $"{gridstatsType} hour");
}

void TimeSlot( int hr, string activity )
{
	Console.WriteLine($"||      {ToTime(hr)}     ||  {activity}  ||    ||");	
}

string ToTime( int hr )
{
	return $"{hr:0#}00";
}

bool IsMonday(DateTime theDate)
{
   return theDate.DayOfWeek == DayOfWeek.Monday;
}

bool IsSaturday(DateTime theDate)
{
	return true;
    //return theDate.DayOfWeek == DayOfWeek.Saturday;
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

void DateLine(
   DateTime iDate,
   string commentPart )
{
   Console.WriteLine($"  1. {FirstTwoLetters(iDate)} : ({iDate.Day:0#}) : {commentPart}");	
}

string PrintDate(DateTime printDate)
{
	return printDate.ToString("[[yyyy-MM]]-dd");
}

string TheMonth(DateTime printDate)
{
	return printDate.ToString("yyyy-MM");
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