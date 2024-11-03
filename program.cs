using System;

public class Program
{
    public static void Main(string[] args)
    {
        RecipeManager manager = new RecipeManager();
        
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nRecipe Management System");
            Console.WriteLine("1. Add Recipe");
            Console.WriteLine("2. Search Recipe");
            Console.WriteLine("3. Display Recipes by Category");
            Console.WriteLine("4. Display All Recipes");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    manager.AddRecipe();
                    break;
                case "2":
                    manager.SearchRecipe();
                    break;
                case "3":
                    manager.DisplayRecipesByCategory();
                    break;
                case "4":
                    manager.DisplayAllRecipes();
                    break;
                case "5":
                    exit = true;
                    Console.WriteLine("Exiting the system...");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
