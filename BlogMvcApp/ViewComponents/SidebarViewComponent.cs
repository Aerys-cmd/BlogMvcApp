using BlogMvcApp.Models;
using BlogMvcApp.Src.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcApp.ViewComponents
{
    public class SidebarViewComponent : ViewComponent
    {
        private readonly ITagService _tagservice;
        private readonly IPostService _postService;
        private readonly ICategoryService _categoryService;

        public SidebarViewComponent(ITagService tagservice, IPostService postService, ICategoryService categoryService)
        {
            _tagservice = tagservice;
            _postService = postService;
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var tags = _tagservice.GetAllTags();
            var posts = _postService.GetRecentPosts();
            var categories = _categoryService.GetAllCategories();
            var model = new SidebarModel();
            model.Categories = categories;
            model.Tags = tags;
            model.RecentPosts = posts;
            return View(await Task.FromResult(model));
        }
    }
}
