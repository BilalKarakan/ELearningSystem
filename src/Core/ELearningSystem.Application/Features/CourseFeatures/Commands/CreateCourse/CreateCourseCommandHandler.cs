using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.CourseFeatures.Commands.CreateCourse;

public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, CommonResponse>
{
    public Task<CommonResponse> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
