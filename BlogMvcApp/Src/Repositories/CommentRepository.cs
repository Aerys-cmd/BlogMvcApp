using BlogMvcApp.Src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcApp.Src.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly BlogDbContext _db;
        public CommentRepository(BlogDbContext db)
        {
            _db = db;
        }
        public void Add(Comment entity)
        {
            _db.Comments.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(string Id)
        {
            var comment = _db.Comments.Find(Id);
            _db.Comments.Remove(comment);
            _db.SaveChanges();
        }

        public Comment Find(string Id)
        {
            var comment = _db.Comments.Find(Id);
            return comment;
        }

        public List<Comment> List()
        {
            return _db.Comments.ToList();
        }

        public void Update(Comment entity)
        {
            _db.Comments.Update(entity);
            _db.SaveChanges();
        }
    }
}
