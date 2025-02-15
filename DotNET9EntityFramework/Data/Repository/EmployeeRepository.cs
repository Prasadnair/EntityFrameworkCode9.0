using Application.Interfaces.Repositories;
using Data.Mapper;
using Microsoft.EntityFrameworkCore;
using DomainModel= Model;

namespace Data.Repository
{
    public class EmployeeRepository(
        IDbContext dbContext
        ) : IEmployeeRepository
    {
        public async Task<List<DomainModel.EmployeeSalary>> GetEmployeeAsync()
        {
            var result = await dbContext.EmployeeSalaries.ToListAsync();
            return result.MapToDomainEmployeeSalaries();
        }
    }
}
