
using CQRSMediatR.Api.Abstraction;
using CQRSMediatR.Repositories;

namespace CQRSMediatR.Api.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : EntityBase
    {
        // Banco em memória
        private static List<T> Entidade = new();

        public async Task<Guid> AddAsync(T entity)
        {
            if (!await ExistsAsync(entity))
            {
                await Task.Run(() => Entidade.Add(entity));
                return entity.Id;
            }
            throw new Exception("O carro informado já existe.");
        }

        public async Task<List<T>?> GetAllAsync()
        {
            return await Task.Run(() => Entidade) ?? default;
        }

        public async Task<T?> GetBydIdAsync(Guid id)
        {
            return await Task.Run(() => Entidade.FirstOrDefault(x => x.Id== id)) ?? default;
        }

        public async Task RemoveAsync(T entity)
        {
            await Task.Run(() => Entidade.Remove(entity));
        }

        private static Task<bool> ExistsAsync(T entity)
        {
            return Task.Run(() => {
                return Entidade.FirstOrDefault(x => x.Nome == entity.Nome) is not null;
            });
        }
    }
}