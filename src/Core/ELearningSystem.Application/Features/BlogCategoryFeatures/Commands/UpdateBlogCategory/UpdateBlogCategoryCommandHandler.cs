using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.BlogCategoryFeatures.Commands.UpdateBlogCategory;

public class UpdateBlogCategoryCommandHandler(IBlogCategoryService _blogCategoryService) : IRequestHandler<UpdateBlogCategoryCommand, CommonResponse>
{
    public async Task<CommonResponse> Handle(UpdateBlogCategoryCommand request, CancellationToken cancellationToken)
    {
        _blogCategoryService.Update(request, cancellationToken);
        return new CommonResponse("Blog Category was updated successfully!");
    }
}
