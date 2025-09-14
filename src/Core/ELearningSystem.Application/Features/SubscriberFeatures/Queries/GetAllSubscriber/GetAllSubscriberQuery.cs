using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.SubscriberFeatures.Queries.GetAllSubscriber;

public record GetAllSubscriberQuery(int PageNumber = 1, int PageSize = 10, string Search = "") : IRequest<PagedResult<Subscriber>>;
