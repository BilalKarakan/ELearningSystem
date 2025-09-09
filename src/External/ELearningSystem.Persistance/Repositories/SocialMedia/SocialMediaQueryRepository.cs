using ELearningSystem.Domain.IRepositories.SocialMedia;
using ELearningSystem.Persistance.Context;

namespace ELearningSystem.Persistance.Repositories.SocialMedia;

public class SocialMediaQueryRepository : GenericQueryRepository<Domain.Entities.SocialMedia>, ISocialMediaQueryRepository
{
    public SocialMediaQueryRepository(ELearningSystemDbContext _context) : base(_context)
    {
        
    }
}
