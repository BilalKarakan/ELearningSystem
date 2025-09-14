using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.CourseFeatures.Commands.CreateCourse;

public record CreateCourseCommand(string Name, string ImageUrl, string CourseCategoryId, decimal Price, string Description, bool IsShown) : IRequest<CommonResponse>;
