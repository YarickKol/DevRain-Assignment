using AutoMapper;
using BlogREST_API.DTO;
using BlogREST_API.Models;

namespace BlogREST_API.Profiles
{
    /// <summary>
    /// Maps Model of Comment with his DTOs using AutoMapper
    /// </summary>
    public class CommentProfile:Profile
    {
        public CommentProfile()
        {
            // source -> target
            CreateMap<Comment, ReadCommentDTO>();
            CreateMap<CreateCommentDTO, Comment>();
        }
    }
}
