namespace ELearningSystem.Domain.IRepositories.Course;

public interface ICourseQueryRepository : IGenericQueryRepository<Entities.Course>
{
    Task<IEnumerable<Entities.Course>> GetListWithCategoryAsync(CancellationToken cancellationToken = default);
}
