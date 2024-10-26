using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Mimis.Models;

namespace Mimisbrunnr.DataAccess.Repository.IRepository
{
    public interface ICompanyRepository : IRepository<Company>
    {
        void Update(Company obj);
    }
}
