using AutoMapper;
using BlogREST_API.DTO;
using BlogREST_API.Interfaces;
using BlogREST_API.Models;
using BlogREST_API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BlogREST_API.Controllers
{
    [Route("api/blogs")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogRepository _repository;        
        private readonly IMapper _mapper;        

        public BlogController(IBlogRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;            
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReadBlogDTO>> GetAllBlogs()
        {
            var blogItems = _repository.GetAllItems();

            return Ok(_mapper.Map<IEnumerable<ReadBlogDTO>>(blogItems));
        }

        [HttpGet("{id}")]
        public ActionResult<ReadBlogDTO> GetBlogById(int id)
        {
            var blogItem = _repository.GetItemById(id);
            if (blogItem != null)
                return Ok(_mapper.Map<ReadBlogDTO>(blogItem));
            return NotFound();
        }

        [HttpPost]
        public ActionResult<CreateBlogDTO> CreateCommand(CreateBlogDTO createBlogDTO)
        {
            var blogModel = _mapper.Map<Blog>(createBlogDTO);
            _repository.CreateItem(blogModel);
            _repository.SaveChanges();  

            var commandReadDTO = _mapper.Map<CreateBlogDTO>(blogModel);

            return Ok(commandReadDTO);
        }

    }
}
