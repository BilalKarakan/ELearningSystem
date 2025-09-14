using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.BlogFeatures.Queries.GetAllBlog;

public record GetAllBlogQuery(int PageNumber = 1, int PageSize = 10, string Search = "") : IRequest<PagedResult<Blog>>;
