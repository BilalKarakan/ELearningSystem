using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.BannerFeatures.Commands.UpdateBanner;

public record UpdateBannerCommand(string Id, string Title, string ImageUrl) : IRequest<CommonResponse>;
