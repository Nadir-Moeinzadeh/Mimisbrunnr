using Mimis.Models;
using Mimisbrunnr.DataAccess.Data;
using Mimisbrunnr.DataAccess.Repository.IRepository;

namespace Mimisbrunnr.DataAccess.Repository
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private ApplicationDbContext _db;
        public OrderDetailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(OrderDetail obj)
        {
            _db.OrderDetails.Update(obj);
        }
    }
}
