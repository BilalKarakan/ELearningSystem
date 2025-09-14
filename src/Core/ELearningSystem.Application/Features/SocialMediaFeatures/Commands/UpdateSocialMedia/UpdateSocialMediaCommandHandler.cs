using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.SocialMediaFeatures.Commands.UpdateSocialMedia;

public class UpdateSocialMediaCommandHandler(ISocialMediaService _socialMediaService) : IRequestHandler<UpdateSocialMediaCommand, CommonResponse>
{
    public async  Task<CommonResponse> Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
    {
        _socialMediaService.Update(request, cancellationToken);
        return new CommonResponse("Social Media was updated successfully!");
    }
}
