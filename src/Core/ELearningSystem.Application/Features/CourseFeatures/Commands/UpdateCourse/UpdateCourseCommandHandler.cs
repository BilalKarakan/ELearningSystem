using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.CourseFeatures.Commands.UpdateCourse;

public class UpdateCourseCommandHandler : IRequestHandler<UpdateCourseCommand, CommonResponse>
{
    public Task<CommonResponse> Handle(UpdateCourseCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
