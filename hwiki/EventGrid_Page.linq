<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

var year = 2015;
var startDate = new DateTime(year,1,1);

EventGridHeading(startDate);

for (int i = 1; i < 13; i++)
{
	MonthLine(startDate,i);
}

Console.WriteLine();
Console.WriteLine("----");
Console.WriteLine($"  * < EventGrid_{startDate.AddYears(-1).ToString("yyyy")} (m) EventGrid_{startDate.AddYears(1).ToString("yyyy")} >");	

}

void MonthLine(
   DateTime startDate,
   int nMonth)
{
   Console.WriteLine($"||   [[{MonthLink(startDate,nMonth)}]]  ||           ||             ||");
}

string MonthLink(
   DateTime startDate,
   int nMonth)
{
   return $"{startDate.Year}-{nMonth:0#}";	
}

void EventGridHeading(DateTime startDate)
{
	Console.WriteLine($"=== Events of {startDate.Year} ===");
	Console.WriteLine();
	Console.WriteLine("||  **Month**     ||  **Day**  ||  **Event**  ||");
}


string PrintDate(DateTime printDate)
{
	return printDate.ToString("yyyy-MM-dd");
