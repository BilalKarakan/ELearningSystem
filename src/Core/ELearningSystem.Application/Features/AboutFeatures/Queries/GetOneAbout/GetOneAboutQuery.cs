using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.AboutFeatures.Queries.GetOneAbout;

public record GetOneAboutQuery(string Id) : IRequest<About>;
