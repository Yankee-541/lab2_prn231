using Entity;
using System.Collections;

namespace ODataBookStoreAPI.DataContext.IRepository
{
    public interface IBookRepo
    {
        Task<IEnumerable> GetBooks();
        Task<bool> CreateBook(Book book);
        Task<bool> DeleteBook(string book);
        Task<bool> EditBook(Book book);
    }
}
