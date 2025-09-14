using ELearningSystem.Application.Features.BannerFeatures.Commands.CreateBanner;
using ELearningSystem.Application.Features.BannerFeatures.Commands.DeleteBanner;
using ELearningSystem.Application.Features.BannerFeatures.Commands.UpdateBanner;
using ELearningSystem.Application.Features.BannerFeatures.Queries.GetAllBanner;
using ELearningSystem.Application.Features.BannerFeatures.Queries.GetOneBanner;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ELearningSystem.Presentantion.Controllers;

[ApiController]
[Route("[controller]")]
public class BannerController(IMediator _mediator) : ControllerBase
{
    [HttpPost("[action]")]
    public async Task<IActionResult> CreateAsync(CreateBannerCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpDelete("[action]")]
    public async Task<IActionResult> DeleteAsync(DeleteBannerCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateAsync(UpdateBannerCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpGet("[action]")]
    public async Task<IActionResult> GetByIdAsync([FromQuery] GetOneBannerQuery request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpGet("[action]")]
    public async Task<IActionResult> GetListAsync([FromQuery] GetAllBannerQuery request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));
}
