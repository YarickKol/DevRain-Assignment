using AutoMapper;
using BlogREST_API.DTO;
using BlogREST_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogREST_API.Profiles
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            // source -> target
            CreateMap<User, UserAuntethicateResponse>();
            CreateMap<UserAuthenticateRequest, User>();
        }
    }
}
