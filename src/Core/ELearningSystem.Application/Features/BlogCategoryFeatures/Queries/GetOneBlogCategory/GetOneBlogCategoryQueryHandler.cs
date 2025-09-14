using ELearningSystem.Application.IServices;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.BlogCategoryFeatures.Queries.GetOneBlogCategory;

public class GetOneBlogCategoryQueryHandler(IBlogCategoryService _blogCategoryService) : IRequestHandler<GetOneBlogCategoryQuery, BlogCategory>
{
    public async Task<BlogCategory> Handle(GetOneBlogCategoryQuery request, CancellationToken cancellationToken) => await _blogCategoryService.GetByIdAsync(request, cancellationToken);
}
