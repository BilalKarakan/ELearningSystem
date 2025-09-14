using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.BlogCategoryFeatures.Queries.GetOneBlogCategory;

public record GetOneBlogCategoryQuery(string Id) : IRequest<BlogCategory>;
