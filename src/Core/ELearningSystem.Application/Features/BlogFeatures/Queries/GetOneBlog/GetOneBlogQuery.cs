using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.BlogFeatures.Queries.GetOneBlog;

public record GetOneBlogQuery(string Id) : IRequest<Blog>;
