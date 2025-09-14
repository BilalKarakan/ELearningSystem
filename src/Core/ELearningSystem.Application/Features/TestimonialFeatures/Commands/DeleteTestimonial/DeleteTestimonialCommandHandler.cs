using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using MediatR;

namespace ELearningSystem.Application.Features.TestimonialFeatures.Commands.DeleteTestimonial;

public class DeleteTestimonialCommandHandler(ITestimonialService _testimonialService) : IRequestHandler<DeleteTestimonialCommand, CommonResponse>
{
    public async Task<CommonResponse> Handle(DeleteTestimonialCommand request, CancellationToken cancellationToken)
    {
        _testimonialService.Delete(request, cancellationToken);
        return new CommonResponse("Testimonial was removed successfully!");
    }
}
