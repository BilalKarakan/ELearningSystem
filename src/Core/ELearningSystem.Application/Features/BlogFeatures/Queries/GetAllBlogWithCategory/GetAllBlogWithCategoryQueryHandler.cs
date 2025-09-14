using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.BlogFeatures.Queries.GetAllBlogWithCategory;

public class GetAllBlogWithCategoryQueryHandler(IBlogService _blogService) : IRequestHandler<GetAllBlogWithCategoryQuery, PagedResult<Blog>>
{
    public async Task<PagedResult<Blog>> Handle(GetAllBlogWithCategoryQuery request, CancellationToken cancellationToken) => await _blogService.GetListWithCategoryAsync(request, cancellationToken);
}
