using BethanysPieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Services
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Fruit Pies",Decsription="All-fruity pies"},
                new Category{CategoryId=2,CategoryName="Chees cakes",Decsription="Cheesy all the way"},
                new Category{CategoryId=3,CategoryName="Seasonal Pie",Decsription="Get in the mood for a seasonal pie"}
            };
    }
}
