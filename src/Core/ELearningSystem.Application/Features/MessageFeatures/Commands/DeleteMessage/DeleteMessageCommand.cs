using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.MessageFeatures.Commands.DeleteMessage;

public record DeleteMessageCommand(string Id) : IRequest<CommonResponse>;
