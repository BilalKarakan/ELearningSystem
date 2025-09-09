using ELearningSystem.Domain.IRepositories.Contact;
using ELearningSystem.Persistance.Context;

namespace ELearningSystem.Persistance.Repositories.Contact;

public class ContactQueryRepository : GenericQueryRepository<Domain.Entities.Contact>, IContactQueryRepository
{
    public ContactQueryRepository(ELearningSystemDbContext _context) : base(_context)
    {
        
    }
}
