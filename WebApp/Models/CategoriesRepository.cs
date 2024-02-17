using Microsoft.AspNetCore.Mvc;

namespace WebApp.Models
{
    public class CategoriesRepository : Controller
    {
        private static List<Category> _categories = new List<Category>()
        {
            new Category { CategoryId = 1, Name = "Beverage", Description = "Beverage"},
            new Category { CategoryId = 2, Name = "Bakery", Description = "Bakery"},
            new Category { CategoryId = 3, Name = "Meat", Description = "Meat"}

        };

        public static void AddCategory(Category category)
        {
            _categories.Add(category);
        }

        public static List<Category> GetCategories() => _categories;

        public static Category? GetCategoryById(int categoryId)
        {
            return _categories.FirstOrDefault(c => c.CategoryId == categoryId);
        }
        public static void UpdateCategory(int categoryId, Category category)
        {
            if(categoryId != category.CategoryId) return;
        }
        public virtual void DeleteCategory(int categoryId) 
        {
            var category = _categories.FirstOrDefault(x => x.CategoryId == categoryId);
            if(category != null)
            {
                _categories.Remove(category);
            }
        }

    }
}
