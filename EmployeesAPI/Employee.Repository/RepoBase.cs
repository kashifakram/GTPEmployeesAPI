using Employee.Repository.Interfaces;
using Employees.Data;
using Microsoft.EntityFrameworkCore;

namespace Employee.Repository
{
    public abstract class RepoBase<T> : IRepoBase<T> where T : class
    {
        internal EmployeeContext employeeContext;
        internal DbSet<T> dbSet;

        public RepoBase(EmployeeContext employeeContext)
        {
                this.employeeContext = employeeContext;
                this.dbSet = this.employeeContext.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await this.employeeContext.Set<T>().ToListAsync();

        public async Task<T> Create(T entity)
        {
            await this.employeeContext.Set<T>().AddAsync(entity);

            return entity;
        }

        public async Task<T?> FindEntity(int id)
        {
            var entityToDelete = await dbSet.FindAsync(id);

            return entityToDelete ?? null;
        }

        public bool EntityExists(int id) => employeeContext.Employees != null && employeeContext.Employees.Any(e => e.Id == id);

        public void Delete(T entityToDelete)
        {
            if (this.employeeContext.Entry(entityToDelete).State == EntityState.Detached) dbSet.Attach(entityToDelete);
            
            dbSet.Remove(entityToDelete);
        }

        public void Update(T entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            employeeContext.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}