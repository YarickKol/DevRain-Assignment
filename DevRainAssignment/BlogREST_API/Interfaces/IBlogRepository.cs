using BlogREST_API.Models;
using BlogREST_API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogREST_API.Interfaces
{
    public interface IBlogRepository: IDefaultActions<Blog>
    {

    }
}
