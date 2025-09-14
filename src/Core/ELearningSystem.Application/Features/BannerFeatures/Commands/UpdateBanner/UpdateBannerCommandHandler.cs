using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.BannerFeatures.Commands.UpdateBanner;

public class UpdateBannerCommandHandler(IBannerService _bannerService) : IRequestHandler<UpdateBannerCommand, CommonResponse>
{
    public async Task<CommonResponse> Handle(UpdateBannerCommand request, CancellationToken cancellationToken)
    {
        _bannerService.Update(request, cancellationToken);
        return new CommonResponse("Banner was updated successfully.");
    }
}
