using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.CourseCategoryFeatures.Queries.GetOneCourseCategory;

public record GetOneCourseCategoryQuery(string Id) : IRequest<CourseCategory>;
