using ELearningSystem.Application.IServices;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.TestimonialFeatures.Queries.GetOneTestimonial;

public class GetOneTestimonialQueryHandler(ITestimonialService _testimonialService) : IRequestHandler<GetOneTestimonialQuery, Testimonial>
{
    public async Task<Testimonial> Handle(GetOneTestimonialQuery request, CancellationToken cancellationToken) => await _testimonialService.GetByIdAsync(request, cancellationToken);
}
