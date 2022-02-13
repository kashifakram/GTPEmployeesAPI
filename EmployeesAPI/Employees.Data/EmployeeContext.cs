using Employees.Domain;
using Microsoft.EntityFrameworkCore;

namespace Employees.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) {}
        
        public DbSet<Employee>? Employees { get; set; }

    }
}