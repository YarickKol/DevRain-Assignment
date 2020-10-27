using System.Collections.Generic;

namespace BlogREST_API.Repositories
{
    /// <summary>
    /// Interface consists methods that represent linked data
    /// like one type consists another type inside
    /// </summary>
    /// <typeparam name="T">generic type</typeparam>
    public interface ILinkedActions<T> where T:class
    {
        /// <summary>
        /// Gets linked data by Primary Key of desired type
        /// </summary>
        /// <param name="id">Key</param>
        /// <returns></returns>
        public IEnumerable<T> GetLinkedInfo(int id);
    }
}
