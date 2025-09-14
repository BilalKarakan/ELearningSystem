using ELearningSystem.Domain.IRepositories.Blog;
using ELearningSystem.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace ELearningSystem.Persistance.Repositories.Blog;

public class BlogQueryRepository : GenericQueryRepository<Domain.Entities.Blog>, IBlogQueryRepository
{
    public BlogQueryRepository(ELearningSystemDbContext _context) : base(_context)
    {
        
    }

    public async Task<IEnumerable<Domain.Entities.Blog>> GetListWithCategoriesAsync(CancellationToken cancellationToken = default) => await _context.Blogs.AsNoTracking().Include(b => b.BlogCategory).ToListAsync();
}
