using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.SubscriberFeatures.Queries.GetOneSubscriber;

public record GetOneSubscriberQuery(string Id) : IRequest<Subscriber>;
