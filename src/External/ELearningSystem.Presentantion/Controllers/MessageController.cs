using ELearningSystem.Application.Features.ContactFeatures.Commands.CreateContact;
using ELearningSystem.Application.Features.ContactFeatures.Commands.DeleteContact;
using ELearningSystem.Application.Features.ContactFeatures.Commands.UpdateContact;
using ELearningSystem.Application.Features.ContactFeatures.Queries.GetAllContact;
using ELearningSystem.Application.Features.ContactFeatures.Queries.GetOneContact;
using ELearningSystem.Application.Features.MessageFeatures.Commands.CreateMessage;
using ELearningSystem.Application.Features.MessageFeatures.Commands.DeleteMessage;
using ELearningSystem.Application.Features.MessageFeatures.Commands.UpdateMessage;
using ELearningSystem.Application.Features.MessageFeatures.Queries.GetAllMessage;
using ELearningSystem.Application.Features.MessageFeatures.Queries.GetOneMessage;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ELearningSystem.Presentantion.Controllers;

[ApiController]
[Route("[controller]")]
public class MessageController(IMediator _mediator) : ControllerBase
{
    [HttpPost("[action]")]
    public async Task<IActionResult> CreateAsync(CreateMessageCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpDelete("[action]")]
    public async Task<IActionResult> DeleteAsync(DeleteMessageCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateAsync(UpdateMessageCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpGet("[action]")]
    public async Task<IActionResult> GetByIdAsync([FromQuery] GetOneMessageQuery request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpGet("[action]")]
    public async Task<IActionResult> GetListAsync([FromQuery] GetAllMessageQuery request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));
}
