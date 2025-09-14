using AutoMapper;
using ELearningSystem.Application.Features.BannerFeatures.Commands.CreateBanner;
using ELearningSystem.Application.Features.BannerFeatures.Commands.DeleteBanner;
using ELearningSystem.Application.Features.BannerFeatures.Commands.UpdateBanner;
using ELearningSystem.Application.Features.BannerFeatures.Queries.GetAllBanner;
using ELearningSystem.Application.Features.BannerFeatures.Queries.GetOneBanner;
using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using ELearningSystem.Domain.IRepositories.Banner;
using Microsoft.EntityFrameworkCore;

namespace ELearningSystem.Persistance.Services;

public class BannerService(IBannerCommandRepository _commandRepository, IBannerQueryRepository _queryRepository, IMapper _mapper) : IBannerService
{
    public async Task CreateAsync(CreateBannerCommand request, CancellationToken cancellationToken) => await _commandRepository.CreateAsync(_mapper.Map<Banner>(request), cancellationToken);
    public void Delete(DeleteBannerCommand request, CancellationToken cancellationToken) => _commandRepository.Delete(_mapper.Map<Banner>(request), cancellationToken);
    public void Update(UpdateBannerCommand request, CancellationToken cancellationToken) => _commandRepository.Update(_mapper.Map<Banner>(request), cancellationToken);
    public async Task<Banner> GetByIdAsync(GetOneBannerQuery request, CancellationToken cancellationToken) => await _queryRepository.GetByIdAsync(request.Id, cancellationToken);
    public async Task<PagedResult<Banner>> GetListAsync(GetAllBannerQuery request, CancellationToken cancellationToken)
    {
        IQueryable<Banner> banners = _queryRepository.GetQueryable(cancellationToken);
        if (!string.IsNullOrEmpty(request.Search))
            banners = banners.Where(p => EF.Functions.Like(p.Title, $"%{request.Search}%"));

        int totalCount = await banners.CountAsync(cancellationToken);
        var items = await banners.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToListAsync(cancellationToken);
        return new PagedResult<Banner>(items, totalCount, request.PageNumber, request.PageSize);
    }
}
