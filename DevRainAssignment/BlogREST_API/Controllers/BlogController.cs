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

        /// <summary>
        /// Gets all blog DTO data  from database
        /// </summary>
        /// <returns>code of response (200)</returns>
        [ResponseCache(Location = ResponseCacheLocation.Any, Duration = 300)] //executing attribute caching
        [HttpGet]
        public ActionResult<IEnumerable<ReadBlogDTO>> GetAllBlogs()
        {
            var blogItems = _repository.GetAllItems();

            return Ok(_mapper.Map<IEnumerable<ReadBlogDTO>>(blogItems));
        }

        /// <summary>
        /// Gets one blog DTO data by Key  from database
        /// </summary>
        /// <returns>code of response (200) in case of data exists; code (404) if data not found</returns>
        [HttpGet("{id}")]
        public ActionResult<ReadBlogDTO> GetBlogById(int id)
        {
            var blogItem = _repository.GetItemById(id);
            if (blogItem != null)
                return Ok(_mapper.Map<ReadBlogDTO>(blogItem));
            return NotFound();
        }

        /// <summary>
        /// Creates Blog object using DTO and saves model to db
        /// </summary>
        /// <param name="createBlogDTO">new object Blog type</param>
        /// <returns>code 200 if item create succesfully and saved to db</returns>
        [HttpPost]
        public ActionResult<CreateBlogDTO> CreateBlog(CreateBlogDTO createBlogDTO)
        {
            var blogModel = _mapper.Map<Blog>(createBlogDTO);
            _repository.CreateItem(blogModel);
            _repository.SaveChanges();  

            var blogReadDTO = _mapper.Map<ReadBlogDTO>(blogModel);

            return Ok(blogReadDTO);
        }

    }
}
