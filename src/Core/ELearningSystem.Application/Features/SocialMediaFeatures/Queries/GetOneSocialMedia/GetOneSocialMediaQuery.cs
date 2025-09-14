using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.SocialMediaFeatures.Queries.GetOneSocialMedia;

public record GetOneSocialMediaQuery(string Id) : IRequest<SocialMedia>;
