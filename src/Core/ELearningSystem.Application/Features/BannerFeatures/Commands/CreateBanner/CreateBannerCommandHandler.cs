using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.BannerFeatures.Commands.CreateBanner;

public class CreateBannerCommandHandler(IBannerService _bannerService) : IRequestHandler<CreateBannerCommand, CommonResponse>
{
    public async Task<CommonResponse> Handle(CreateBannerCommand request, CancellationToken cancellationToken)
    {
        await _bannerService.CreateAsync(request, cancellationToken);
        return new CommonResponse("Banner was created successfully.");
    }
}
