using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.BlogFeatures.Commands.DeleteBlog;

public record DeleteBlogCommand(string Id) : IRequest<CommonResponse>;
