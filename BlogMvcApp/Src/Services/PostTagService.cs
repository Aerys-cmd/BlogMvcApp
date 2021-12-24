using BlogMvcApp.Src.Entities;
using BlogMvcApp.Src.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcApp.Src.Services
{
    public class PostTagService:IPostTagService
    {
        private readonly IPostTagRepository _postTagRepository;
        private readonly ITagService _tagService;
        

        public PostTagService(IPostTagRepository postTagRepository, ITagService tagService)
        {
            _postTagRepository = postTagRepository;
            _tagService = tagService;
            
        }

        public void AddTagToPost (string postId, string tagName)
        {
           var tagId= _tagService.IfNotExistAddAndReturnTagId(tagName);
            var postTag = new PostTag { PostId = postId, TagId = tagId };
            _postTagRepository.Add(postTag);
        }
        public List<PostTag> GetPostsByTagId(string tagId)
        {
            return _postTagRepository.List().Where(x => x.TagId == tagId).ToList();
        }

        public List<PostTag> GetTagsByPostId(string postId)
        {
            return _postTagRepository.List().Where(x => x.PostId == postId).ToList();
        }

    }
}
