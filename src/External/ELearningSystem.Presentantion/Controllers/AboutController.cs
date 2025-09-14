using ELearningSystem.Application.Features.AboutFeatures.Commands.CreateAbout;
using ELearningSystem.Application.Features.AboutFeatures.Commands.DeleteAbout;
using ELearningSystem.Application.Features.AboutFeatures.Commands.UpdateAbout;
using ELearningSystem.Application.Features.AboutFeatures.Queries.GetAllAbout;
using ELearningSystem.Application.Features.AboutFeatures.Queries.GetOneAbout;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ELearningSystem.Presentantion.Controllers;

[ApiController]
[Route("[controller]")]
public class AboutController(IMediator _mediator) : ControllerBase
{
    [HttpPost("[action]")]
    public async Task<IActionResult> CreateAsync(CreateAboutCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateAsync(UpdateAboutCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpDelete("[action]")]
    public async Task<IActionResult> DeleteAsync(DeleteAboutCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpGet("[action]")]
    public async Task<IActionResult> GetAllAsync([FromQuery] GetAllAboutQuery request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpGet("[action]")]
    public async Task<IActionResult> GetByIdAsync([FromQuery] GetOneAboutQuery request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));
}
