namespace ELearningSystem.Domain.IRepositories;

public interface IGenericQueryRepository<T> where T : class
{
    Task<ICollection<T>> GetListAsync(CancellationToken cancellationToken = default);
    Task<T> GetByIdAsync(int id, CancellationToken cancellationToken = default);
}
