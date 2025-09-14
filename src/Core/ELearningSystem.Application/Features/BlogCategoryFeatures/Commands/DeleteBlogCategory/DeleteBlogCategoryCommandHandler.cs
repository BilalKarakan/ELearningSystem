using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.BlogCategoryFeatures.Commands.DeleteBlogCategory;

public class DeleteBlogCategoryCommandHandler : IRequestHandler<DeleteBlogCategoryCommand, CommonResponse>
{
    public Task<CommonResponse> Handle(DeleteBlogCategoryCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
