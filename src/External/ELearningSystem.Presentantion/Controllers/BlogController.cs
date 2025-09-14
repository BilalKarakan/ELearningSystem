using ELearningSystem.Application.Features.BlogFeatures.Commands.CreateBlog;
using ELearningSystem.Application.Features.BlogFeatures.Commands.DeleteBlog;
using ELearningSystem.Application.Features.BlogFeatures.Commands.UpdateBlog;
using ELearningSystem.Application.Features.BlogFeatures.Queries.GetAllBlog;
using ELearningSystem.Application.Features.BlogFeatures.Queries.GetAllBlogWithCategory;
using ELearningSystem.Application.Features.BlogFeatures.Queries.GetOneBlog;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ELearningSystem.Presentantion.Controllers;

[ApiController]
[Route("[controller]")]
public class BlogController(IMediator _mediator) : ControllerBase
{
    [HttpPost("[action]")]
    public async Task<IActionResult> CreateAsync(CreateBlogCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateAsync(UpdateBlogCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpDelete("[action]")]
    public async Task<IActionResult> DeleteAsync(DeleteBlogCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpGet("[action]")]
    public async Task<IActionResult> GetAllAsync([FromQuery] GetAllBlogQuery request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpGet("[action]")]
    public async Task<IActionResult> GetByIdAsync([FromQuery] GetOneBlogQuery request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));
    [HttpGet("[action]")]
    public async Task<IActionResult> GetListWithCategoryAsync([FromQuery] GetAllBlogWithCategoryQuery request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));
}
