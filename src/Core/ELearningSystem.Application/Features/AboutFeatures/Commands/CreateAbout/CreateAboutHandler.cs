using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.AboutFeatures.Commands.CreateAbout;

public class CreateAboutHandler(IAboutService _aboutService) : IRequestHandler<CreateAboutCommand, CommonResponse>
{
    public async Task<CommonResponse> Handle(CreateAboutCommand request, CancellationToken cancellationToken)
    {
        await _aboutService.CreateAsync(request, cancellationToken);
        return new CommonResponse("About created successfully");
    }
}
