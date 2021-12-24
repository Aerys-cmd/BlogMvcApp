using BlogMvcApp.Src.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BlogMvcApp.Src.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly BlogDbContext _db;
        public PostRepository(BlogDbContext db)
        {
            _db = db;
        }
        public void Add(Post entity)
        {
            _db.Posts.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(string Id)
        {
            var comment = _db.Posts.Find(Id);
            _db.Posts.Remove(comment);
            _db.SaveChanges();
        }

        public Post Find(string Id)
        {
            var comment = _db.Posts.Include(x=>x.Comments).Include(x=>x.Category).FirstOrDefault(x=>x.Id==Id);
            return comment;
        }

        public List<Post> List()
        {
            return _db.Posts.Include(x => x.Comments).Include(x => x.Category).ToList();
        }

        public void Update(Post entity)
        {
            _db.Posts.Update(entity);
            _db.SaveChanges();
        }

        public IQueryable<Post> Where(Expression<Func<Post, bool>> expression)
        {
            return _db.Posts.Include(x => x.Comments).Include(x => x.Category).Where(expression);
        }
    }
}
