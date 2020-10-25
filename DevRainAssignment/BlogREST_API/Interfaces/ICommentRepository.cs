using BlogREST_API.Models;
using BlogREST_API.Repositories;

namespace BlogREST_API.Interfaces
{
    public interface ICommentRepository:IDefaultActions<Comment>, ILinkedActions<Comment>
    {
      
    }
}
