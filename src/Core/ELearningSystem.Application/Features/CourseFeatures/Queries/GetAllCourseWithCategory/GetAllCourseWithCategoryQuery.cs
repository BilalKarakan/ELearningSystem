using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.CourseFeatures.Queries.GetAllCourseWithCategory;

public record GetAllCourseWithCategoryQuery(int PageNumber, int PageSize, string Search = "") : IRequest<PagedResult<Course>>;
