using Entity;

namespace ODataBookStoreAPI.DataContext.IRepository
{
    public interface IPressRepo 
    {
        Task<IEnumerable<Press>> GetAllPress();
    }
}
