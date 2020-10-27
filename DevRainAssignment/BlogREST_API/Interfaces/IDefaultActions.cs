using System.Collections.Generic;

namespace BlogREST_API.Repositories
{
    /// <summary>
    /// Interface consists default methods of create, get and save to db of object type
    /// </summary>
    /// <typeparam name="T">generic type</typeparam>
    public interface IDefaultActions <T> where T: class
    {
        /// <summary>
        /// Saves data to database
        /// </summary>
        /// <returns></returns>
        bool SaveChanges();

        /// <summary>
        /// Returns all data of type from db set
        /// </summary>
        /// <returns>Collection of data</returns>
        IEnumerable<T> GetAllItems();

        /// <summary>
        /// Returns  data of type from db set bu Primary Key
        /// </summary>
        /// <param name="id">Key</param>
        /// <returns>object</returns>
        T GetItemById(int id);

        /// <summary>
        /// Creates new object of type
        /// </summary>
        /// <param name="item">new object</param>
        void CreateItem(T item);        
    }
}
