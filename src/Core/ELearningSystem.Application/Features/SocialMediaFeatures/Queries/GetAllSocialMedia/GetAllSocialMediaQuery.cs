using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.SocialMediaFeatures.Queries.GetAllSocialMedia;

public record GetAllSocialMediaQuery(int PageNumber = 1, int PageSize = 10, string Search = "") : IRequest<PagedResult<SocialMedia>>;
