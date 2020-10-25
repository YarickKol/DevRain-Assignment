using AutoMapper;
using BlogREST_API.DTO;
using BlogREST_API.Models;

namespace BlogREST_API.Profiles
{
    public class BlogProfile:Profile
    {
        public BlogProfile()
        {
            CreateMap<Blog, ReadBlogDTO>();
            CreateMap<CreateBlogDTO, Blog>();
        }
    }
}
