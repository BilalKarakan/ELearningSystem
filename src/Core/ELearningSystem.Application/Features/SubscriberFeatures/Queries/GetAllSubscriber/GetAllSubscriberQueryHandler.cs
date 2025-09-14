using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.SubscriberFeatures.Queries.GetAllSubscriber;

public class GetAllSubscriberQueryHandler(ISubscriberService _subscriberService) : IRequestHandler<GetAllSubscriberQuery, PagedResult<Subscriber>>
{
    public async Task<PagedResult<Subscriber>> Handle(GetAllSubscriberQuery request, CancellationToken cancellationToken) => await _subscriberService.GetListAsync(request, cancellationToken);
}
