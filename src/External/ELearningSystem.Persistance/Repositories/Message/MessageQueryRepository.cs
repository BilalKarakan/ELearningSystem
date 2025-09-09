using ELearningSystem.Domain.IRepositories.Message;
using ELearningSystem.Persistance.Context;

namespace ELearningSystem.Persistance.Repositories.Message;

public class MessageQueryRepository : GenericQueryRepository<Domain.Entities.Message>, IMessageQueryRepository
{
    public MessageQueryRepository(ELearningSystemDbContext _context) : base(_context)
    {
        
    }
}
