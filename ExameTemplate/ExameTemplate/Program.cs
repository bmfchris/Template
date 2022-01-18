using System;
using System.Collections.Generic;

namespace ExameTemplate
{
    class Program
    {
/*
 * Scenerio:
 * Description:
 *          The below code was created to determine which of the following lists contain values. 
 * List:
 *          _upList
 *          _downList
 *          _leftList
 *          _rightList
 *          _nowhereList
 *  
 *  Requirements: 
 *          1. Determine if the lists contain values (are they empty or not). The number of entries in each list is NOT needed.
 *          2. Display the results to the console.
 *  
 *  Goal:
 *          Optimize the below code to fill the requirements. You are free to use any code chooses and libraries you desire. *  
 */
        static void Main(string[] args)
        {
            ICategoriesRepository categories = new CategoriesRepository();
            List<Category> _categoriesList = categories.GetAllCategories();
            List<Category> _upList = new();
            List<Category> _downList = new();
            List<Category> _leftList = new();
            List<Category> _rightList = new();
            List<Category> _nowhereList = new();


            Console.WriteLine($"Total category entries count: {_categoriesList.Count}\n\n");

            foreach (Category category in _categoriesList)
            {
                string[] TitleNames = Titles.GetTitles();

                if (category.Title == TitleNames[0])
                {
                    _upList.Add(category);
                }
                if (category.Title == TitleNames[1])
                {
                    _downList.Add(category);
                }
                if (category.Title == TitleNames[2])
                {
                    _leftList.Add(category);
                }
                if (category.Title == TitleNames[3])
                {
                    _rightList.Add(category);
                }
                if (category.Title == TitleNames[4])
                {
                    _nowhereList.Add(category);
                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            if (_upList.Count > 0)
                Console.WriteLine($"Up list has values.\n");
            else
                Console.WriteLine($"Up list is empty.\n");

            Console.ForegroundColor = ConsoleColor.Green;
            if (_downList.Count > 0)
                Console.WriteLine($"Down list has values.\n");
            else
                Console.WriteLine($"Down list is empty.\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            if (_leftList.Count > 0)
                Console.WriteLine($"Left list has values.\n");
            else
                Console.WriteLine($"Left list is empty.\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            if (_rightList.Count > 0)
                Console.WriteLine($"Right list has values.\n");
            else
                Console.WriteLine($"Right list is empty.\n");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (_nowhereList.Count > 0)
                Console.WriteLine($"No Where list has values.\n");
            else
                Console.WriteLine($"No Where list is empty.\n");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n");

        }
    }

}
