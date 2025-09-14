using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.BannerFeatures.Commands.DeleteBanner;

public record DeleteBannerCommand(string Id) : IRequest<CommonResponse>;
