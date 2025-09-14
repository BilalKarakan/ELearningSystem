using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.ContactFeatures.Queries.GetAllContact;

public class GetAllContactQueryHandler(IContactService _contactService) : IRequestHandler<GetAllContactQuery, PagedResult<Contact>>
{
    public async Task<PagedResult<Contact>> Handle(GetAllContactQuery request, CancellationToken cancellationToken) => await _contactService.GetListAsync(request, cancellationToken);
}
