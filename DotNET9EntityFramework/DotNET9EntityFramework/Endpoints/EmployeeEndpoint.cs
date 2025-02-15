using Application;
using Application.Interfaces;
using DotNET9EntityFramework.Abstraction;

namespace DotNET9EntityFramework.Endpoints
{
    public class EmployeeEndpoint : IEndpoint
    {
        public void MapEndpoint(WebApplication app)
        {
            app.MapGet("/employee", async (IEmployeeService employeeService) => await Handle(employeeService));

        }

        private async Task<IResult> Handle(IEmployeeService employeeService)
        {
            var employees = await employeeService.GetEmployeeAsync();
            return Results.Ok(employees);
        }
    }
}
