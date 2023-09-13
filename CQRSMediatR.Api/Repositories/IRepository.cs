namespace CQRSMediatR.Repositories
{
    public interface IRepository<T>
    {
        Task<T?> GetBydIdAsync(Guid id);
        Task<List<T>?> GetAllAsync();
        Task<bool> AddAsync(T entity);
        Task<bool> RemoveAsync(T entity); 
    }
}