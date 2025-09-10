using ELearningSystem.Application.Features.AboutFeatures.Commands.CreateAbout;
using ELearningSystem.Application.Features.AboutFeatures.Commands.DeleteAbout;
using ELearningSystem.Application.Features.AboutFeatures.Commands.UpdateAbout;
using ELearningSystem.Application.Features.AboutFeatures.Queries.GetAllAbout;
using ELearningSystem.Application.Features.AboutFeatures.Queries.GetOneAbout;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;

namespace ELearningSystem.Application.IServices;

public interface IAboutService
{
    Task CreateAsync(CreateAboutCommand request, CancellationToken cancellationToken);
    void Update(UpdateAboutCommand request, CancellationToken cancellationToken);
    void Delete(DeleteAboutCommand request, CancellationToken cancellationToken);
    Task<PagedResult<About>> GetAllAsync(GetAllAboutQuery request, CancellationToken cancellationToken);
    Task<About> GetByIdAsync(GetOneAboutQuery request, CancellationToken cancellationToken);
}
