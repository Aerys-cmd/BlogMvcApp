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

        public HomeController(ILogger<HomeController> logger, ICommentRepository commentRepository,ICommentService commentService, IPostService postService)
        {
            _logger = logger;
            _commentRepository=commentRepository;
            _commentService = commentService;
            _postService = postService;
        }

        public IActionResult Index()
        {
            //var post = new Post
            //{
            //    CategoryId = "cf948950-e54f-4615-a893-d12a6803e945",
            //    AuthorName = "Recep",
            //    Content="Bu sitedeki 2. yayın",
            //    PublishDate=DateTime.Now,
            //    Title="2. Deneme Yayını"
            //};
            //_postService.AddPost(post, ",C#,DotNetCore,Nbuy");
          
            return View();
        }

        public IActionResult Privacy()
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
