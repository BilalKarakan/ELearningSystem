using ELearningSystem.Application.Features.TestimonialFeatures.Commands.CreateTestimonial;
using ELearningSystem.Application.Features.TestimonialFeatures.Commands.DeleteTestimonial;
using ELearningSystem.Application.Features.TestimonialFeatures.Commands.UpdateTestimonial;
using ELearningSystem.Application.Features.TestimonialFeatures.Queries.GetAllTestimonial;
using ELearningSystem.Application.Features.TestimonialFeatures.Queries.GetOneTestimonial;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;

namespace ELearningSystem.Application.IServices;

public interface ITestimonialService
{
    Task CreateAsync(CreateTestimonialCommand request, CancellationToken cancellationToken);
    void Delete(DeleteTestimonialCommand request, CancellationToken cancellationToken);
    void Update(UpdateTestimonialCommand request, CancellationToken cancellationToken);
    Task<Testimonial> GetByIdAsync(GetOneTestimonialQuery request, CancellationToken cancellationToken);
    Task<PagedResult<Testimonial>> GetListAsync(GetAllTestimonialQuery request, CancellationToken cancellationToken);
}
