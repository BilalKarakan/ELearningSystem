using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.CourseFeatures.Queries.GetAllCourse;

public class GetAllCourseQueryHandler : IRequestHandler<GetAllCourseQuery, PagedResult<Course>>
{
    public Task<PagedResult<Course>> Handle(GetAllCourseQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
