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

        public HomeController(ILogger<HomeController> logger, ICommentRepository commentRepository,ICommentService commentService)
        {
            _logger = logger;
            _commentRepository=commentRepository;
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            
          
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
