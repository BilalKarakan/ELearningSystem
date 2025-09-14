using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.CourseCategoryFeatures.Commands.DeleteCourseCategory;

public class DeleteCourseCategoryCommandHandler : IRequestHandler<DeleteCourseCategoryCommand, CommonResponse>
{
    public Task<CommonResponse> Handle(DeleteCourseCategoryCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
