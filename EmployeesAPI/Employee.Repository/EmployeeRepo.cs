using Employee.Repository.Interfaces;
using Employees.Data;

namespace Employee.Repository
{
    public class EmployeeRepo : RepoBase<Employees.Domain.Employee>, IEmployeeRepo
    {
        public EmployeeRepo(EmployeeContext employeeContext) : base(employeeContext)
        {
        }
    }
}
