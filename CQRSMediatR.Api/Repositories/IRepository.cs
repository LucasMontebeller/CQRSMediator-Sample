namespace CQRSMediatR.Repositories
{
    public interface IRepository<T>
    {
        Task<T?> GetBydIdAsync(Guid id);
        Task<List<T>?> GetAllAsync();
        Task<Guid> AddAsync(T entity);
        Task RemoveAsync(T entity); 
    }
}