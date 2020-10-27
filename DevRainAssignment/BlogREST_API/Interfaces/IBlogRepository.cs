using BlogREST_API.Models;
using BlogREST_API.Repositories;

namespace BlogREST_API.Interfaces
{
    /// <summary>
    /// Interface that unites methods of IDefaultActions of Blog type for
    /// Blog Repository realization
    /// </summary>
    public interface IBlogRepository: IDefaultActions<Blog>
    {

    }
}
