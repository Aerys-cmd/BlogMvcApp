using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcApp.Src.Entities
{
    public class PostTag
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string PostId { get; set; } //1 1 1 2
        public string TagId { get; set; }//1 2 3 1

    }
}
