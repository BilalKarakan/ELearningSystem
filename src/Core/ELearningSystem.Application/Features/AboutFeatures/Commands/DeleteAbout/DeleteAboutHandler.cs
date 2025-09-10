using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.AboutFeatures.Commands.DeleteAbout;

public class DeleteAboutHandler(IAboutService _aboutService) : IRequestHandler<DeleteAboutCommand, CommonResponse>
{
    public async Task<CommonResponse> Handle(DeleteAboutCommand request, CancellationToken cancellationToken)
    {
        _aboutService.Delete(request, cancellationToken);
        return new CommonResponse("About section deleted successfully.");
    }
}
