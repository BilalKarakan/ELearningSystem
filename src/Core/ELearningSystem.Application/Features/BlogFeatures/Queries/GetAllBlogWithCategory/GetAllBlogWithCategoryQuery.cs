using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.BlogFeatures.Queries.GetAllBlogWithCategory;

public record GetAllBlogWithCategoryQuery(int PageNumber = 1, int PageSize = 25, string Search = "") : IRequest<PagedResult<Blog>>;
