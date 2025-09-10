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
    public async Task<IActionResult> CreateAsync(CreateAboutCommand request) => Ok(await _mediator.Send(request));

    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateAsync(UpdateAboutCommand request) => Ok(await _mediator.Send(request));

    [HttpDelete("[action]")]
    public async Task<IActionResult> DeleteAsync(DeleteAboutCommand request) => Ok(await _mediator.Send(request));

    [HttpGet("[action]")]
    public async Task<IActionResult> GetAllAsync([FromQuery] GetAllAboutQuery request) => Ok(await _mediator.Send(request));

    [HttpGet("[action]")]
    public async Task<IActionResult> GetByIdAsync([FromQuery] GetOneAboutQuery request) => Ok(await _mediator.Send(request));
}
