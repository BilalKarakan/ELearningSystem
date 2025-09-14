using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.BlogCategoryFeatures.Commands.CreateBlogCategory;

public record CreateBlogCategoryCommand(string Name) : IRequest<CommonResponse>;
