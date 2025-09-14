using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.BlogCategoryFeatures.Queries.GetAllBlogCategoryWithBlog;

public class GetAllBlogCategoryWithBlogQueryHandler(IBlogCategoryService _blogCategoryService) : IRequestHandler<GetAllBlogCategoryWithBlogQuery, PagedResult<BlogCategory>>
{
    public async Task<PagedResult<BlogCategory>> Handle(GetAllBlogCategoryWithBlogQuery request, CancellationToken cancellationToken) => await _blogCategoryService.GetListWithBlogAsync(request, cancellationToken);
}
