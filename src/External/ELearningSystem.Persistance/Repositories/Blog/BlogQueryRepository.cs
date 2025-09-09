using ELearningSystem.Domain.IRepositories.Blog;
using ELearningSystem.Persistance.Context;

namespace ELearningSystem.Persistance.Repositories.Blog;

public class BlogQueryRepository : GenericQueryRepository<Domain.Entities.Blog>, IBlogQueryRepository
{
    public BlogQueryRepository(ELearningSystemDbContext _context) : base(_context)
    {
        
    }
}
