using BlogREST_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogREST_API.DTO
{
    public class UserAuntethicateResponse
    {
        /// <summary>
        /// class defines the data returned after successful authentication
        /// </summary>
        public int Id { get; set; }      
        public string Username { get; set; }
        public string Token { get; set; }


        public UserAuntethicateResponse(User user, string token)
        {
            Id = user.Id;
            Username = user.Login;
            Token = token;
        }
    }
}
