using BlogMvcApp.Src.Entities;
using BlogMvcApp.Src.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcApp.Src.Services
{
    public class TagService : ITagService
    {
        private readonly ITagRepository _tagRepository;

        public TagService(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public void AddTag(Tag tag)
        {
            // kurallar

            _tagRepository.Add(tag);

        }

        public string IfNotExistAddAndReturnTagId(string name)
        {
            if (_tagRepository.List().Any(x => x.Name == name))
            {
                return GetTagIdByName(name);
            }
            else
            {
                var tag = new Tag
                {
                    Name = name
                };
                AddTag(tag);
                return GetTagIdByName(name);
            }
        }

        private string GetTagIdByName(string name)
        {
            var a = _tagRepository.List().Where(x => x.Name == name).Select(x => x.Id).FirstOrDefault();
            return a;
        }

        public List<Tag> GetAllTags()
        {
           return _tagRepository.List();
        }
    }
}
