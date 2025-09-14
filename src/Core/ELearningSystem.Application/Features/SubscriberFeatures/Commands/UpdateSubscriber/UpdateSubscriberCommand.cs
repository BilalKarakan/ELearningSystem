using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.SubscriberFeatures.Commands.UpdateSubscriber;

public record UpdateSubscriberCommand(string Id, string Email, bool IsActive) : IRequest<CommonResponse>;
