using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.SocialMediaFeatures.Commands.CreateSocialMedia;

public record CreateSocialMediaCommand(string Icon, string Url, string Title) : IRequest<CommonResponse>;
