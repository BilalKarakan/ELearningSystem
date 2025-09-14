using ELearningSystem.Application.IServices;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.ContactFeatures.Queries.GetOneContact;

public class GetOnContactQueryHandler(IContactService _contactService) : IRequestHandler<GetOneContactQuery, Contact>
{
    public async Task<Contact> Handle(GetOneContactQuery request, CancellationToken cancellationToken) => await _contactService.GetByIdAsync(request, cancellationToken);
}
