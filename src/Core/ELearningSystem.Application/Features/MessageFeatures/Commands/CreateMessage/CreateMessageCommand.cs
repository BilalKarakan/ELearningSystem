using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.MessageFeatures.Commands.CreateMessage;

public record CreateMessageCommand(string Name, string Email, string Subject, string Content) : IRequest<CommonResponse> ;