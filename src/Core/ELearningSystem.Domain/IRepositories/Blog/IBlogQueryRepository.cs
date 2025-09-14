namespace ELearningSystem.Domain.IRepositories.Blog;

public interface IBlogQueryRepository : IGenericQueryRepository<Entities.Blog>
{
    Task<IEnumerable<Entities.Blog>> GetListWithCategoriesAsync(CancellationToken cancellationToken = default);
}
