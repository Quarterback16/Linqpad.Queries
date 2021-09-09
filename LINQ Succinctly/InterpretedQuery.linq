<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	var xml = @"
	<ingredients>
	   <ingredient name='milk' quantity='200' price='2.99' />
	   <ingredient name='sugar' quantity='100' price='4.99' />
	   <ingredient name='safron' quantity='1' price='46.77' />
	</ingredients>";
	
	XElement xmlData = XElement.Parse(xml);
	
	XElement milk = xmlData
		.Descendants("ingredient")
		.First( x => x.Attribute("name").Value == "milk");

	XAttribute nameAttribute = milk.FirstAttribute;
	XAttribute priceAttribute = milk.Attribute("price");
	string priceOfMilk = priceAttribute.Value;
	
	XAttribute quantity = milk.Attributes()
	                          .Skip(1)
							  .First();

}

// You can define other methods, fields, classes and namespaces here
