using BlogMvcApp.Src.Entities;
using BlogMvcApp.Src.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcApp.Src.Services
{
    public class CommentService:ICommentService
    {

        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public void AddComment(Comment comment)
        {
            //İş kuralları

            if (comment.Name.Contains("Ş"))
            {
                throw new Exception("Eklemiyemm");
            }
            if (comment.Name.Contains("Ş"))
            {
                throw new Exception("Eklemiyemm");
            }
            if (comment.Name.Contains("Ş"))
            {
                throw new Exception("Eklemiyemm");
            }

            _commentRepository.Add(comment);

        }

        public List<Comment> GetComment()
        {
            return _commentRepository.List();
        }

        public Comment GetCommentById(string id)
        {
            var comment = _commentRepository.Find(id);
            return comment;
        }
    }
}
