using System.Collections.Generic;
using AutoMapper;
using BlogREST_API.DTO;
using BlogREST_API.Interfaces;
using BlogREST_API.Models;
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

        /// <summary>
        /// Gets collection of comments DTO data by Blog Key from database
        /// </summary>
        /// <returns>code of response (200);</returns>
        [HttpGet]
        public ActionResult<IEnumerable<ReadCommentDTO>> GetCommentsofBlogById(int id)
        {
            var blogItems = _repository.GetLinkedInfo(id);

            return Ok(_mapper.Map<IEnumerable<ReadCommentDTO>>(blogItems));
        }

        /// <summary>
        /// Creates Comment to blog object using DTO and saves model to db
        /// </summary>
        /// <param name="createCommentDTO">new object Comment type</param>
        /// <returns>code 200 if item create succesfully and saved to db</returns>
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
