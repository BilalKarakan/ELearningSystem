using ELearningSystem.Domain.IRepositories;
using ELearningSystem.Domain.IRepositories.CourseCategory;
using ELearningSystem.Persistance.Context;

namespace ELearningSystem.Persistance.Repositories.CourseCategory;

public class CourseCategoryCommandRepository : GenericCommandRepository<Domain.Entities.CourseCategory>, ICourseCategoryCommandRepository
{
    public CourseCategoryCommandRepository(ELearningSystemDbContext _context, IUnitOfWork _unitOfWork) : base(_context, _unitOfWork)
    {
        
    }
}
