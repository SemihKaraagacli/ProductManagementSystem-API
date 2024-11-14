namespace ProductManagementManager.Models.Repositories.GenericRepositories
{
    public interface IGenericRepository<T>
    {
        Task<List<T>> Get();
        Task<T?> Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        IQueryable<T> Where(Func<T, bool> func);

    }
}
