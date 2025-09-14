using ELearningSystem.Application.IServices;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.BlogFeatures.Queries.GetOneBlog;

public class GetOneBlogQueryHandler(IBlogService _blogService) : IRequestHandler<GetOneBlogQuery, Blog>
{
    public async Task<Blog> Handle(GetOneBlogQuery request, CancellationToken cancellationToken) => await _blogService.GetByIdAsync(request, cancellationToken);
}
