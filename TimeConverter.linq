<Query Kind="Statements" />

//var timeCode = "1 PM EDT";
//var timeCode = "3 PM EST";  //  http://www.timebie.com/std/est.php?q=4
var timeCode = "10 AM PT";

var part = timeCode.Split();
var len = part.Length;
var timeZone = part[len - 1];
var hour = Int32.Parse(part[0]);
if (part[1].ToLower().Equals("pm"))
	hour += 12;
var localHour = hour;
if (timeZone.ToUpper() == "PT")
{
	localHour = localHour + 17;
}
if (timeZone.ToUpper() == "PDT")
{
	localHour = localHour + 18;
}
if (timeZone.ToUpper() == "EDT")
{
	localHour = localHour + 15;
}
if (timeZone.ToUpper() == "EST")
{
	localHour = localHour + 16;
}
if (localHour > 24)
	localHour -= 24;

Console.WriteLine($"Local time : {AsNormalTime(localHour)} {TheDay(localHour,hour)}");
}

string TheDay(int localHour, int hour)
{
	var theDay = string.Empty;
	if (localHour < hour )
	   theDay = "next day";
	return theDay;
}
string AsNormalTime(int hour)
{
	var theHour = hour;
	var theSuffix = "am";
	if (theHour > 12)
	{
		theHour -= 12;
		theSuffix = "pm";
	}
	return $"{theHour} {theSuffix}";