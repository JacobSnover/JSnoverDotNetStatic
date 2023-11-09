using JSnoverDotNetStatic.DataTransferObjects.Interfaces;
using JSnoverDotNetStatic.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace JSnoverDotNetStatic.DataTransferObjects.BlogModels
{
    public class BlogCommentModel : CommonContact, IDtoMapper<BlogCommentModel, Commentors>
    {
        [Required]
        public int BlogId { get; set; }

        public static Commentors MapToDto(BlogCommentModel comment)
        {
            return new Commentors
            {
                BlogId = comment.BlogId,
                DatePosted = DateTime.Now.Date,
                Email = comment.Email,
                UserName = comment.Name ?? null,
                Liked = comment.Liked,
                Subscribe = comment.Subscribe,
                Body = comment.Body ?? string.Empty
            };
        }
    }
}
