using Mimis.Models;
using Mimisbrunnr.DataAccess.Data;
using Mimisbrunnr.DataAccess.Repository.IRepository;

namespace Mimisbrunnr.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
