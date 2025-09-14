using ELearningSystem.Application.Features.ContactFeatures.Commands.CreateContact;
using ELearningSystem.Application.Features.ContactFeatures.Commands.DeleteContact;
using ELearningSystem.Application.Features.ContactFeatures.Commands.UpdateContact;
using ELearningSystem.Application.Features.ContactFeatures.Queries.GetAllContact;
using ELearningSystem.Application.Features.ContactFeatures.Queries.GetOneContact;
using ELearningSystem.Application.Features.CourseCategoryFeatures.Commands.CreateCourseCategory;
using ELearningSystem.Application.Features.CourseCategoryFeatures.Commands.DeleteCourseCategory;
using ELearningSystem.Application.Features.CourseCategoryFeatures.Commands.UpdateCourseCategory;
using ELearningSystem.Application.Features.CourseCategoryFeatures.Queries.GetAllCourseCategory;
using ELearningSystem.Application.Features.CourseCategoryFeatures.Queries.GetAllCourseCategoryWithCourse;
using ELearningSystem.Application.Features.CourseCategoryFeatures.Queries.GetOneCourseCategory;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;

namespace ELearningSystem.Presentantion.Controllers;

[ApiController]
[Route("[controller]")]
public class CourseCategoryController(IMediator _mediator) : ControllerBase
{
    [HttpPost("[action]")]
    public async Task<IActionResult> CreateAsync(CreateCourseCategoryCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpDelete("[action]")]
    public async Task<IActionResult> DeleteAsync(DeleteCourseCategoryCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateAsync(UpdateCourseCategoryCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpGet("[action]")]
    public async Task<IActionResult> GetByIdAsync([FromQuery] GetOneCourseCategoryQuery request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpGet("[action]")]
    public async Task<IActionResult> GetListAsync([FromQuery] GetAllCourseCategoryQuery request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpGet("[action]")]
    public async Task<IActionResult> GetListWithCourseAsync([FromQuery] GetAllCourseCategoryWithCourseQuery request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));
}
