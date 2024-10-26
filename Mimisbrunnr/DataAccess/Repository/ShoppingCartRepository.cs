using Mimis.Models;
using Mimisbrunnr.DataAccess.Data;
using Mimisbrunnr.DataAccess.Repository.IRepository;

namespace Mimisbrunnr.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private ApplicationDbContext _db;
        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(ShoppingCart obj)
        {
            _db.ShoppingCarts.Update(obj);
        }
    }
}
