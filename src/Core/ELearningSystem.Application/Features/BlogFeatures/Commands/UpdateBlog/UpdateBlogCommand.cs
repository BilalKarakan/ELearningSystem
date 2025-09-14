using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.BlogFeatures.Commands.UpdateBlog;

public record UpdateBlogCommand(string Id, string Title, string Content, string ImageUrl, DateTime PublishDate, string BlogCategoryId) : IRequest<CommonResponse>;
