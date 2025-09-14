using ELearningSystem.Application.Features.BlogCategoryFeatures.Commands.CreateBlogCategory;
using ELearningSystem.Application.Features.BlogCategoryFeatures.Commands.DeleteBlogCategory;
using ELearningSystem.Application.Features.BlogCategoryFeatures.Commands.UpdateBlogCategory;
using ELearningSystem.Application.Features.BlogCategoryFeatures.Queries.GetAllBlogCategory;
using ELearningSystem.Application.Features.BlogCategoryFeatures.Queries.GetAllBlogCategoryWithBlog;
using ELearningSystem.Application.Features.BlogCategoryFeatures.Queries.GetOneBlogCategory;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;

namespace ELearningSystem.Application.IServices;

public interface IBlogCategoryService
{
    Task CreateAsync(CreateBlogCategoryCommand request, CancellationToken cancellationToken);
    void Delete(DeleteBlogCategoryCommand request, CancellationToken cancellationToken);
    void Update(UpdateBlogCategoryCommand request, CancellationToken cancellationToken);
    Task<BlogCategory> GetByIdAsync(GetOneBlogCategoryQuery request, CancellationToken cancellationToken);
    Task<PagedResult<BlogCategory>> GetListAsync(GetAllBlogCategoryQuery request, CancellationToken cancellationToken);
    Task<PagedResult<BlogCategory>> GetListWithBlogAsync(GetAllBlogCategoryWithBlogQuery request, CancellationToken cancellationToken);
}
