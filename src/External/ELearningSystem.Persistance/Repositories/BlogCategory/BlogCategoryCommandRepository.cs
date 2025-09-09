using ELearningSystem.Domain.IRepositories;
using ELearningSystem.Domain.IRepositories.BlogCategory;
using ELearningSystem.Persistance.Context;

namespace ELearningSystem.Persistance.Repositories.BlogCategory;

public class BlogCategoryCommandRepository : GenericCommandRepository<Domain.Entities.BlogCategory>, IBlogCategoryCommandRepository
{
    public BlogCategoryCommandRepository(ELearningSystemDbContext _context, IUnitOfWork _unitOfWork) : base(_context, _unitOfWork)
    {
        
    }
}
