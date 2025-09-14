using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.CourseCategoryFeatures.Commands.UpdateCourseCategory;

public class UpdateCourseCategoryCommandHandler : IRequestHandler<UpdateCourseCategoryCommand, CommonResponse>
{
    public Task<CommonResponse> Handle(UpdateCourseCategoryCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
