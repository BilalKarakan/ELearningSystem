using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.CourseFeatures.Commands.DeleteCourse;

public record DeleteCourseCommand(string Id) : IRequest<CommonResponse>;
