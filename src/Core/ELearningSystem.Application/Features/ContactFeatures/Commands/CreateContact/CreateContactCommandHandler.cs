using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.ContactFeatures.Commands.CreateContact;

public class CreateContactCommandHandler(IContactService _contactService) : IRequestHandler<CreateContactCommand, CommonResponse>
{
    public async Task<CommonResponse> Handle(CreateContactCommand request, CancellationToken cancellationToken)
    {
        await _contactService.CreateAsync(request, cancellationToken);
        return new CommonResponse("Contact was created successfully.");
    }
}
