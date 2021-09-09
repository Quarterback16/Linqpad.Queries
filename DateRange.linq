<Query Kind="Statements" />

var startDate = new DateTime(1900, 1, 1);
var endDate = new DateTime(2032, 12, 31);
TimeSpan diff = endDate.Date - startDate.Date;
//Console.WriteLine($"Total Days:{diff.TotalDays+1}");

Console.WriteLine($"Max Date is {DateTime.MaxValue.Date:yyyy-MM-dd}");