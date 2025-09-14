using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.MessageFeatures.Queries.GetAllMessage;

public record GetAllMessageQuery(int PageNumber = 1, int PageSize = 10, string Search = "") : IRequest<PagedResult<Message>>;
