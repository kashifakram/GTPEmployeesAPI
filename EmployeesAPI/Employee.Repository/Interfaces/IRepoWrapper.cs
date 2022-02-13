namespace Employee.Repository.Interfaces
{
    public interface IRepoWrapper
    {
        IRepoBase<Employees.Domain.Employee> Employee { get; }
        Task Save();

    }
}
