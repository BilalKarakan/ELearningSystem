using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.SocialMediaFeatures.Commands.CreateSocialMedia;

public class CreateSocialMediaCommandHandler(ISocialMediaService _socialMediaService) : IRequestHandler<CreateSocialMediaCommand, CommonResponse>
{
    public async Task<CommonResponse> Handle(CreateSocialMediaCommand request, CancellationToken cancellationToken)
    {
        await _socialMediaService.CreateAsync(request, cancellationToken);
        return new CommonResponse("Social Media was created succesfully!");
    }
}
