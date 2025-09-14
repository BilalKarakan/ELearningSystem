using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.CourseCategoryFeatures.Queries.GetOneCourseCategory;

public class GetOneCourseCategoryQueryHandler : IRequestHandler<GetOneCourseCategoryQuery, CourseCategory>
{
    public Task<CourseCategory> Handle(GetOneCourseCategoryQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
