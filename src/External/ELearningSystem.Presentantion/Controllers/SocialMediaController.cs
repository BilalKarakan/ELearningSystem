using ELearningSystem.Application.Features.SocialMediaFeatures.Commands.CreateSocialMedia;
using ELearningSystem.Application.Features.SocialMediaFeatures.Commands.DeleteSocialMedia;
using ELearningSystem.Application.Features.SocialMediaFeatures.Commands.UpdateSocialMedia;
using ELearningSystem.Application.Features.SocialMediaFeatures.Queries.GetAllSocialMedia;
using ELearningSystem.Application.Features.SocialMediaFeatures.Queries.GetOneSocialMedia;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ELearningSystem.Presentantion.Controllers;

[ApiController]
[Route("[controller]")]
public class SocialMediaController(IMediator _mediator) : ControllerBase
{
    [HttpPost("[action]")]
    public async Task<IActionResult> CreateAsync(CreateSocialMediaCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpDelete("[action]")]
    public async Task<IActionResult> DeleteAsync(DeleteSocialMediaCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateAsync(UpdateSocialMediaCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpGet("[action]")]
    public async Task<IActionResult> GetByIdAsync([FromQuery] GetOneSocialMediaQuery request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpGet("[action]")]
    public async Task<IActionResult> GetListAsync([FromQuery] GetAllSocialMediaQuery request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));
}
