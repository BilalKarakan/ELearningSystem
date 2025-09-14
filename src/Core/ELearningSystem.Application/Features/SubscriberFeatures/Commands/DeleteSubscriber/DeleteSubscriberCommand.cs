using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.SubscriberFeatures.Commands.DeleteSubscriber;

public record DeleteSubscriberCommand : IRequest<CommonResponse>;
