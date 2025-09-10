using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.AboutFeatures.Queries.GetAllAbout;

public class GetAllAboutQueryHandler(IAboutService _aboutService) : IRequestHandler<GetAllAboutQuery, PagedResult<About>>
{
    public async Task<PagedResult<About>> Handle(GetAllAboutQuery request, CancellationToken cancellationToken)
    {
        return await _aboutService.GetAllAsync(request, cancellationToken);
    }
}
