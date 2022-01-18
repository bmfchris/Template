using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExameTemplate
{
    public class CategoriesRepository : ICategoriesRepository
    {
        public List<Category> GetAllCategories()
        {
            List<Category> categories = new();

            string [] titles = Titles.GetTitles();
            for (int index = 0; index < titles.Count() - 1; index++)
            {
                Random rand = new Random();

                int RandomNumber = rand.Next(50, 200);

                for (int innerIndex = 0; innerIndex < RandomNumber; innerIndex++)
                {
                    Category category = new()
                    {
                        Title = titles[index],
                        Value = index + innerIndex
                    };
                    categories.Add(category);
                }
            }

            return categories;
        }
    }
}
