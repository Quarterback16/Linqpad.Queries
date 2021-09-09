<Query Kind="Program">
  <Output>DataGrids</Output>
  <Namespace>Utes</Namespace>
</Query>

void Main()
{
	var meta = StaticMeta.GetMeta();
	var page = new WikiPage();
    DeckHints(
		meta: meta.Name,
		deckName: "Elemental Shaman",
		page: page);
	MatchUps(
		page,
		meta);
	page.RenderToConsole();
}

void MatchUps(
	WikiPage page,
	Meta meta)
{
	foreach (var deck in meta.Decks)
	{
		if (deck.Tier > 2)
			continue;
		AddSection(
			page,
			$"Versus: [[{deck.Name}]]",
			new string[]
			{
				"?"
			});
	}
}

private void DeckHints(
    string meta,
    string deckName,
	WikiPage page )
{
	var header = new WikiHeading(
		2,
		$"Meta: [[{meta}]] {deckName}");	
	page.AddElement(header);
	page.AddElement(new WikiBlank());
	AddSection(
		page,
		"Game plan",
		new string[]
		{
			"Gradually take over the Board",
		});
	AddSection(
		page,
		"Key Plays",
		new string[]
		{
			"Hex with ur Lilypad",
			"Combine the Whack with the Wind furies",
			"Use Brukan with Dunk, Lightning and Serp Portal",
		});
	AddSection(
		page,
		"Mulligans",
		new string[]
		{
			"Always : Kindling Elemental",
			"Always : Wailing Vapor",
			"Always : Cagematch Custodian",
			"Conditional : Arid Stormer (with Kindling)",
			"Conditional : Primal Dungeoneer (with 1 and 2 drop)",
		});
	//var table = new WikiTable();
	//table.Columns.Add(new Utes.WikiColumn(""));
	//table.Columns.Add(new Utes.WikiColumn("Name"));
	//table.Columns.Add(new Utes.WikiColumn("Code"));
	//table.Columns.Add(new Utes.WikiColumn("Tier"));
	//table.Columns.Add(new Utes.WikiColumn("Comments"));
	//table.AddRows(
	//	decks.Count);  // one for each deck
}

private void AddSection(
	WikiPage page,
	string header,
	string[] list)
{
	var hints = new WikiBulletList(
		list,
		header);
	page.AddElement(hints);
	page.AddElement(new WikiBlank());
}