using ELearningSystem.Application.Features.ContactFeatures.Commands.CreateContact;
using ELearningSystem.Application.Features.ContactFeatures.Commands.DeleteContact;
using ELearningSystem.Application.Features.ContactFeatures.Commands.UpdateContact;
using ELearningSystem.Application.Features.ContactFeatures.Queries.GetAllContact;
using ELearningSystem.Application.Features.ContactFeatures.Queries.GetOneContact;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;

namespace ELearningSystem.Application.IServices;

public interface IContactService
{
    Task CreateAsync(CreateContactCommand request, CancellationToken cancellationToken);
    void Delete(DeleteContactCommand request, CancellationToken cancellationToken);
    void Update(UpdateContactCommand request, CancellationToken cancellationToken);
    Task<Contact> GetByIdAsync(GetOneContactQuery request, CancellationToken cancellationToken);
    Task<PagedResult<Contact>> GetListAsync(GetAllContactQuery request, CancellationToken cancellationToken);
}
