using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.SocialMediaFeatures.Commands.DeleteSocialMedia;

public record DeleteSocialMediaCommand(string Id) : IRequest<CommonResponse>;
