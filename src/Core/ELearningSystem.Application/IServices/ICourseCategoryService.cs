using ELearningSystem.Application.Features.CourseCategoryFeatures.Commands.CreateCourseCategory;
using ELearningSystem.Application.Features.CourseCategoryFeatures.Commands.DeleteCourseCategory;
using ELearningSystem.Application.Features.CourseCategoryFeatures.Commands.UpdateCourseCategory;
using ELearningSystem.Application.Features.CourseCategoryFeatures.Queries.GetAllCourseCategory;
using ELearningSystem.Application.Features.CourseCategoryFeatures.Queries.GetAllCourseCategoryWithCourse;
using ELearningSystem.Application.Features.CourseCategoryFeatures.Queries.GetOneCourseCategory;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;

namespace ELearningSystem.Application.IServices;

public interface ICourseCategoryService
{
    Task CreateAsync(CreateCourseCategoryCommand request, CancellationToken cancellationToken);
    void Delete(DeleteCourseCategoryCommand request, CancellationToken cancellationToken);
    void Update(UpdateCourseCategoryCommand request, CancellationToken cancellationToken);
    Task<CourseCategory> GetByIdAsync(GetOneCourseCategoryQuery request, CancellationToken cancellationToken);
    Task<PagedResult<CourseCategory>> GetListAsync(GetAllCourseCategoryQuery request, CancellationToken cancellationToken);
    Task<PagedResult<CourseCategory>> GetListWithCourseAsync(GetAllCourseCategoryWithCourseQuery request, CancellationToken cancellationToken);
}
