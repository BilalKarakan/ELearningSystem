using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.BannerFeatures.Queries.GetAllBanner;

public record GetAllBannerQuery(int PageNumber = 1, int PageSize = 10, string Search = "") : IRequest<PagedResult<Banner>>;
