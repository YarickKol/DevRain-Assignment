using BlogREST_API.Models;
using BlogREST_API.Repositories;

namespace BlogREST_API.Interfaces
{
    /// <summary>
    /// Interface that unites methods of IDefaultActions and ILinkedActions of Comment type for
    /// Comment Repository realization
    /// </summary>
    public interface ICommentRepository:IDefaultActions<Comment>, ILinkedActions<Comment>
    {
      
    }
}
