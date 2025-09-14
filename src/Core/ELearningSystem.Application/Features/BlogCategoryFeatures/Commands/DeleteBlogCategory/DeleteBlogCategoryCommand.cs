using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.BlogCategoryFeatures.Commands.DeleteBlogCategory;

public record DeleteBlogCategoryCommand(string Id) : IRequest<CommonResponse>;
