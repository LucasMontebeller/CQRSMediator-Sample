
using CQRSMediatR.Repositories;

namespace CQRSMediatR.Api.Abstraction
{
    public abstract class BaseRepository<T> : IRepository<T> where T : EntityBase
    {
        // Banco em memória
        private static List<T> Entidade = new();
        public async Task<bool> AddAsync(T entity)
        {
            try
            {
                await Task.Run(() => Entidade.Add(entity));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<T>?> GetAllAsync()
        {
            try
            {
                return await Task.Run(() => Entidade) ?? default;
            }
            catch (Exception)
            {
                return default;
            }
        }

        public async Task<T?> GetBydIdAsync(Guid id)
        {
            try
            {
                return await Task.Run(() => Entidade.FirstOrDefault(x => x.GetId() == id)) ?? default;
            }
            catch (Exception)
            {
                return default;
            }
        }

        public async Task<bool> RemoveAsync(T entity)
        {
            try
            {
                await Task.Run(() => Entidade.Remove(entity));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}