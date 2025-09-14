using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.CourseCategoryFeatures.Commands.UpdateCourseCategory;

public record UpdateCourseCategoryCommand : IRequest<CommonResponse>;
