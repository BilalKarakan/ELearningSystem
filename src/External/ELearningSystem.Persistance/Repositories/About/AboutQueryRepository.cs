using ELearningSystem.Domain.IRepositories;
using ELearningSystem.Domain.IRepositories.About;
using ELearningSystem.Persistance.Context;

namespace ELearningSystem.Persistance.Repositories.About;

public class AboutQueryRepository : GenericQueryRepository<Domain.Entities.About>, IAboutQueryRepository
{
    public AboutQueryRepository(ELearningSystemDbContext _context) : base(_context)
    {
        
    }
}
