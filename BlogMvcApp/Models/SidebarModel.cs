using BlogMvcApp.Src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcApp.Models
{
    public class SidebarModel
    {
        public List<Tag> Tags { get; set; }
        public List<Category> Categories { get; set; }
        public List<Post> RecentPosts { get; set; }

    }
}
