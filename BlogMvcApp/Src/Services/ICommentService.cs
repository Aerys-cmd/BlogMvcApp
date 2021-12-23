using BlogMvcApp.Src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcApp.Src.Services
{
    public interface ICommentService
    {
        public void AddComment(Comment comment);
        /// <summary>
        /// veritabanında kayıtlı olan commentleri getirir.
        /// </summary>
        /// <returns></returns>
        List<Comment> GetComment();
        /// <summary>
        /// comment id'te göre ilgili comment çekilir ve döndürülür.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Comment GetCommentById(string id);

    }
}
