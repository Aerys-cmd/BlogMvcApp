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

            return View(await Task.FromResult(model));
        }
    }
}
