using ELearningSystem.Domain.IRepositories;
using ELearningSystem.Domain.IRepositories.Message;
using ELearningSystem.Persistance.Context;

namespace ELearningSystem.Persistance.Repositories.Message;

public class MessageCommandRepository : GenericCommandRepository<Domain.Entities.Message>, IMessageCommandRepository
{
	public MessageCommandRepository(ELearningSystemDbContext _context, IUnitOfWork _unitOfWork) : base(_context, _unitOfWork)
    {

	}
}
