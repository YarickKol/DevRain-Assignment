using AutoMapper;
using BlogREST_API.Models;
using BlogREST_API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogREST_API.Controllers
{
    [Route("api/blogs")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IRepository<Blog> _repository;        
        private readonly IMapper _mapper;

        public BlogController(IRepository<Blog> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Blog>> GetAllBlogs()
        {
            var blogItems = _repository.GetAllItems();

            return Ok(blogItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Blog> GetBlogById(int id)
        {
            var blogItem = _repository.GetItemById(id);
            if (blogItem != null)
                return Ok(blogItem);
            return NotFound();
        }

        //[HttpGet("{id}")]
        //public ActionResult<IEnumerable<Comment>> GetCommentsofBlogById(int id)
        //{
        //    var blogItems = _repository.GetAllCommentsOfBlogById(id);
        //    return Ok(blogItems);
        //}

        //[HttpPost]
        //public ActionResult<CommandCreateDTO> CreateCommand(CommandCreateDTO commandCreateDTO)
        //{
        //    var commandModel = _mapper.Map<Command>(commandCreateDTO);
        //    _repository.CreateCommand(commandModel);
        //    _repository.SaveChanges();

        //    var commandReadDTO = _mapper.Map<CommandReadDTO>(commandModel);

        //    return Ok(commandReadDTO);
        //}

    }
}
