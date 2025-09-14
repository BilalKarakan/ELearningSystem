using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.CourseFeatures.Queries.GetOneCourse;

public record GetOneCourseQuery(string Id) : IRequest<Course>;
