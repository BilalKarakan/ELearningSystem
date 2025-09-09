using ELearningSystem.Domain.IRepositories;
using ELearningSystem.Domain.IRepositories.Blog;
using ELearningSystem.Persistance.Context;

namespace ELearningSystem.Persistance.Repositories.Blog;

public class BlogCommandRepository : GenericCommandRepository<Domain.Entities.Blog>, IBlogCommandRepository
{
    public BlogCommandRepository(ELearningSystemDbContext _context, IUnitOfWork _unitOfWork) : base(_context, _unitOfWork)
    {
        
    }
}
