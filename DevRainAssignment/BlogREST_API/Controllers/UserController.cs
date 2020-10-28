using AutoMapper;
using BlogREST_API.DTO;
using BlogREST_API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogREST_API.Controllers
{
    [ApiController]
    [Route("api/users")] 
    public class UserController:Controller
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public UserController(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(UserAuthenticateRequest model)
        {
            
            var response = _repository.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });           

            return Ok(response);
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAllUser()   
        {
            var users = _repository.GetAllItems();
            return Ok(users);
        }
    }
}
