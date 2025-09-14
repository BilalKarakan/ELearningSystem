namespace ELearningSystem.Domain.IRepositories.BlogCategory;

public interface IBlogCategoryQueryRepository : IGenericQueryRepository<Entities.BlogCategory>
{
    Task<IEnumerable<Entities.BlogCategory>> GetListWithBlogAsync(CancellationToken cancellationToken = default);
}
