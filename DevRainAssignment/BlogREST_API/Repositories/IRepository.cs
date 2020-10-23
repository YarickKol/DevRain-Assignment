using System.Collections.Generic;

namespace BlogREST_API.Repositories
{
    public interface IRepository <T> where T: class
    {
        bool SaveChanges();
        IEnumerable<T> GetAllItems();
        T GetItemById(int id);
        void CreateItem(T item);        
    }
}
