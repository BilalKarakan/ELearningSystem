using ELearningSystem.Application.Features.BlogCategoryFeatures.Commands.CreateBlogCategory;
using ELearningSystem.Application.Features.BlogCategoryFeatures.Commands.DeleteBlogCategory;
using ELearningSystem.Application.Features.BlogCategoryFeatures.Commands.UpdateBlogCategory;
using ELearningSystem.Application.Features.BlogCategoryFeatures.Queries.GetAllBlogCategory;
using ELearningSystem.Application.Features.BlogCategoryFeatures.Queries.GetAllBlogCategoryWithBlog;
using ELearningSystem.Application.Features.BlogCategoryFeatures.Queries.GetOneBlogCategory;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ELearningSystem.Presentantion.Controllers;

[ApiController]
[Route("[controller]")]
public class BlogCategoryController(IMediator _mediator) : ControllerBase
{
    [HttpPost("[action]")]
    public async Task<IActionResult> CreateAsync(CreateBlogCategoryCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateAsync(UpdateBlogCategoryCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpDelete("[action]")]
    public async Task<IActionResult> DeleteAsync(DeleteBlogCategoryCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpGet("[action]")]
    public async Task<IActionResult> GetAllAsync([FromQuery] GetAllBlogCategoryQuery request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpGet("[action]")]
    public async Task<IActionResult> GetByIdAsync([FromQuery] GetOneBlogCategoryQuery request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));
    
    [HttpGet("[action]")]
    public async Task<IActionResult> GetListWithBlogAsync([FromQuery] GetAllBlogCategoryWithBlogQuery request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));
}
