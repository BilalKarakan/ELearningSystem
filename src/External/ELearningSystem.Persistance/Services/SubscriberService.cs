using AutoMapper;
using ELearningSystem.Application.Features.SubscriberFeatures.Commands.CreateSubscriber;
using ELearningSystem.Application.Features.SubscriberFeatures.Commands.DeleteSubscriber;
using ELearningSystem.Application.Features.SubscriberFeatures.Commands.UpdateSubscriber;
using ELearningSystem.Application.Features.SubscriberFeatures.Queries.GetAllSubscriber;
using ELearningSystem.Application.Features.SubscriberFeatures.Queries.GetOneSubscriber;
using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using ELearningSystem.Domain.IRepositories.Subscriber;
using Microsoft.EntityFrameworkCore;

namespace ELearningSystem.Persistance.Services;

public class SubscriberService(ISubscriberCommandRepository _commandRepository, ISubscriberQueryRepository _queryRepository, IMapper _mapper) : ISubscriberService
{
    public async Task CreateAsync(CreateSubscriberCommand request, CancellationToken cancellationToken) => await _commandRepository.CreateAsync(_mapper.Map<Subscriber>(request), cancellationToken);
    public void Delete(DeleteSubscriberCommand request, CancellationToken cancellationToken) => _commandRepository.Delete(_mapper.Map<Subscriber>(request), cancellationToken);
    public void Update(UpdateSubscriberCommand request, CancellationToken cancellationToken) => _commandRepository.Update(_mapper.Map<Subscriber>(request), cancellationToken);
    public async Task<Subscriber> GetByIdAsync(GetOneSubscriberQuery request, CancellationToken cancellationToken) => await _queryRepository.GetByIdAsync(request.Id, cancellationToken);
    public async Task<PagedResult<Subscriber>> GetListAsync(GetAllSubscriberQuery request, CancellationToken cancellationToken)
    {
        IQueryable<Subscriber> subscribers = _queryRepository.GetQueryable();

        int totalCount = await subscribers.CountAsync();
        List<Subscriber> items = await subscribers.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToListAsync();
        return new PagedResult<Subscriber>(items, totalCount, request.PageNumber, request.PageSize);
    }
}
