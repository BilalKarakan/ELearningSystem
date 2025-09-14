using ELearningSystem.Domain.IRepositories.CourseCategory;
using ELearningSystem.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace ELearningSystem.Persistance.Repositories.CourseCategory;

public class CourseCategoryQueryRepository : GenericQueryRepository<Domain.Entities.CourseCategory>, ICourseCategoryQueryRepository
{
    public CourseCategoryQueryRepository(ELearningSystemDbContext _context) : base(_context)
    {
        
    }

    public async Task<IEnumerable<Domain.Entities.CourseCategory>> GetListWithCourseAsync(CancellationToken cancellationToken = default) => await _context.CourseCategories.AsNoTracking().Include(cc => cc.Courses).ToListAsync(cancellationToken);
}
