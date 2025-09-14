using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.BlogCategoryFeatures.Queries.GetAllBlogCategoryWithBlog;

public record GetAllBlogCategoryWithBlogQuery(int PageNumber = 1, int PageSize = 25, string Search = "") : IRequest<PagedResult<BlogCategory>>;
