using ELearningSystem.Domain.IRepositories.BlogCategory;
using ELearningSystem.Persistance.Context;

namespace ELearningSystem.Persistance.Repositories.BlogCategory;

public class BlogCategoryQueryRepository : GenericQueryRepository<Domain.Entities.BlogCategory>, IBlogCategoryQueryRepository
{
    public BlogCategoryQueryRepository(ELearningSystemDbContext _context) : base(_context)
    {
        
    }
}
