using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogREST_API.DTO
{
    /// <summary>
    /// class defines the parameters for incoming requests
    /// </summary>
    public class UserAuthenticateRequest
    {
        public string Login { get; set; }       
        public string Password { get; set; }
    }
}
