using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.SubscriberFeatures.Commands.CreateSubscriber;

public record CreateSubscriberCommand(string Email) : IRequest<CommonResponse>;
