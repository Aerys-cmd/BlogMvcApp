using BlogMvcApp.Models;
using BlogMvcApp.Src.Entities;
using BlogMvcApp.Src.Repositories;
using BlogMvcApp.Src.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICommentRepository _commentRepository;
        private readonly ICommentService _commentService;
        private readonly IPostService _postService;


        public HomeController(ILogger<HomeController> logger, ICommentRepository commentRepository, ICommentService commentService, IPostService postService)
        {
            _logger = logger;
            _commentRepository = commentRepository;
            _commentService = commentService;
            _postService = postService;
        }


        public IActionResult Index(string filter, string Type)
        {
            var model = new List<BlogsViewModel>();
            List<Post> posts = new List<Post>();
            if (String.IsNullOrEmpty(filter)&&String.IsNullOrEmpty(Type))
            { 
                 posts = _postService.GetPosts();
            }
            else if(String.IsNullOrEmpty(Type))
            {
                RedirectToPage("Error");
            }
            else
            {
                if (Type=="Tag")
                {
                    posts = _postService.GetPostsByTagId(filter);
                }
                else if (Type=="Search")
                {
                    posts = _postService.GetPosts().Where(x => x.Title.Contains(filter) || x.Content.Contains(filter)).ToList();
                }
                else if (Type=="Category")
                {
                    posts = _postService.GetPosts().Where(x => x.CategoryId == filter).ToList();
                }
                else
                {
                    RedirectToPage("Error");
                }
            }

            foreach (var post in posts)
            {
                model.Add(new BlogsViewModel
                {
                    Post = post,
                    Tags = _postService.GetTagsByPostId(post.Id)
                });
            }

            return View(model);

        }

        public IActionResult PostDetails()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
