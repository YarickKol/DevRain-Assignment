using AutoMapper;
using BlogREST_API.DTO;
using BlogREST_API.Models;

namespace BlogREST_API.Profiles
{
    /// <summary>
    /// Maps Model of Blog with his DTOs using AutoMapper
    /// </summary>
    public class BlogProfile:Profile
    {
        public BlogProfile()
        {
            // source -> target
            CreateMap<Blog, ReadBlogDTO>();
            CreateMap<CreateBlogDTO, Blog>();
        }
    }
}
