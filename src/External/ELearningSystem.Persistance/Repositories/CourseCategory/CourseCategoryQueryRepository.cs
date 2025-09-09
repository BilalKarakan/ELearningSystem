using ELearningSystem.Domain.IRepositories.CourseCategory;
using ELearningSystem.Persistance.Context;

namespace ELearningSystem.Persistance.Repositories.CourseCategory;

public class CourseCategoryQueryRepository : GenericQueryRepository<Domain.Entities.CourseCategory>, ICourseCategoryQueryRepository
{
    public CourseCategoryQueryRepository(ELearningSystemDbContext _context) : base(_context)
    {
        
    }
}
