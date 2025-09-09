using ELearningSystem.Domain.IRepositories.Subscriber;
using ELearningSystem.Persistance.Context;

namespace ELearningSystem.Persistance.Repositories.Subscriber;

public class SubscriberQueryRepository : GenericQueryRepository<Domain.Entities.Subscriber>, ISubscriberQueryRepository
{
    public SubscriberQueryRepository(ELearningSystemDbContext _context) : base(_context)
    {

    }
}
