using ELearningSystem.Application.Features.BlogFeatures.Commands.CreateBlog;
using ELearningSystem.Application.Features.BlogFeatures.Commands.DeleteBlog;
using ELearningSystem.Application.Features.BlogFeatures.Commands.UpdateBlog;
using ELearningSystem.Application.Features.BlogFeatures.Queries.GetAllBlog;
using ELearningSystem.Application.Features.BlogFeatures.Queries.GetAllBlogWithCategory;
using ELearningSystem.Application.Features.BlogFeatures.Queries.GetOneBlog;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;

namespace ELearningSystem.Application.IServices;

public interface IBlogService
{
    Task CreateAsync(CreateBlogCommand request, CancellationToken cancellationToken);
    void Delete(DeleteBlogCommand request, CancellationToken cancellationToken);
    void Update(UpdateBlogCommand request, CancellationToken cancellationToken);
    Task<Blog> GetByIdAsync(GetOneBlogQuery request, CancellationToken cancellationToken);
    Task<PagedResult<Blog>> GetListAsync(GetAllBlogQuery request, CancellationToken cancellationToken);
    Task<PagedResult<Blog>> GetListWithCategoryAsync(GetAllBlogWithCategoryQuery request, CancellationToken cancellationToken);
}
