using Model;

namespace Application.Interfaces.Repositories
{
    public interface IEmployeeRepository
    {
        Task<List<EmployeeSalary>> GetEmployeeAsync();
    }
}
