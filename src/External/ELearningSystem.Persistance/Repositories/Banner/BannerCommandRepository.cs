using ELearningSystem.Domain.IRepositories;
using ELearningSystem.Domain.IRepositories.Banner;
using ELearningSystem.Persistance.Context;

namespace ELearningSystem.Persistance.Repositories.Banner;

public class BannerCommandRepository : GenericCommandRepository<Domain.Entities.Banner>, IBannerCommandRepository
{
    public BannerCommandRepository(ELearningSystemDbContext _context, IUnitOfWork _unitOfWork) : base(_context, _unitOfWork)
    {
            
    }
}
