using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.CourseFeatures.Commands.UpdateCourse;

public record UpdateCourseCommand : IRequest<CommonResponse>;
