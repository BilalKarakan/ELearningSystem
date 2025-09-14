using ELearningSystem.Domain.IRepositories.BlogCategory;
using ELearningSystem.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace ELearningSystem.Persistance.Repositories.BlogCategory;

public class BlogCategoryQueryRepository : GenericQueryRepository<Domain.Entities.BlogCategory>, IBlogCategoryQueryRepository
{
    public BlogCategoryQueryRepository(ELearningSystemDbContext _context) : base(_context)
    {
        
    }

    public async Task<IEnumerable<Domain.Entities.BlogCategory>> GetListWithBlogAsync(CancellationToken cancellationToken = default) => await _context.BlogCategories.AsNoTracking().Include(bc => bc.Blogs).ToListAsync();
}
