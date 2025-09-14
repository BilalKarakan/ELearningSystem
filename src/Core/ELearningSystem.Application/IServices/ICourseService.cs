using ELearningSystem.Application.Features.BlogCategoryFeatures.Commands.CreateBlogCategory;
using ELearningSystem.Application.Features.BlogCategoryFeatures.Commands.DeleteBlogCategory;
using ELearningSystem.Application.Features.BlogCategoryFeatures.Commands.UpdateBlogCategory;
using ELearningSystem.Application.Features.BlogCategoryFeatures.Queries.GetAllBlogCategory;
using ELearningSystem.Application.Features.BlogCategoryFeatures.Queries.GetAllBlogCategoryWithBlog;
using ELearningSystem.Application.Features.BlogCategoryFeatures.Queries.GetOneBlogCategory;
using ELearningSystem.Application.Features.CourseFeatures.Commands.CreateCourse;
using ELearningSystem.Application.Features.CourseFeatures.Commands.DeleteCourse;
using ELearningSystem.Application.Features.CourseFeatures.Commands.UpdateCourse;
using ELearningSystem.Application.Features.CourseFeatures.Queries.GetAllCourse;
using ELearningSystem.Application.Features.CourseFeatures.Queries.GetAllCourseWithCategory;
using ELearningSystem.Application.Features.CourseFeatures.Queries.GetOneCourse;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;

namespace ELearningSystem.Application.IServices;

public interface ICourseService
{
    Task CreateAsync(CreateCourseCommand request, CancellationToken cancellationToken);
    void Delete(DeleteCourseCommand request, CancellationToken cancellationToken);
    void Update(UpdateCourseCommand request, CancellationToken cancellationToken);
    Task<Course> GetByIdAsync(GetOneCourseQuery request, CancellationToken cancellationToken);
    Task<PagedResult<Course>> GetListAsync(GetAllCourseQuery request, CancellationToken cancellationToken);
    Task<PagedResult<Course>> GetListWithCategoryAsync(GetAllCourseWithCategoryQuery request, CancellationToken cancellationToken);
}
