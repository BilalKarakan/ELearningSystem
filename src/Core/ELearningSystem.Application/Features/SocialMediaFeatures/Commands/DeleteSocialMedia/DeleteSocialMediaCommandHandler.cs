using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.SocialMediaFeatures.Commands.DeleteSocialMedia;

public class DeleteSocialMediaCommandHandler(ISocialMediaService _socialMediaService) : IRequestHandler<DeleteSocialMediaCommand, CommonResponse>
{
    public async Task<CommonResponse> Handle(DeleteSocialMediaCommand request, CancellationToken cancellationToken)
    {
        _socialMediaService.Delete(request, cancellationToken);
        return new CommonResponse("Social Media was removed successfully!");
    }
}
