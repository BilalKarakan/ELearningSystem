using ELearningSystem.Application.IServices;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.BannerFeatures.Queries.GetOneBanner;

public class GetOneBannerQueryHandler(IBannerService _bannerService) : IRequestHandler<GetOneBannerQuery, Banner>
{
    public async Task<Banner> Handle(GetOneBannerQuery request, CancellationToken cancellationToken) => await _bannerService.GetByIdAsync(request, cancellationToken);
}
