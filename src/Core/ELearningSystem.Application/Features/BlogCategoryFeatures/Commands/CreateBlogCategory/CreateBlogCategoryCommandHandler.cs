using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.BlogCategoryFeatures.Commands.CreateBlogCategory;

public class CreateBlogCategoryCommandHandler(IBlogCategoryService _blogCategoryService) : IRequestHandler<CreateBlogCategoryCommand, CommonResponse>
{
    public async Task<CommonResponse> Handle(CreateBlogCategoryCommand request, CancellationToken cancellationToken)
    {
        await _blogCategoryService.CreateAsync(request, cancellationToken);
        return new CommonResponse("Blog Category was created successfully!");
    }
}
