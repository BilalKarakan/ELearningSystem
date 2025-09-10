using AutoMapper;
using Azure.Core;
using ELearningSystem.Application.Features.AboutFeatures.Commands.CreateAbout;
using ELearningSystem.Application.Features.AboutFeatures.Commands.DeleteAbout;
using ELearningSystem.Application.Features.AboutFeatures.Commands.UpdateAbout;
using ELearningSystem.Application.Features.AboutFeatures.Queries.GetAllAbout;
using ELearningSystem.Application.Features.AboutFeatures.Queries.GetOneAbout;
using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using ELearningSystem.Domain.IRepositories.About;
using Microsoft.EntityFrameworkCore;

namespace ELearningSystem.Persistance.Services;

public class AboutService(IAboutCommandRepository _commandRepository, IAboutQueryRepository _queryRepository, IMapper _mapper) : IAboutService
{
    public async Task CreateAsync(CreateAboutCommand request, CancellationToken cancellationToken) => await _commandRepository.CreateAsync(_mapper.Map<About>(request), cancellationToken);
    public void Delete(DeleteAboutCommand request, CancellationToken cancellationToken) => _commandRepository.Delete(_mapper.Map<About>(request), cancellationToken);
    public void Update(UpdateAboutCommand request, CancellationToken cancellationToken) => _commandRepository.Update(_mapper.Map<About>(request), cancellationToken);
    public async Task<PagedResult<About>> GetAllAsync(GetAllAboutQuery request, CancellationToken cancellationToken)
    {
        var abouts = _queryRepository.GetQueryable(cancellationToken);
        if (!string.IsNullOrEmpty(request.Search))
            abouts = abouts.Where(p => EF.Functions.Like(p.Title, $"%{request.Search}%"));

        int totalCount = await abouts.CountAsync(cancellationToken);
        var items = await abouts.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToListAsync(cancellationToken);
        return new PagedResult<About>(items, totalCount, request.PageNumber, request.PageSize);
    }
    public async Task<About> GetByIdAsync(GetOneAboutQuery request, CancellationToken cancellationToken) => await _queryRepository.GetByIdAsync(request.Id, cancellationToken);
}
