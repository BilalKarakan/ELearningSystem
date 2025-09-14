using ELearningSystem.Application.Features.ContactFeatures.Commands.CreateContact;
using ELearningSystem.Application.Features.ContactFeatures.Commands.DeleteContact;
using ELearningSystem.Application.Features.ContactFeatures.Commands.UpdateContact;
using ELearningSystem.Application.Features.ContactFeatures.Queries.GetAllContact;
using ELearningSystem.Application.Features.ContactFeatures.Queries.GetOneContact;
using ELearningSystem.Application.Features.TestimonialFeatures.Commands.CreateTestimonial;
using ELearningSystem.Application.Features.TestimonialFeatures.Commands.DeleteTestimonial;
using ELearningSystem.Application.Features.TestimonialFeatures.Commands.UpdateTestimonial;
using ELearningSystem.Application.Features.TestimonialFeatures.Queries.GetAllTestimonial;
using ELearningSystem.Application.Features.TestimonialFeatures.Queries.GetOneTestimonial;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ELearningSystem.Presentantion.Controllers;

[ApiController]
[Route("[controller]")]
public class TestimonialController(IMediator _mediator) : ControllerBase
{
    [HttpPost("[action]")]
    public async Task<IActionResult> CreateAsync(CreateTestimonialCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpDelete("[action]")]
    public async Task<IActionResult> DeleteAsync(DeleteTestimonialCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateAsync(UpdateTestimonialCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpGet("[action]")]
    public async Task<IActionResult> GetByIdAsync([FromQuery] GetOneTestimonialQuery request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpGet("[action]")]
    public async Task<IActionResult> GetListAsync([FromQuery] GetAllTestimonialQuery request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));
}
