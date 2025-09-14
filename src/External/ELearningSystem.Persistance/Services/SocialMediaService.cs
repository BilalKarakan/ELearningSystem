using AutoMapper;
using ELearningSystem.Application.Features.SocialMediaFeatures.Commands.CreateSocialMedia;
using ELearningSystem.Application.Features.SocialMediaFeatures.Commands.DeleteSocialMedia;
using ELearningSystem.Application.Features.SocialMediaFeatures.Commands.UpdateSocialMedia;
using ELearningSystem.Application.Features.SocialMediaFeatures.Queries.GetAllSocialMedia;
using ELearningSystem.Application.Features.SocialMediaFeatures.Queries.GetOneSocialMedia;
using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using ELearningSystem.Domain.IRepositories;
using ELearningSystem.Domain.IRepositories.SocialMedia;
using Microsoft.EntityFrameworkCore;

namespace ELearningSystem.Persistance.Services;

public class SocialMediaService(ISocialMediaCommandRepository _commandRepository, ISocialMediaQueryRepository _queryRepository, IMapper _mapper) : ISocialMediaService
{
    public async Task CreateAsync(CreateSocialMediaCommand request, CancellationToken cancellationToken) => await _commandRepository.CreateAsync(_mapper.Map<SocialMedia>(request), cancellationToken);
    public void Delete(DeleteSocialMediaCommand request, CancellationToken cancellationToken) => _commandRepository.Delete(_mapper.Map<SocialMedia>(request), cancellationToken);
    public void Update(UpdateSocialMediaCommand request, CancellationToken cancellationToken) => _commandRepository.Update(_mapper.Map<SocialMedia>(request), cancellationToken);
    public Task<SocialMedia> GetByIdAsync(GetOneSocialMediaQuery request, CancellationToken cancellationToken) => _queryRepository.GetByIdAsync(request.Id, cancellationToken);
    public async Task<PagedResult<SocialMedia>> GetListAsync(GetAllSocialMediaQuery request, CancellationToken cancellationToken)
    {
        IQueryable<SocialMedia> socialMedias = _queryRepository.GetQueryable();
        if (!string.IsNullOrEmpty(request.Search))
            socialMedias = socialMedias.Where(s => EF.Functions.Like(s.Title, $"%{request.Search}%"));

        int totalCount = await socialMedias.CountAsync();
        var items = await socialMedias.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToListAsync();
        return new PagedResult<SocialMedia>(items, totalCount, request.PageNumber, request.PageSize);
    }
}
