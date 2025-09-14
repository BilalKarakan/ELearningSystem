using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.TestimonialFeatures.Commands.CreateTestimonial;

public class CreateTestimonialCommandHandler(ITestimonialService _testimonialService) : IRequestHandler<CreateTestimonialCommand, CommonResponse>
{
    public async Task<CommonResponse> Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
    {
        await _testimonialService.CreateAsync(request, cancellationToken);
        return new CommonResponse("Testimonial was created successfully!");
    }
}
