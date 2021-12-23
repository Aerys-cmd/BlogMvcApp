using BlogMvcApp.Src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcApp.Src.Services
{
    public interface ICategoryService
    {
        void AddCategory(Category category);
        /// <summary>
        /// category id'ye göre veritabanından ilgili category çekilir ve döndürülür.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Category GetCategoryById(string id);
        /// <summary>
        /// veritabanında kayıtlı olan bütün categoryleri getirir.
        /// </summary>
        /// <returns></returns>
        List<Category> GetAllCategory();
    }
}
