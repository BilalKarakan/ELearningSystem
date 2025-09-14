using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.CourseFeatures.Queries.GetAllCourseWithCategory;

public class GetAllCourseWithCategoryQueryHandler : IRequestHandler<GetAllCourseWithCategoryQuery, PagedResult<Course>>
{
    public Task<PagedResult<Course>> Handle(GetAllCourseWithCategoryQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
