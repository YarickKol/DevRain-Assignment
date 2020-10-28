using BlogREST_API.DTO;
using BlogREST_API.Interfaces;
using BlogREST_API.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace BlogREST_API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BlogContext _context; // database context
        private readonly AppSettings _appSettings;

        public UserRepository(BlogContext context, IOptions<AppSettings> appSettings)
        {
            _context = context;
            _appSettings = appSettings.Value;
        }
        public void CreateItem(User item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            _context.Users.Add(item);
        }

        public IEnumerable<User> GetAllItems()
        {
            return _context.Users.ToList();
        }

        /// <summary>
        /// method compares incoming data with data in DB contex
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public UserAuntethicateResponse Authenticate(UserAuthenticateRequest model)
        {
            var user = _context.Users.FirstOrDefault(x => x.Login == model.Login && x.Password == model.Password);

            // return null if user not found
            if (user == null) return null;

            // authentication successful so generate jwt token
            var token = GenerateJwtToken(user);

            return new UserAuntethicateResponse(user, token);
        }

        public User GetItemById(int id)
        {
            return _context.Users.SingleOrDefault(u => u.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        /// <summary>
        /// method generates a JWT (JSON Web Token) using the JwtSecurityTokenHandler 
        /// class which generates a token that is digitally signed using a secret key
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private string GenerateJwtToken(User user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
