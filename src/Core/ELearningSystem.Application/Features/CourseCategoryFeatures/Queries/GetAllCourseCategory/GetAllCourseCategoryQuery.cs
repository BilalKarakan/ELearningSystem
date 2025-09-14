using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.CourseCategoryFeatures.Queries.GetAllCourseCategory;

public record GetAllCourseCategoryQuery(int PageNumber = 1, int PageSize = 10, string Search = "") : IRequest<PagedResult<CourseCategory>>;
