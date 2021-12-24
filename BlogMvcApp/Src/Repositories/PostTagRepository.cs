using BlogMvcApp.Src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BlogMvcApp.Src.Repositories
{
    public class PostTagRepository:IPostTagRepository
    {
        private readonly BlogDbContext _db;
        public PostTagRepository(BlogDbContext db)
        {
            _db = db;
        }
        public void Add(PostTag entity)
        {
            _db.PostTags.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(string Id)
        {
            var postTag = _db.PostTags.Find(Id);
            _db.PostTags.Remove(postTag);
            _db.SaveChanges();
        }

        public PostTag Find(string Id)
        {
            var postTag = _db.PostTags.Find(Id);
            return postTag;
        }

        public List<PostTag> List()
        {
            return _db.PostTags.ToList();
        }

        public void Update(PostTag entity)
        {
            _db.PostTags.Update(entity);
            _db.SaveChanges();
        }

        public IQueryable<PostTag> Where(Expression<Func<PostTag, bool>> expression)
        {
            return _db.PostTags.Where(expression);
        }
    }
}
