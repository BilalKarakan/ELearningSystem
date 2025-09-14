namespace ELearningSystem.Domain.IRepositories.CourseCategory;

public interface ICourseCategoryQueryRepository : IGenericQueryRepository<Entities.CourseCategory>
{
    Task<IEnumerable<Entities.CourseCategory>> GetListWithCourseAsync(CancellationToken cancellationToken = default);
}
