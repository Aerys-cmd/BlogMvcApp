using BlogMvcApp.Src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcApp.Src.Services
{
    public interface IPostTagService
    {
        public void AddTagToPost(string postId, string tagName);
        public List<PostTag> GetPostsByTagId(string tagId);
        public List<PostTag> GetTagsByPostId(string postId);



    }
}
