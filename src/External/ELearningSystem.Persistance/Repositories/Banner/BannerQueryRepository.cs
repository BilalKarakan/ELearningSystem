using ELearningSystem.Domain.IRepositories.Banner;
using ELearningSystem.Persistance.Context;

namespace ELearningSystem.Persistance.Repositories.Banner;

public class BannerQueryRepository : GenericQueryRepository<Domain.Entities.Banner>, IBannerQueryRepository
{
    public BannerQueryRepository(ELearningSystemDbContext _context) : base(_context)
    {
    }
}
