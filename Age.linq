<Query Kind="Statements" />

Console.WriteLine( Age(new DateTime(2020,11,17), "1959-11-08") );

string Age(DateTime theDate, string dob)
{
	var age = string.Empty;
	var ts = theDate - Convert.ToDateTime(dob);
	var nAge = (ts.Days / 365);
	age = string.Format("{0}", nAge);
	return age;
}