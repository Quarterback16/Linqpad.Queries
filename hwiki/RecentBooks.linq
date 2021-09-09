<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	var bookRootFolder = "b:\\it";
	var fileEntries = IdentifyNewBooks(bookRootFolder);
	var query1 = fileEntries
		.Where( b => b.LastWriteTime.Year == 2021 && b.LastWriteTime.Month == 8 )
		.Select( b => new Book
		{
			Topic = TopicFrom(b, bookRootFolder),
			Title = TitleFrom(
				b.Name, 
				b.Extension),
			Format = b.Extension.Replace(".",string.Empty),
			AccessDate = b.LastWriteTime
		})
		.OrderBy(o=>o.Topic)
		.Dump();
	foreach (var item in query1)
	{
		CreateMdFile(item);
	}
}

string TopicFrom(
	FileInfo b,
	string rootFolder)
{
	var path = b.DirectoryName
		.Replace(
			rootFolder,
			string.Empty)
		.Replace(
			@"\",
			string.Empty);
	return path;
}

void CreateMdFile(
	Book book)
{
//	---
//tags: [book, Inspirational]
//author: Jim Kwik
//year: 2020
//format: epub
//-- -
	var md = new StringBuilder();
	md.Append(book.Title);
	
	
}

string TitleFrom(
	string name,
	string extension)
{
	return name.Replace(
		extension,
		string.Empty);
}

List<FileInfo> IdentifyNewBooks(
	string targetDirectory)
{
	var list = new List<FileInfo>();
	var fileEntries = Directory.GetFiles(
		targetDirectory,
		"*.*",
		SearchOption.AllDirectories);
	foreach (var file in fileEntries)
	{
		var fileInfo = new FileInfo(file);
		if (ExtensionSaysBook(fileInfo.Extension))
			list.Add(fileInfo);
	}
	return list;
}

bool ExtensionSaysBook(
	string extension)
{
	if (extension.ToLower() == ".pdf")
		return true;
	if (extension.ToLower() == ".epub")
		return true;
	return false;
}


public class Book
{
	public string Topic { get; set; }
	public string Title { get; set; }
	public string Format { get; set; }
	public DateTime AccessDate { get; set; }

}