using ELearningSystem.Application.Features.SubscriberFeatures.Commands.CreateSubscriber;
using ELearningSystem.Application.Features.SubscriberFeatures.Commands.DeleteSubscriber;
using ELearningSystem.Application.Features.SubscriberFeatures.Commands.UpdateSubscriber;
using ELearningSystem.Application.Features.SubscriberFeatures.Queries.GetAllSubscriber;
using ELearningSystem.Application.Features.SubscriberFeatures.Queries.GetOneSubscriber;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;

namespace ELearningSystem.Application.IServices;

public interface ISubscriberService
{
    Task CreateAsync(CreateSubscriberCommand request, CancellationToken cancellationToken);
    void Delete(DeleteSubscriberCommand request, CancellationToken cancellationToken);
    void Update(UpdateSubscriberCommand request, CancellationToken cancellationToken);
    Task<Subscriber> GetByIdAsync(GetOneSubscriberQuery request, CancellationToken cancellationToken);
    Task<PagedResult<Subscriber>> GetListAsync(GetAllSubscriberQuery request, CancellationToken cancellationToken);
}
