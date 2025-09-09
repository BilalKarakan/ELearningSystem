using ELearningSystem.Domain.IRepositories.Course;
using ELearningSystem.Persistance.Context;

namespace ELearningSystem.Persistance.Repositories.Course;

public class CourseQueryRepository : GenericQueryRepository<Domain.Entities.Course>, ICourseQueryRepository
{
    public CourseQueryRepository(ELearningSystemDbContext _context) : base(_context)
    {
        
    }
}
