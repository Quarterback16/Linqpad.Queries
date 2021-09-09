<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	IEnumerable<Recipe> recipes = new[]
	{
		 new Recipe {Id = 1, Name = "Apple Pie", Rating = 5},
		 new Recipe {Id = 2, Name = "Cherry Pie", Rating = 2},
		 new Recipe {Id = 3, Name = "Beef Pie", Rating = 3}
	};

	Dictionary<int, Recipe> dict = recipes.ToDictionary(x => x.Id);

	foreach (KeyValuePair<int, Recipe> item in dict)
	{
		Console.WriteLine("Key = {0}, Recipe = {1}", item.Key, item.Value.Name);
	};
}


class Recipe
{
	public int Id { get; set; }
	public string Name { get; set; }
	public int Rating { get; set; }
}
