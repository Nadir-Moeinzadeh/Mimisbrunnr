using Mimis.Models;
using Mimisbrunnr.DataAccess.Data;
using Mimisbrunnr.DataAccess.Repository.IRepository;

namespace Mimisbrunnr.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        }
    }
}
