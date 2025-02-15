using Application.Interfaces;
using Application.Interfaces.Repositories;
using Model;

namespace Application
{
    public class EmployeeService(
        IEmployeeRepository employeeRepository
        ) : IEmployeeService
    {
        public async Task<List<EmployeeSalary>> GetEmployeeAsync()
        {
            return await employeeRepository.GetEmployeeAsync();
        }
    }
}
