using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.SocialMediaFeatures.Commands.UpdateSocialMedia;

public record UpdateSocialMediaCommand(string Id, string Icon, string Url, string Title) : IRequest<CommonResponse>;
