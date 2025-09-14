using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.BlogFeatures.Commands.CreateBlog;

public record CreateBlogCommand(string Title, string Content, string ImageUrl, DateTime PublishDate, string BlogCategoryId) : IRequest<CommonResponse>;
