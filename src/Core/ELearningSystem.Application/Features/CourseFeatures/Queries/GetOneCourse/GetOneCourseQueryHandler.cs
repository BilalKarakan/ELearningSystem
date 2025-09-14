using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.CourseFeatures.Queries.GetOneCourse;

public class GetOneCourseQueryHandler : IRequestHandler<GetOneCourseQuery, Course>
{
    public Task<Course> Handle(GetOneCourseQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
