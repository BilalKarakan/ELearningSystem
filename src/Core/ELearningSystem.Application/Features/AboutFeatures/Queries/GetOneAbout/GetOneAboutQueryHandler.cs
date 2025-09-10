using ELearningSystem.Application.IServices;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.AboutFeatures.Queries.GetOneAbout;

public class GetOneAboutQueryHandler(IAboutService _aboutService) : IRequestHandler<GetOneAboutQuery, About>
{
    public async Task<About> Handle(GetOneAboutQuery request, CancellationToken cancellationToken) => await _aboutService.GetByIdAsync(request, cancellationToken);
}
