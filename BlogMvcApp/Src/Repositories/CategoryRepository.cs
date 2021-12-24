using BlogMvcApp.Src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BlogMvcApp.Src.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BlogDbContext _db;
        public CategoryRepository(BlogDbContext db)
        {
            _db = db;
        }
        public void Add(Category entity)
        {
            _db.Categories.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(string Id)
        {
            var comment = _db.Comments.Find(Id);
            _db.Comments.Remove(comment);
            _db.SaveChanges();
        }

        public Category Find(string Id)
        {
            var category = _db.Categories.Find(Id);
            return category;
        }

        public List<Category> List()
        {
            return _db.Categories.ToList();
        }

        public void Update(Category entity)
        {
            _db.Categories.Update(entity);
            _db.SaveChanges();
        }

        public IQueryable<Category> Where(Expression<Func<Category, bool>> expression)
        {
            return _db.Categories.Where(expression);
        }
    }
}
