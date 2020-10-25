using System.Collections.Generic;

namespace BlogREST_API.Repositories
{
    public interface ILinkedActions<T> where T:class
    {
        public IEnumerable<T> GetLinkedInfo(int id);
    }
}
