using ELearningSystem.Application.IServices;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.SocialMediaFeatures.Queries.GetOneSocialMedia;

public class GetOneSocialMediaQueryHandler(ISocialMediaService _socialMediaService) : IRequestHandler<GetOneSocialMediaQuery, SocialMedia>
{
    public async Task<SocialMedia> Handle(GetOneSocialMediaQuery request, CancellationToken cancellationToken) => await _socialMediaService.GetByIdAsync(request, cancellationToken);
}
