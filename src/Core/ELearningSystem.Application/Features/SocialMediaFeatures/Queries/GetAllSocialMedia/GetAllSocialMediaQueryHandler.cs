using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.SocialMediaFeatures.Queries.GetAllSocialMedia;

public class GetAllSocialMediaQueryHandler : IRequestHandler<GetAllSocialMediaQuery, PagedResult<SocialMedia>>
{
    public Task<PagedResult<SocialMedia>> Handle(GetAllSocialMediaQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
