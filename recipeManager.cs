using System;
using System.Collections.Generic;

public class RecipeManager
{
    private List<Recipe> recipes;

    // Constructor for RecipeManager class
    public RecipeManager()
    {
        recipes = new List<Recipe>();
    }

    // Add a new recipe
    public void AddRecipe()
    {
        Console.WriteLine("\nEnter the recipe name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the category (e.g., Breakfast, Lunch, Dinner):");
        string category = Console.ReadLine();

        Console.WriteLine("Enter ingredients (comma separated):");
        string ingredientsInput = Console.ReadLine();
        List<string> ingredients = new List<string>(ingredientsInput.Split(','));

        Console.WriteLine("Enter instructions:");
        string instructions = Console.ReadLine();

        Recipe newRecipe = new Recipe(name, category, ingredients, instructions);
        recipes.Add(newRecipe);

        Console.WriteLine("\nRecipe added successfully!");
    }

    // Search for a recipe by name
    public void SearchRecipe()
    {
        Console.WriteLine("\nEnter the recipe name to search:");
        string searchName = Console.ReadLine();

        bool found = false;
        foreach (Recipe recipe in recipes)
        {
            if (recipe.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
            {
                recipe.DisplayRecipe();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Recipe not found.");
        }
    }

    // Display all recipes in a specific category
    public void DisplayRecipesByCategory()
    {
        Console.WriteLine("\nEnter the category to display recipes:");
        string category = Console.ReadLine();

        bool found = false;
        foreach (Recipe recipe in recipes)
        {
            if (recipe.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
            {
                recipe.DisplayRecipe();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No recipes found in this category.");
        }
    }

    // Display all recipes
    public void DisplayAllRecipes()
    {
        if (recipes.Count == 0)
        {
            Console.WriteLine("No recipes added yet.");
            return;
        }

        Console.WriteLine("\nAll Recipes:");
        foreach (Recipe recipe in recipes)
        {
            recipe.DisplayRecipe();
        }
    }
}
