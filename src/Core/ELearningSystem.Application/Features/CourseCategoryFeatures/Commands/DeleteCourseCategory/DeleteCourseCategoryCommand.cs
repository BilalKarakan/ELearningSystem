using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.CourseCategoryFeatures.Commands.DeleteCourseCategory;

public record DeleteCourseCategoryCommand(string Id) : IRequest<CommonResponse>;
