using AutoMapper;
using BlogREST_API.DTO;
using BlogREST_API.Models;

namespace BlogREST_API.Profiles
{
    public class CommentProfile:Profile
    {
        public CommentProfile()
        {
            CreateMap<Comment, ReadCommentDTO>();
            CreateMap<CreateCommentDTO, Comment>();
        }
    }
}
