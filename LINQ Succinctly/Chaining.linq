<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

void Main()
{
	Ingredient[] ingredients =
	{
		new Ingredient{Name = "Sugar", Calories=500},
		new Ingredient{Name = "Egg", Calories=100},
		new Ingredient{Name = "Milk", Calories=150},
		new Ingredient{Name = "Flour", Calories=50},
		new Ingredient{Name = "Butter", Calories=200}
	};
    IEnumerable<string> highCalorieIngredientNamesQuery = ingredients
		.Where(x => x.Calories >= 150)
		.OrderBy(x => x.Name)
		.Select(x => x.Name);  // projection 
	foreach (var ingredientName in highCalorieIngredientNamesQuery)
	{
		Console.WriteLine(ingredientName);
	}
}

class Ingredient
{
	public string Name { get; set; }
	public int Calories { get; set; }
}