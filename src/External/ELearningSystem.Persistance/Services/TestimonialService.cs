using AutoMapper;
using ELearningSystem.Application.Features.TestimonialFeatures.Commands.CreateTestimonial;
using ELearningSystem.Application.Features.TestimonialFeatures.Commands.DeleteTestimonial;
using ELearningSystem.Application.Features.TestimonialFeatures.Commands.UpdateTestimonial;
using ELearningSystem.Application.Features.TestimonialFeatures.Queries.GetAllTestimonial;
using ELearningSystem.Application.Features.TestimonialFeatures.Queries.GetOneTestimonial;
using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using ELearningSystem.Domain.IRepositories;
using ELearningSystem.Domain.IRepositories.Testimonial;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ELearningSystem.Persistance.Services;

public class TestimonialService(ITestimonialCommandRepository _commandRepository, ITestimonialQueryRepository _queryRepository, IMapper _mapper) : ITestimonialService
{
    public async Task CreateAsync(CreateTestimonialCommand request, CancellationToken cancellationToken) => await _commandRepository.CreateAsync(_mapper.Map<Testimonial>(request), cancellationToken);

    public void Delete(DeleteTestimonialCommand request, CancellationToken cancellationToken) => _commandRepository.Delete(_mapper.Map<Testimonial>(request), cancellationToken);

    public async Task<Testimonial> GetByIdAsync(GetOneTestimonialQuery request, CancellationToken cancellationToken) => await _queryRepository.GetByIdAsync(request.Id, cancellationToken);

    public async Task<PagedResult<Testimonial>> GetListAsync(GetAllTestimonialQuery request, CancellationToken cancellationToken)
    {
        IQueryable<Testimonial> testimonials = _queryRepository.GetQueryable();

        if (!string.IsNullOrEmpty(request.Search))
            testimonials = testimonials.Where(t => EF.Functions.Like(t.Name, t.Title, $"%{request.Search}%"));

        int totalCount = await testimonials.CountAsync();
        List<Testimonial> items = await testimonials.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToListAsync();
        return new PagedResult<Testimonial>(items, totalCount, request.PageNumber, request.PageSize);
    }

    public void Update(UpdateTestimonialCommand request, CancellationToken cancellationToken) => _commandRepository.Update(_mapper.Map<Testimonial>(request), cancellationToken);
}
