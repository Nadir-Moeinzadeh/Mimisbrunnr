using Mimis.Models;
using Mimisbrunnr.DataAccess.Data;
using Mimisbrunnr.DataAccess.Repository.IRepository;

namespace Mimisbrunnr.DataAccess.Repository
{
    public class ProductImageRepository : Repository<ProductImage>, IProductImageRepository
    {
        private ApplicationDbContext _db;
        public ProductImageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(ProductImage obj)
        {
            _db.ProductImages.Update(obj);
        }
    }
}
