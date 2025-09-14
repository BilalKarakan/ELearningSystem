using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using MediatR;

namespace ELearningSystem.Application.Features.TestimonialFeatures.Queries.GetAllTestimonial;

public class GetAllTestimonialQueryHandler(ITestimonialService _testimonialService) : IRequestHandler<GetAllTestimonialQuery, PagedResult<Testimonial>>
{
    public async Task<PagedResult<Testimonial>> Handle(GetAllTestimonialQuery request, CancellationToken cancellationToken) => await _testimonialService.GetListAsync(request, cancellationToken);
}
