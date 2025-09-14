using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.BannerFeatures.Queries.GetOneBanner;

public record GetOneBannerQuery(string Id) : IRequest<Banner>;
