using System.Collections.Generic;
using AutoMapper;
using BlogREST_API.DTO;
using BlogREST_API.Interfaces;
using BlogREST_API.Models;
using BlogREST_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BlogREST_API.Controllers
{
    [Route("api/blogs/{id}/comments")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICommentRepository _repository;

        public CommentController(ICommentRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ReadCommentDTO>> GetCommentsofBlogById(int id)
        {
            var blogItems = _repository.GetLinkedInfo(id);

            return Ok(_mapper.Map<IEnumerable<ReadCommentDTO>>(blogItems));
        }

        [HttpPost]
        public ActionResult<CreateCommentDTO> CreateComment(CreateCommentDTO createCommentDTO)
        {
            var commentModel = _mapper.Map<Comment>(createCommentDTO);            
            _repository.CreateItem(commentModel);
            _repository.SaveChanges();

            var commentReadDTO = _mapper.Map<ReadCommentDTO>(commentModel);

            return Ok(commentReadDTO);
        }
    }
}
