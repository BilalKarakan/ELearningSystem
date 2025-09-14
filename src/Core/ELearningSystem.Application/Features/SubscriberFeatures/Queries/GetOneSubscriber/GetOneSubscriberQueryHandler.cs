using ELearningSystem.Application.IServices;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.SubscriberFeatures.Queries.GetOneSubscriber;

public class GetOneSubscriberQueryHandler(ISubscriberService _subscriberService) : IRequestHandler<GetOneSubscriberQuery, Subscriber>
{
    public async Task<Subscriber> Handle(GetOneSubscriberQuery request, CancellationToken cancellationToken) => await _subscriberService.GetByIdAsync(request, cancellationToken);
}
