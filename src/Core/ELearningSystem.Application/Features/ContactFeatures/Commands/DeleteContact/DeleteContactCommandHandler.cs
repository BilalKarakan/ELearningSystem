using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.ContactFeatures.Commands.DeleteContact;

public class DeleteContactCommandHandler(IContactService _contactService) : IRequestHandler<DeleteContactCommand, CommonResponse>
{
    public async Task<CommonResponse> Handle(DeleteContactCommand request, CancellationToken cancellationToken)
    {
        _contactService.Delete(request, cancellationToken);
        return new CommonResponse("Common was removed successfully.");
    }
}
