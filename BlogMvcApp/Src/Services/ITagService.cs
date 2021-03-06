using BlogMvcApp.Src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcApp.Src.Services
{
    public interface ITagService
    {
        public void AddTag(Tag tag);

        public string IfNotExistAddAndReturnTagId(string name);

        public List<Tag> GetAllTags();
        public Tag GetTagById(string Id);
    }
}
