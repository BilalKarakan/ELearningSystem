using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.CourseCategoryFeatures.Commands.CreateCourseCategory;

public record CreateCourseCategoryCommand(string Name, string Icon, string Description, bool IsShown) : IRequest<CommonResponse>
{
}
