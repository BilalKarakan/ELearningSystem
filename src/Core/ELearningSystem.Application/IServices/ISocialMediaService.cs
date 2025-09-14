using ELearningSystem.Application.Features.SocialMediaFeatures.Commands.CreateSocialMedia;
using ELearningSystem.Application.Features.SocialMediaFeatures.Commands.DeleteSocialMedia;
using ELearningSystem.Application.Features.SocialMediaFeatures.Commands.UpdateSocialMedia;
using ELearningSystem.Application.Features.SocialMediaFeatures.Queries.GetAllSocialMedia;
using ELearningSystem.Application.Features.SocialMediaFeatures.Queries.GetOneSocialMedia;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;

namespace ELearningSystem.Application.IServices;

public interface ISocialMediaService
{
    Task CreateAsync(CreateSocialMediaCommand request, CancellationToken cancellationToken);
    void Delete(DeleteSocialMediaCommand request, CancellationToken cancellationToken);
    void Update(UpdateSocialMediaCommand request, CancellationToken cancellationToken);
    Task<SocialMedia> GetByIdAsync(GetOneSocialMediaQuery request, CancellationToken cancellationToken);
    Task<PagedResult<SocialMedia>> GetListAsync(GetAllSocialMediaQuery request, CancellationToken cancellationToken);
}
