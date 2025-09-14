using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.BannerFeatures.Commands.CreateBanner;

public record CreateBannerCommand(string Title, string ImageUrl) : IRequest<CommonResponse>;
