using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.CourseCategoryFeatures.Queries.GetAllCourseCategoryWithCourse;

public class GetAllCourseCategoryWithCourseQueryHandler : IRequestHandler<GetAllCourseCategoryWithCourseQuery, PagedResult<CourseCategory>>
{
    public Task<PagedResult<CourseCategory>> Handle(GetAllCourseCategoryWithCourseQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
