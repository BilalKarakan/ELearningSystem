using AutoMapper;
using ELearningSystem.Application.Features.BlogCategoryFeatures.Commands.CreateBlogCategory;
using ELearningSystem.Application.Features.BlogCategoryFeatures.Commands.DeleteBlogCategory;
using ELearningSystem.Application.Features.BlogCategoryFeatures.Commands.UpdateBlogCategory;
using ELearningSystem.Application.Features.BlogCategoryFeatures.Queries.GetAllBlogCategory;
using ELearningSystem.Application.Features.BlogCategoryFeatures.Queries.GetAllBlogCategoryWithBlog;
using ELearningSystem.Application.Features.BlogCategoryFeatures.Queries.GetOneBlogCategory;
using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using ELearningSystem.Domain.IRepositories.BlogCategory;
using Microsoft.EntityFrameworkCore;

namespace ELearningSystem.Persistance.Services;

public class BlogCategoryService(IBlogCategoryCommandRepository _commandRepository, IBlogCategoryQueryRepository _queryRepository, IMapper _mapper) : IBlogCategoryService
{
    public async Task CreateAsync(CreateBlogCategoryCommand request, CancellationToken cancellationToken) => await _commandRepository.CreateAsync(_mapper.Map<BlogCategory>(request), cancellationToken);
    public void Delete(DeleteBlogCategoryCommand request, CancellationToken cancellationToken) => _commandRepository.Delete(_mapper.Map<BlogCategory>(request), cancellationToken);
    public void Update(UpdateBlogCategoryCommand request, CancellationToken cancellationToken) => _commandRepository.Update(_mapper.Map<BlogCategory>(request), cancellationToken);
    public async Task<BlogCategory> GetByIdAsync(GetOneBlogCategoryQuery request, CancellationToken cancellationToken) => await _queryRepository.GetByIdAsync(request.Id, cancellationToken);
    public async Task<PagedResult<BlogCategory>> GetListAsync(GetAllBlogCategoryQuery request, CancellationToken cancellationToken)
    {
        IQueryable<BlogCategory> blogCategories = _queryRepository.GetQueryable(cancellationToken);

        if (!string.IsNullOrEmpty(request.Search))
            blogCategories = blogCategories.Where(bc => EF.Functions.Like(bc.Name, $"%{request.Search}%"));

        int totalCount = await blogCategories.CountAsync();
        List<BlogCategory> items = await blogCategories.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToListAsync();
        return new PagedResult<BlogCategory>(items, totalCount, request.PageNumber, request.PageSize);
    }

    public async Task<PagedResult<BlogCategory>> GetListWithBlogAsync(GetAllBlogCategoryWithBlogQuery request, CancellationToken cancellationToken)
    {
        IEnumerable<BlogCategory> blogCategories = await _queryRepository.GetListWithBlogAsync(cancellationToken);

        if (!string.IsNullOrEmpty(request.Search))
            blogCategories = blogCategories.Where(bc => EF.Functions.Like(bc.Name, $"%{request.Search}%"));

        int totalCount = blogCategories.Count();
        IEnumerable<BlogCategory> items = blogCategories.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToList();
        return new PagedResult<BlogCategory>(items, totalCount, request.PageNumber, request.PageSize);
    }
}
