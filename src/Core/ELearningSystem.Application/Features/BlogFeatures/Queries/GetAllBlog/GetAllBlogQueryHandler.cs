using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.BlogFeatures.Queries.GetAllBlog;

public class GetAllBlogQueryHandler(IBlogService _blogService) : IRequestHandler<GetAllBlogQuery, PagedResult<Blog>>
{
    public async Task<PagedResult<Blog>> Handle(GetAllBlogQuery request, CancellationToken cancellationToken) => await _blogService.GetListAsync(request, cancellationToken);
}
