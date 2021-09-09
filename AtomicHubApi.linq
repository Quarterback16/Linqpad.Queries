<Query Kind="Program">
  <Output>DataGrids</Output>
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>System.Net</Namespace>
</Query>

void Main()
{

    ListMarketPlaces();
	
	//ListCollections();
	
	//ListSchemas();2
	
	//ListSales();

}

private void ListSales()
{
	try
	{
		using (WebClient webClient = new WebClient())
		{
			webClient.BaseAddress = "https://wax.api.atomicassets.io/";
			var json = webClient.DownloadString("atomicmarket/v1/sales");
			json.Dump();
			//var list = JsonConvert.DeserializeObject<SchemaInfo>(json);
			//var query = list.Schemas.CollecOrderBy(mp=>mp.Collection.Name).ToList();
			//var theList = list.Schemas;
			//var query = theList.Select(
			//	x => new { Name = x.Collection.Name });
			//query.OrderBy(c => c.Name).Dump();
		}
	}
	catch (WebException ex)
	{
		throw ex;
	}
}


private void ListMarketPlaces()
{
	try
	{
		using (WebClient webClient = new WebClient())
		{
			webClient.BaseAddress = "https://wax.api.atomicassets.io/";
			var json = webClient.DownloadString("atomicmarket/v1/marketplaces");
			//json.Dump();
			var list = JsonConvert.DeserializeObject<MarketPlaceInfo>(json);
			var theList = list.MarketPlaces;
			var query = theList.Select(
				x => new { Name = x.Name });
			query.OrderBy(c => c.Name).Dump();
		}
	}
	catch (WebException ex)
	{
		throw ex;
	}
}

private void ListCollections()
{
	try
	{
		using (WebClient webClient = new WebClient())
		{
			webClient.BaseAddress = "https://wax.api.atomicassets.io/";
			var json = webClient.DownloadString("atomicassets/v1/collections");
			json.Dump();
			var list = JsonConvert.DeserializeObject<CollectionInfo>(json);
			var theList = list.Collections;
			var query = theList.Select(
				x => new { Name = x.Name, Collection = x.CollectionName });
			query.OrderBy(c => c.Name).Dump();
		}
	}
	catch (WebException ex)
	{
		throw ex;
	}
}

private void ListSchemas()
{
	try
	{
		using (WebClient webClient = new WebClient())
		{
			webClient.BaseAddress = "https://wax.api.atomicassets.io/";
			var json = webClient.DownloadString("atomicassets/v1/schemas");
			json.Dump();
			var list = JsonConvert.DeserializeObject<SchemaInfo>(json);
			//var query = list.Schemas.CollecOrderBy(mp=>mp.Collection.Name).ToList();
			var theList = list.Schemas;
			var query = theList.Select(
				x => new { Name = x.Collection.Name });
			query.OrderBy(c => c.Name).Dump();
		}
	}
	catch (WebException ex)
	{
		throw ex;
	}
}

public class SchemaInfo
{
	[JsonProperty("success")]
	public bool Success { get; set; }

	[JsonProperty("data")]
	public List<Schema> Schemas { get; set; }
}

public class Schema
{
	public Collection Collection {get; set;}
	
}

public class CollectionInfo
{
	[JsonProperty("success")]
	public bool Success { get; set; }

	[JsonProperty("data")]
	public List<Collection> Collections { get; set; }
}

public class Collection
{
	[JsonProperty("name")]
	public string Name { get; set; }
	[JsonProperty("collection_name")]
	public string CollectionName { get; set; }
}

public class MarketPlaceInfo
{
	[JsonProperty("success")]
	public bool Success { get; set; }
	
	[JsonProperty("data")]
	public List<MarketInfo> MarketPlaces { get; set; }

}

public class MarketInfo
{
	[JsonProperty("marketplace_name")]
	public string Name { get; set; }
}
