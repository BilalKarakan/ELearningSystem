using ELearningSystem.Application.Features.BannerFeatures.Commands.CreateBanner;
using ELearningSystem.Application.Features.BannerFeatures.Commands.DeleteBanner;
using ELearningSystem.Application.Features.BannerFeatures.Commands.UpdateBanner;
using ELearningSystem.Application.Features.BannerFeatures.Queries.GetAllBanner;
using ELearningSystem.Application.Features.BannerFeatures.Queries.GetOneBanner;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;

namespace ELearningSystem.Application.IServices;

public interface IBannerService
{
    Task CreateAsync(CreateBannerCommand request, CancellationToken cancellationToken);
    void Delete(DeleteBannerCommand request, CancellationToken cancellationToken);
    void Update(UpdateBannerCommand request, CancellationToken cancellationToken);
    Task<Banner> GetByIdAsync(GetOneBannerQuery request, CancellationToken cancellationToken);
    Task<PagedResult<Banner>> GetListAsync(GetAllBannerQuery request, CancellationToken cancellationToken);
}
