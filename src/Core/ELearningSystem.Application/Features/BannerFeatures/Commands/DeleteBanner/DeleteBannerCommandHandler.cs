using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.BannerFeatures.Commands.DeleteBanner;

public class DeleteBannerCommandHandler(IBannerService _bannerService) : IRequestHandler<DeleteBannerCommand, CommonResponse>
{
    public async Task<CommonResponse> Handle(DeleteBannerCommand request, CancellationToken cancellationToken)
    {
        _bannerService.Delete(request, cancellationToken);
        return new CommonResponse("Banner was removed successfully.");
    }
}
