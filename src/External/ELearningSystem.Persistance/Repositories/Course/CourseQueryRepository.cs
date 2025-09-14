using ELearningSystem.Domain.IRepositories.Course;
using ELearningSystem.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace ELearningSystem.Persistance.Repositories.Course;

public class CourseQueryRepository : GenericQueryRepository<Domain.Entities.Course>, ICourseQueryRepository
{
    public CourseQueryRepository(ELearningSystemDbContext _context) : base(_context)
    {
        
    }

    public async Task<IEnumerable<Domain.Entities.Course>> GetListWithCategoryAsync(CancellationToken cancellationToken = default) => await _context.Courses.AsNoTracking().Include(c => c.CourseCategory).ToListAsync(cancellationToken);
}
