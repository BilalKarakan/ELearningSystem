using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.BlogCategoryFeatures.Queries.GetAllBlogCategory;

public class GetAllBlogCategoryQueryHandler(IBlogCategoryService _blogCategoryService) : IRequestHandler<GetAllBlogCategoryQuery, PagedResult<BlogCategory>>
{
    public async Task<PagedResult<BlogCategory>> Handle(GetAllBlogCategoryQuery request, CancellationToken cancellationToken) => await _blogCategoryService.GetListAsync(request, cancellationToken);
}
