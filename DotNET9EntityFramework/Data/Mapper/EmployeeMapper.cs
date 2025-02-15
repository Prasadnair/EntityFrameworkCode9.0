namespace Data.Mapper
{
    internal static class EmployeeMapper
    {
        internal static List<Model.EmployeeSalary> MapToDomainEmployeeSalaries(this List<Entities.EmployeeSalary> employeeSalaries)
        {
            return employeeSalaries.Select(employeeSalary =>
            {
                return new Model.EmployeeSalary
                {
                    EmpId = employeeSalary.EmpId,
                    EmpName = employeeSalary.EmpName
                };
            }).ToList();
        }
        
    }
}
