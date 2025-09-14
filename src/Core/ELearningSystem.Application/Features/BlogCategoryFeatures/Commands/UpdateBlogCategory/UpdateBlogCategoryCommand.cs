using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.BlogCategoryFeatures.Commands.UpdateBlogCategory;

public record UpdateBlogCategoryCommand(string Id, string Name) : IRequest<CommonResponse>;
