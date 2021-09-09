<Query Kind="Program" />

void Main()
{
	var pn = LazyInitName("Steve Colonna");
	Console.WriteLine(
		String.Format(
			"Status: PersonName.Name = {0}",
			(pn.Value as PersonName).Name));
}

private static Lazy<PersonName> LazyInitName( string nameOfPerson )
{
	Lazy<PersonName> pn = new Lazy<PersonName>(
	  () => new PersonName( nameOfPerson ));
	  Console.WriteLine("Status: PersonName has been defined");
	if (pn.IsValueCreated)
		Console.WriteLine("Status: PersonName has been initialised");
	else
	    Console.WriteLine("Status: PersonName hasn't been initialised");
	return pn;
}

public class PersonName
{
	public string Name { get; set; }
	
	public PersonName(string name)
	{
		Name = name;
		Console.WriteLine(
			"Status: PersonName constructor has been called.");
	}
}