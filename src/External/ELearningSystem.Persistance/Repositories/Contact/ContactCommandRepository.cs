using ELearningSystem.Domain.IRepositories;
using ELearningSystem.Domain.IRepositories.Contact;
using ELearningSystem.Persistance.Context;

namespace ELearningSystem.Persistance.Repositories.Contact;

public class ContactCommandRepository : GenericCommandRepository<Domain.Entities.Contact>, IContactCommandRepository
{
    public ContactCommandRepository(ELearningSystemDbContext _context, IUnitOfWork _unitOfWork) : base(_context, _unitOfWork)
    {
        
    }
}
