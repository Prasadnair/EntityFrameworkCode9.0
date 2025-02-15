using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public interface IDbContext
    {
            DbSet<EmployeeSalary> EmployeeSalaries {get;}
            Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
            Task ExecuteStoredProcedureAsync(string storedProcName, object parameters = null);
        
    }
}
