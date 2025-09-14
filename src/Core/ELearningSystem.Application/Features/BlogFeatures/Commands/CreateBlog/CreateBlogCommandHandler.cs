using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.BlogFeatures.Commands.CreateBlog;

public class CreateBlogCommandHandler(IBlogService _blogService) : IRequestHandler<CreateBlogCommand, CommonResponse>
{
    public async Task<CommonResponse> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
    {
        await _blogService.CreateAsync(request, cancellationToken);
        return new CommonResponse("Blog was created successfully!");
    }
}
