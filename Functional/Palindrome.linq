<Query Kind="Program" />

void Main()
{
	string[] strArray = {
		"room",
		"level",
		"channel",
		"heat",
		"burn",
		"madam",
		"machine",
		"jump",
		"radar",
		"brain"
	};
	foreach (var s in strArray)
	{
		Console.WriteLine(
		   "{0} = {1}",
		   s,
		   s.IsPalindrome());
	}

	strArray.WriteToConsole("strArray");
	var obj1 = UInt64.MaxValue;
	obj1.WriteToConsole(nameof(obj1));
	var obj2 = new DateTime(2016, 1, 1);
	obj2.WriteToConsole(nameof(obj2));
	
	var obj3 = new DataItem
	{
		Name = "Cristiano",
		Gender = "Male"
	};
	obj3.WriteToConsole(nameof(obj3));
}

public class DataItem
{
	public string Name { get; set; }
	public string Gender { get; set; }
}
