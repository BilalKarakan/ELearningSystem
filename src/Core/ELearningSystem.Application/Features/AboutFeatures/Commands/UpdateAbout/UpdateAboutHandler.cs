using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.AboutFeatures.Commands.UpdateAbout;

public class UpdateAboutHandler(IAboutService _aboutService) : IRequestHandler<UpdateAboutCommand, CommonResponse>
{
    public async Task<CommonResponse> Handle(UpdateAboutCommand request, CancellationToken cancellationToken)
    {
        _aboutService.Update(request, cancellationToken);
        return new CommonResponse("About updated successfully");
    }
}
