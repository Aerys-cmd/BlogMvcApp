using BlogMvcApp.Src.Entities;
using BlogMvcApp.Src.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcApp.Src.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void AddCategory(Category category)
        {
            if (string.IsNullOrEmpty(category.Name))
            {
                throw new Exception("boş geçilemez.");
            }
            _categoryRepository.Add(category);
        }
        

        Category ICategoryService.GetCategoryById(string id)
        {
            var category = _categoryRepository.Find(id);
            return category;
        }

        List<Category> ICategoryService.GetAllCategory()
        {
            return _categoryRepository.List();
        }
    }
}
