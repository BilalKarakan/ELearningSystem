using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.CourseCategoryFeatures.Queries.GetAllCourseCategoryWithCourse;

public record GetAllCourseCategoryWithCourseQuery(int PageNumber = 1, int PageSize = 25, string Search = "") : IRequest<PagedResult<CourseCategory>>;
