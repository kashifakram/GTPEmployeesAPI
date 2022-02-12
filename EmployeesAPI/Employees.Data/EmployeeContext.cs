using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Domain;
using Microsoft.EntityFrameworkCore;

namespace Employees.Data
{
    public class EmployeeContext : DbContext
    {
        public DbSet<EmployeePersonalDetails>? Employees { get; set; }
        public DbSet<EmployeeContactDetails>? Contacts { get; set; }
        public DbSet<EmployeeStatus>? Statuses { get; set; }
    }
}
