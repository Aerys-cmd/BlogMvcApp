using BlogMvcApp.Src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcApp.Models
{
    public class BlogsViewModel
    {
        public Post Post { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
