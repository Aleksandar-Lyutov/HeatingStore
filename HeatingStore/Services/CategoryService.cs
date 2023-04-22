using HeatingStore.Abstraction;
using HeatingStore.Data;
using HeatingStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeatingStore.Services
{
    public class CategoryService:ICategoryService
    {
        private readonly ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Category GetCategoryById(int categoryId)
        {
            return _context.Categories.Find(categoryId);
        }
        public List<Category> GetCategories()
        {
            List<Category> categories = _context.Categories.ToList();
            return categories;
        }
        public List<HeatingDevice> GetHeatingDevicesByCategory(int categoryId)
        {
            return _context.HeatingDevices
                .Where(x => x.CategoryId == categoryId)
                .ToList();
        }
    }
}
