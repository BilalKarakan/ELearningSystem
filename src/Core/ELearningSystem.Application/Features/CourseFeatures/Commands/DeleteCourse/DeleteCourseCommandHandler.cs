using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.CourseFeatures.Commands.DeleteCourse;

public class DeleteCourseCommandHandler : IRequestHandler<DeleteCourseCommand, CommonResponse>
{
    public Task<CommonResponse> Handle(DeleteCourseCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
