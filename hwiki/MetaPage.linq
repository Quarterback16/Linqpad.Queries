<Query Kind="Program">
  <Output>DataGrids</Output>
  <Namespace>Utes</Namespace>
</Query>

void Main()
{
	var page = new WikiPage();
	var meta = StaticMeta.GetMeta();
	DisplayMetaInstructions(
		page,
		meta);
	DisplayDeckTable(
		page,
		meta);
	Threading(
		page,
		"[[Forged in the Barrens]]",
		"Next-Meta" );
	page.RenderToConsole();
	Console.WriteLine(
		new LinqpadFile("MetaPage").FileOut());
}

void Threading(
	WikiPage page, 
	string forwardLink, 
	string backLink)
{
	page.AddElement(
		new WikiThreading(
			forwardLink,
			backLink ));
}

void DisplayDeckTable(
	WikiPage page,
	Meta meta)
{
	List<Deck> decks = meta.Decks;

	var table = new WikiTable();
	table.Columns.Add(new Utes.WikiColumn(""));
	table.Columns.Add(new Utes.WikiColumn("Name"));
	table.Columns.Add(new Utes.WikiColumn("Code"));
	table.Columns.Add(new Utes.WikiColumn("Tier"));
	table.Columns.Add(new Utes.WikiColumn("Comments"));
	table.AddRows( 
		decks.Count);  // one for each deck
	for (int r = 0; r < decks.Count; r++)
	{
		table.AddCell(
		   row: r + 1,
		   col: 1,
		   cellValue: decks[r].Name);
		table.AddCell(
		   row: r + 1,
		   col: 2,
		   cellValue: $"<nowiki>{decks[r].Code}</nowiki>");
		table.AddCell(
		   row: r + 1,
		   col: 3,
		   cellValue: decks[r].Tier.ToString());
		table.AddCell(
		   row: r + 1,
		   col: 4,
		   cellValue: decks[r].Comments);
	}
	page.AddElement(
		table);
}

void DisplayMetaInstructions(
	WikiPage page,
	Meta meta)
{
	page.AddElement(
		new WikiLine(
			$"Meta for {meta.Name}"));
	page.AddElement(
		new WikiBlank());
	var list = new string[] 
	{
		"Try out all the decks in casual to get a feel for them",
		$"Track Casual Champion via HS Deck Tracker (start new tag {meta.Tag}",
		"If deck wins a run in Casual, try on Ladder"		
	};
	page.AddElement(
		new WikiBulletList(
			list));
	page.AddElement(
		new WikiBlank());

}



