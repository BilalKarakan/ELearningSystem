using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.CourseCategoryFeatures.Queries.GetAllCourseCategory;

public class GetAllCourseCategoryQueryHandler : IRequestHandler<GetAllCourseCategoryQuery, PagedResult<CourseCategory>>
{
    public Task<PagedResult<CourseCategory>> Handle(GetAllCourseCategoryQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
