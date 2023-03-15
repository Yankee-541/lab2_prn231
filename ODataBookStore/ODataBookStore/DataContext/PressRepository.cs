using Entity;
using Microsoft.EntityFrameworkCore;
using ODataBookStoreAPI.DataContext.IRepository;

namespace ODataBookStoreAPI.DataContext
{
    public class PressRepository : IPressRepo
    {
        private readonly BookStoreContext db;
        public PressRepository(BookStoreContext context)
        {
            db = context;
        }
        public async Task<IEnumerable<Press>> GetAllPress()
        {
            return await db.Presses.ToListAsync();
        }
    }
}
