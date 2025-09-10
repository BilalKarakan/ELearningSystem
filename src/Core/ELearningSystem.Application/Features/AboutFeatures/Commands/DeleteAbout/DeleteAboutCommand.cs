using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.AboutFeatures.Commands.DeleteAbout;

public record DeleteAboutCommand(Guid Id) : IRequest<CommonResponse>;
