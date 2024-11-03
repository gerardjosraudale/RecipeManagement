using System;
using System.Collections.Generic;

public struct Recipe
{
    public string Name;
    public string Category;
    public List<string> Ingredients;
    public string Instructions;

    // Constructor for Recipe struct
    public Recipe(string name, string category, List<string> ingredients, string instructions)
    {
        Name = name;
        Category = category;
        Ingredients = ingredients;
        Instructions = instructions;
    }

    // Display recipe details
    public void DisplayRecipe()
    {
        Console.WriteLine($"\nRecipe Name: {Name}");
        Console.WriteLine($"Category: {Category}");
        Console.WriteLine("Ingredients:");
        foreach (string ingredient in Ingredients)
        {
            Console.WriteLine($"- {ingredient}");
        }
        Console.WriteLine($"Instructions: {Instructions}");
    }
}
