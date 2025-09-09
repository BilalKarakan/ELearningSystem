using ELearningSystem.Domain.IRepositories;
using ELearningSystem.Domain.IRepositories.Subscriber;
using ELearningSystem.Persistance.Context;

namespace ELearningSystem.Persistance.Repositories.Subscriber;

public class SubscriberCommandRepository : GenericCommandRepository<Domain.Entities.Subscriber>, ISubscriberCommandRepository
{
    public SubscriberCommandRepository(ELearningSystemDbContext _context, IUnitOfWork _unitOfWork) : base(_context, _unitOfWork)
    {
        
    }
}
