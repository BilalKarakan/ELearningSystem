using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.ContactFeatures.Queries.GetAllContact;

public record GetAllContactQuery(int PageNumber = 1, int PageSize = 10) : IRequest<PagedResult<Contact>>;
