using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.CourseFeatures.Queries.GetAllCourse;

public record GetAllCourseQuery(int PageNumber = 1, int PageSize = 10, string Search = "") : IRequest<PagedResult<Course>>;
