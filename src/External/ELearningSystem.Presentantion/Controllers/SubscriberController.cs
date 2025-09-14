using ELearningSystem.Application.Features.SubscriberFeatures.Commands.CreateSubscriber;
using ELearningSystem.Application.Features.SubscriberFeatures.Commands.DeleteSubscriber;
using ELearningSystem.Application.Features.SubscriberFeatures.Commands.UpdateSubscriber;
using ELearningSystem.Application.Features.SubscriberFeatures.Queries.GetAllSubscriber;
using ELearningSystem.Application.Features.SubscriberFeatures.Queries.GetOneSubscriber;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ELearningSystem.Presentantion.Controllers;

[ApiController]
[Route("[controller]")]
public class SubscriberController(IMediator _mediator) : ControllerBase
{
    [HttpPost("[action]")]
    public async Task<IActionResult> CreateAsync(CreateSubscriberCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpDelete("[action]")]
    public async Task<IActionResult> DeleteAsync(DeleteSubscriberCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateAsync(UpdateSubscriberCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpGet("[action]")]
    public async Task<IActionResult> GetByIdAsync([FromQuery] GetOneSubscriberQuery request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpGet("[action]")]
    public async Task<IActionResult> GetListAsync([FromQuery] GetAllSubscriberQuery request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));
}
