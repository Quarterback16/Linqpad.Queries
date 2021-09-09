<Query Kind="Program">
  <Namespace>System</Namespace>
  <Namespace>System.Collections</Namespace>
</Query>

public class Collection : CollectionBase
{
	public void Add(Object item)
	{
		InnerList.Add(item);
	}
	public void Remove(Object item)
	{
		InnerList.Remove(item);
	}
	public new void Clear()
	{
		InnerList.Clear();
	}
	public new int Count()
	{
		return InnerList.Count;
	}
}

public class chapter1
{
	static void Main()
	{
		Collection names = new Collection();
		names.Add("David");
		names.Add("Bernica");
		names.Add("Raymond");
		names.Add("Clayton");
		foreach (Object name in names)
			Console.WriteLine(name);
		Console.WriteLine(
			"Number of names: " + names.
			Count());
		names.Remove("Raymond");
		Console.WriteLine("Number of names: " + names.
		Count());
		names.Clear();
		Console.WriteLine("Number of names: " + names.
		Count());
	}
}
