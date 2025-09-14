using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.BlogFeatures.Commands.DeleteBlog;

public class DeleteBlogCommandHandler(IBlogService _blogService) : IRequestHandler<DeleteBlogCommand, CommonResponse>
{
    public async Task<CommonResponse> Handle(DeleteBlogCommand request, CancellationToken cancellationToken)
    {
        _blogService.Delete(request, cancellationToken);
        return new CommonResponse("Blog was removed successfully!");
    }
}
