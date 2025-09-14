using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.BannerFeatures.Queries.GetAllBanner;

public class GetAllBannerQueryHandler(IBannerService _bannerService) : IRequestHandler<GetAllBannerQuery, PagedResult<Banner>>
{
    public async Task<PagedResult<Banner>> Handle(GetAllBannerQuery request, CancellationToken cancellationToken) => await _bannerService.GetListAsync(request, cancellationToken);
}
