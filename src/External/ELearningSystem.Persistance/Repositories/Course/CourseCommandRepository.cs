using ELearningSystem.Domain.IRepositories;
using ELearningSystem.Domain.IRepositories.Course;
using ELearningSystem.Persistance.Context;

namespace ELearningSystem.Persistance.Repositories.Course;

public class CourseCommandRepository : GenericCommandRepository<Domain.Entities.Course>, ICourseCommandRepository
{
    public CourseCommandRepository(ELearningSystemDbContext _context, IUnitOfWork _unitOfWork) : base(_context, _unitOfWork)
    {
        
    }
}
