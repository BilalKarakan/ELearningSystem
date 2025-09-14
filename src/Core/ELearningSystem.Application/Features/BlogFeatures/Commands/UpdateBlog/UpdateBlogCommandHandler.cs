using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.BlogFeatures.Commands.UpdateBlog;

public class UpdateBlogCommandHandler(IBlogService _blogService) : IRequestHandler<UpdateBlogCommand, CommonResponse>
{
    public async Task<CommonResponse> Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
    {
        _blogService.Update(request, cancellationToken);
        return new CommonResponse("Blog was updated successfully!");
    }
}
