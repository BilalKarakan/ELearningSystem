using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.MessageFeatures.Commands.UpdateMessage;

public record UpdateMessageCommand(string Id, string Name, string Email, string Subject, string Content) : IRequest<CommonResponse>;
