using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.ContactFeatures.Commands.UpdateContact;

public class UpdateContactCommandHandler(IContactService _contactService) : IRequestHandler<UpdateContactCommand, CommonResponse>
{
    public async Task<CommonResponse> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
    {
        _contactService.Update(request, cancellationToken);
        return new CommonResponse("Contact was updated successfully.");
    }
}
