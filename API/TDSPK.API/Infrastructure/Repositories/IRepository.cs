using TDSPK.API.Infrastructure.Persistence;
using TDSPK.API.Migrations;

namespace TDSPK.API.Infrastructure.Repositories
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IEnumerable<T>> GetByUserIdAsync();
        Task AddAsync(T entity);
        Task DeleteAsync(Guid id);
    }
}
