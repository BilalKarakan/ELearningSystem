using AutoMapper;
using ELearningSystem.Application.Features.BlogFeatures.Commands.CreateBlog;
using ELearningSystem.Application.Features.BlogFeatures.Commands.DeleteBlog;
using ELearningSystem.Application.Features.BlogFeatures.Commands.UpdateBlog;
using ELearningSystem.Application.Features.BlogFeatures.Queries.GetAllBlog;
using ELearningSystem.Application.Features.BlogFeatures.Queries.GetAllBlogWithCategory;
using ELearningSystem.Application.Features.BlogFeatures.Queries.GetOneBlog;
using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using ELearningSystem.Domain.IRepositories.Blog;
using Microsoft.EntityFrameworkCore;

namespace ELearningSystem.Persistance.Services;

public class BlogService(IBlogCommandRepository _commandRepository, IBlogQueryRepository _queryRepository, IMapper _mapper) : IBlogService
{
    public async Task CreateAsync(CreateBlogCommand request, CancellationToken cancellationToken) => await _commandRepository.CreateAsync(_mapper.Map<Blog>(request), cancellationToken);
    public void Delete(DeleteBlogCommand request, CancellationToken cancellationToken) => _commandRepository.Delete(_mapper.Map<Blog>(request), cancellationToken);
    public void Update(UpdateBlogCommand request, CancellationToken cancellationToken) => _commandRepository.Update(_mapper.Map<Blog>(request), cancellationToken);
    public async Task<Blog> GetByIdAsync(GetOneBlogQuery request, CancellationToken cancellationToken) => await _queryRepository.GetByIdAsync(request.Id, cancellationToken);
    public async Task<PagedResult<Blog>> GetListAsync(GetAllBlogQuery request, CancellationToken cancellationToken)
    {
        IQueryable<Blog> blogs = _queryRepository.GetQueryable(cancellationToken);

        if (!string.IsNullOrEmpty(request.Search))
            blogs = blogs.Where(b => EF.Functions.Like(b.Content, b.Title, $"%{request.Search}%"));

        int totalCount = await blogs.CountAsync();
        List<Blog> items = await blogs.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToListAsync();
        return new PagedResult<Blog>(items, totalCount, request.PageNumber, request.PageSize);
    }

    public async Task<PagedResult<Blog>> GetListWithCategoryAsync(GetAllBlogWithCategoryQuery request, CancellationToken cancellationToken)
    {
        IEnumerable<Blog> blogCategories = await _queryRepository.GetListWithCategoriesAsync(cancellationToken);

        if (!string.IsNullOrEmpty(request.Search))
            blogCategories = blogCategories.Where(b => EF.Functions.Like(b.Content, b.Title, $"%{request.Search}%"));

        int totalCount = blogCategories.Count();
        List<Blog> items = blogCategories.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToList();
        return new PagedResult<Blog>(items, totalCount, request.PageNumber, request.PageSize);
    }
}
