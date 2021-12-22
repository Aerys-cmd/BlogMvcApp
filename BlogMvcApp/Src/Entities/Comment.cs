using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcApp.Src.Entities
{
    public class Comment
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        public string PostId { get; set; }
        public Post Post { get; set; }

    }
}
