using ELearningSystem.Domain.IRepositories;
using ELearningSystem.Domain.IRepositories.About;
using ELearningSystem.Persistance.Context;

namespace ELearningSystem.Persistance.Repositories.About;

public class AboutCommandRepository : GenericCommandRepository<Domain.Entities.About>, IAboutCommandRepository
{
    public AboutCommandRepository(ELearningSystemDbContext _context, IUnitOfWork _unitOfWork) : base(_context, _unitOfWork)
    {
        
    }
}
