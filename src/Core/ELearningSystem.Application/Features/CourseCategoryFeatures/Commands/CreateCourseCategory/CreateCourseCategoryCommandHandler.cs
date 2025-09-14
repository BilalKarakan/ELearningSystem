using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.CourseCategoryFeatures.Commands.CreateCourseCategory;

public class CreateCourseCategoryCommandHandler : IRequestHandler<CreateCourseCategoryCommand, CommonResponse>
{
    public Task<CommonResponse> Handle(CreateCourseCategoryCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
