using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.TestimonialFeatures.Commands.UpdateTestimonial;

public class UpdateTestimonialCommandHandler(ITestimonialService _testimonialService) : IRequestHandler<UpdateTestimonialCommand, CommonResponse>
{
    public async Task<CommonResponse> Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
    {
        _testimonialService.Update(request, cancellationToken);
        return new CommonResponse("Testimonial was updated successfully!");
    }
}
