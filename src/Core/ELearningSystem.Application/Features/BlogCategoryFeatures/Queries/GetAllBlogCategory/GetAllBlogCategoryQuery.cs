using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.BlogCategoryFeatures.Queries.GetAllBlogCategory;

public record GetAllBlogCategoryQuery(int PageNumber = 1, int PageSize = 10, string Search = "") : IRequest<PagedResult<BlogCategory>>;
