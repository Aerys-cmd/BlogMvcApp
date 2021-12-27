using BlogMvcApp.Src.Entities;
using BlogMvcApp.Src.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcApp.Src.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IPostTagService _postTagService;
        private readonly ITagService _tagService;
        


        public PostService(IPostRepository postRepository, IPostTagService postTagService, ITagService tagService)
        {
            _postRepository = postRepository;
            _postTagService = postTagService;
            _tagService = tagService;
            
        }

        public List<Post> GetPosts()
        {
            return _postRepository.List();
        }

        public Post GetPostById(string Id)
        {
            var post = _postRepository.Find(Id);
            return post;
        }

        public List<Post> GetPostsByCategoryId(string categoryId)
        {
            var posts = _postRepository.List().Where(x => x.CategoryId == categoryId).ToList();
            return posts;
        }
        public List<Post> GetPostsByTagId(string tagId)
        {
            //TODO: TagPostService'e bağlanarak gönderilen tagId ye sahip tüm postların PostId'leri döndürülecek. Burada bir algoritma kurularak gelen postIdlere sahip postlar
            //return edilecek.
            var posts = _postRepository.List().Where(x => x.TagId == tagId).ToList();
            return posts;

        }

        public void AddPost(Post post, string tagString)
        {
            _postRepository.Add(post);
            //TODO : tagler ayrılarak tek tek PostTagService içerisindeki AddTagToPost methoduna yönlendirilecek.Eğer tag veritabanında mevcut değil ise oluşturulacak ve veritabanına eklenecek. 
            var tags = tagString.Trim(',').Split(',').ToList();
            foreach (var tag in tags)
            {
                _postTagService.AddTagToPost(post.Id, tag);
            }


        }

        public List<Post> GetRecentPosts()
        {
            var recentPosts = _postRepository.List().OrderByDescending(x => x.PublishDate).Take(3).ToList();
            return recentPosts;
        }
        public List<Tag> GetTagsByPostId(string postId)
        {
            var postTags = _postTagService.GetTagsByPostId(postId);
            List<Tag> tags = new();
            foreach (var postTag in postTags)
            {
                tags.Add(_tagService.GetTagById(postTag.TagId));
            }
            return tags;

        }
    }
}
