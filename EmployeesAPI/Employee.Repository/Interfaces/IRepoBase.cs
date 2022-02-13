namespace Employee.Repository.Interfaces
{
    public interface IRepoBase<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> Create(T entity);
        void Delete(T entity);
        void Update(T entity);
        Task<T?> FindEntity(int id);
        bool EntityExists(int id);
    }
}
