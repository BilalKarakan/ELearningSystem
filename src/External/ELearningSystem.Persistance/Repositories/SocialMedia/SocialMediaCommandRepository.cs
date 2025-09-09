using ELearningSystem.Domain.IRepositories;
using ELearningSystem.Domain.IRepositories.SocialMedia;
using ELearningSystem.Persistance.Context;

namespace ELearningSystem.Persistance.Repositories.SocialMedia;

public class SocialMediaCommandRepository : GenericCommandRepository<Domain.Entities.SocialMedia>, ISocialMediaCommandRepository
{
    public SocialMediaCommandRepository(ELearningSystemDbContext _context, IUnitOfWork _unitOfWork) : base(_context, _unitOfWork)
    {
        
    }
}
