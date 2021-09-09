<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	var data = LoadInventory();
	var query = data
		.Where( i => string.IsNullOrEmpty(i.ExitDate))
		.Select(x => new { x.Name, x.EntryDate, x.Size, x.CurrentValue })
		.OrderByDescending( x=> x.EntryDate);
	query.Dump();
}

public List<InventoryItem> LoadInventory()
{
	var inventory = new List<InventoryItem>();
	inventory.Add(
		new InventoryItem
		{
			Category = "Computing Equipment",
			Name = "Amazon Echo Dot (Kitchen)",
			WikiPage = "AmazonEcho",
			Size = "S",
			EntryDate = "2018-09-04",
			CurrentValue = 50.00M
		});
	inventory.Add(
		new InventoryItem
		{
			Category = "Computing Equipment",
			Name = "Amazon Echo Dot (Retreat)",
			WikiPage = "AmazonEcho",
			Size = "S",
			EntryDate = "2018-09-04",
			CurrentValue = 50.00M
		});
	inventory.Add(
		new InventoryItem
		{
			Category = "Computing Equipment",
			Name = "Amazon Echo Plus (Study)",
			WikiPage = "AmazonEcho",
			Size = "S",
			EntryDate = "2018-09-04",
			CurrentValue = 80.00M
		});
	inventory.Add(
		new InventoryItem
		{ 
			Category = "Computing Equipment",
			Name = "Ethernet Over Powerline plugs", 
			WikiPage = "EthernetOverPowerline", 
			Size = "S",
			EntryDate = "2018-01-15", 
			CurrentValue = 80.00M
		});
	inventory.Add(
		new InventoryItem
		{
			Category = "Computing Equipment",
			Name = "Xbox One X",
			WikiPage = "XboxOneX",
			Size = "M",
			EntryDate = "2017-11-01",
			CurrentValue = 500.00M
		});
	inventory.Add(
		new InventoryItem
		{
			Category = "Computing Equipment",
			Name = "Ethernet Switch",
			WikiPage = "StevesEthernetSwitch",
			Size = "S",
			EntryDate = "2017-04-04",
			CurrentValue = 70.00M
		});
	inventory.Add(
		new InventoryItem
		{
			Category = "Computing Equipment",
			Name = "Xbox Wireless Headset",
			WikiPage = "XboxWirelessHeadset",
			Size = "S",
			EntryDate = "2021-04-21",
			CurrentValue = 100.00M
		});
	inventory.Add(
		new InventoryItem
		{
			Category = "Computing Equipment",
			Name = "Dual Monitors",
			WikiPage = "Dual Monitors",
			Size = "M",
			EntryDate = "2016-12-25",
			CurrentValue = 400.00M
		});
	inventory.Add(
		new InventoryItem
		{
			Category = "Computing Equipment",
			SubCategory = "Computer",
			Name = "Desktop PC",
			WikiPage = "Elsie",
			Size = "M",
			EntryDate = "2019-04-20",
			CurrentValue = 1200.00M
		});
	inventory.Add(
		new InventoryItem
		{
			Category = "Computing Equipment",
			SubCategory = "Computer",
			Name = "Mac Mini 2014",
			WikiPage = "MacMini2014",
			Size = "S",
			EntryDate = "2014",
			CurrentValue = 800.00M
		});
	inventory.Add(
		new InventoryItem
		{
			Category = "Computing Equipment",
			SubCategory = "Computer",
			Name = "Surface Pro 2",
			WikiPage = "DeLooch",
			Size = "S",
			EntryDate = "2013-12",
			ExitDate = "2021-04-01", 
			CurrentValue = 600.00M
		});
	inventory.Add(
		new InventoryItem
		{
			Category = "Computing Equipment",
			SubCategory = "Computer",
			Name = "Asus G74 Laptop",
			WikiPage = "Rice",
			Size = "M",
			EntryDate = "2011-11-05",
			CurrentValue = 400.00M
		});
	inventory.Add(
		new InventoryItem
		{
			Category = "Computing Equipment",
			SubCategory = "Computer",
			Name = "Mac Mini",
			WikiPage = "MacMini",
			Size = "S",
			EntryDate = "2005",
			CurrentValue = 100.00M
		});
	inventory.Add(
		new InventoryItem
		{
			Category = "Computing Equipment",
			SubCategory = "Computer",
			Name = "Vesuvius",
			WikiPage = "Vesuvius",
			Size = "M",
			EntryDate = "2000",
			ExitDate = "2018-05-19",
			CurrentValue = 10.00M
		});
	inventory.Add(
		new InventoryItem
		{
			Category = "Computing Equipment",
			SubCategory = "NAS",
			Name = "Synology DS418J",
			WikiPage = "SynologyDs418J",
			Size = "S",
			EntryDate = "2018-08-17",
			CurrentValue = 400.00M
		});

	return inventory;
}

public class Inventory
{
	public List<InventoryItem> Items { get; set; }
}

//public record InventoryItem(
//	string Category,
//	string Name,
//	string WikiPage,
//	string EntryDate,
//	string ExitDate,
//	decimal CurrentValue,
//	string Comments);
	
public record InventoryItem
{
	public string Category { get; init; }
	public string SubCategory { get; init; }	
	public string Name { get; init; }
	public string WikiPage { get; init; }
	public string Size { get; init; }
	public string EntryDate { get; init; }
	public string ExitDate { get; init; }
	public decimal CurrentValue { get; init; }
	public string Comments { get; init; }
	public string NameOut()
	{
		if (string.IsNullOrEmpty(WikiPage))
			return Name;
		return $"[{WikiPage} {Name}]";
	}
}