using BlogMvcApp.Src.Entities;
using BlogMvcApp.Src.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcApp.Src.Services
{
    public class PostService:IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IPostTagService _postTagService;

        public PostService(IPostRepository postRepository, IPostTagService postTagService)
        {
            _postRepository = postRepository;
            _postTagService = postTagService;
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
            throw new NotImplementedException();
            
        }

        public void AddPost(Post post,string tagString)
        {
            _postRepository.Add(post);
            //TODO : tagler ayrılarak tek tek PostTagService içerisindeki AddTagToPost methoduna yönlendirilecek.Eğer tag veritabanında mevcut değil ise oluşturulacak ve veritabanına eklenecek. 
            var tags = tagString.Trim(',').Split(',').ToList();
            foreach (var tag in tags)
            {
                _postTagService.AddTagToPost(post.Id, tag);
            }


        }
    }
}
