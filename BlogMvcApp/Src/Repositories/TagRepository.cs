using BlogMvcApp.Src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcApp.Src.Repositories
{
    public class TagRepository:ITagRepository
    {
        private readonly BlogDbContext _db;
        public TagRepository(BlogDbContext db)
        {
            _db = db;
        }
        public void Add(Tag entity)
        {
            _db.Tags.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(string Id)
        {
            var tag = _db.Tags.Find(Id);
            _db.Tags.Remove(tag);
            _db.SaveChanges();
        }

        public Tag Find(string Id)
        {
            var tag = _db.Tags.Find(Id);
            return tag;
        }

        public List<Tag> List()
        {
            return _db.Tags.ToList();
        }

        public void Update(Tag entity)
        {
            _db.Tags.Update(entity);
            _db.SaveChanges();
        }

    }
}
