using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.AboutFeatures.Queries.GetAllAbout;

public record GetAllAboutQuery(int PageNumber = 1, int PageSize = 10, string Search = "") : IRequest<PagedResult<About>>;
