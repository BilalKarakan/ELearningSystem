using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.TestimonialFeatures.Queries.GetAllTestimonial;

public record GetAllTestimonialQuery(int PageNumber = 1, int PageSize = 10, string Search = "") : IRequest<PagedResult<Testimonial>>;
