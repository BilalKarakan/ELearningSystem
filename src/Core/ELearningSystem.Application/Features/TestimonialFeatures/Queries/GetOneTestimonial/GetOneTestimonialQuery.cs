using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.TestimonialFeatures.Queries.GetOneTestimonial;

public record GetOneTestimonialQuery(string Id) : IRequest<Testimonial>;
