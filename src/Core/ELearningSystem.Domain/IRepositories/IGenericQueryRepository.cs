namespace ELearningSystem.Domain.IRepositories;

public interface IGenericQueryRepository<T> where T : class
{
    Task<ICollection<T>> GetListAsync(CancellationToken cancellationToken = default);
    Task<T> GetByIdAsync(string id, CancellationToken cancellationToken = default);
    IQueryable<T> GetQueryable(CancellationToken cancellationToken = default);
}
