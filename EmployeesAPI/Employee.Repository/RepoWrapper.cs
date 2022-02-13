using Employee.Repository.Interfaces;
using Employees.Data;

namespace Employee.Repository
{
    public class RepoWrapper : IRepoWrapper, IDisposable
    {
        private readonly EmployeeContext _employeeContext;
        private RepoBase<Employees.Domain.Employee>? _employee;
        private bool disposed = false;

        public RepoWrapper(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        public IRepoBase<Employees.Domain.Employee> Employee => _employee ??= new EmployeeRepo(_employeeContext);

        public async Task Save()
        {
            await _employeeContext.SaveChangesAsync();
        }

    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                _employeeContext.Dispose();
            }
        }
        this.disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
}
