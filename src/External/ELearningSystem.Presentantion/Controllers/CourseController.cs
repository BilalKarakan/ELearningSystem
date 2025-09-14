using ELearningSystem.Application.Features.ContactFeatures.Commands.CreateContact;
using ELearningSystem.Application.Features.ContactFeatures.Commands.DeleteContact;
using ELearningSystem.Application.Features.ContactFeatures.Commands.UpdateContact;
using ELearningSystem.Application.Features.ContactFeatures.Queries.GetAllContact;
using ELearningSystem.Application.Features.ContactFeatures.Queries.GetOneContact;
using ELearningSystem.Application.Features.CourseFeatures.Commands.CreateCourse;
using ELearningSystem.Application.Features.CourseFeatures.Commands.DeleteCourse;
using ELearningSystem.Application.Features.CourseFeatures.Commands.UpdateCourse;
using ELearningSystem.Application.Features.CourseFeatures.Queries.GetAllCourse;
using ELearningSystem.Application.Features.CourseFeatures.Queries.GetAllCourseWithCategory;
using ELearningSystem.Application.Features.CourseFeatures.Queries.GetOneCourse;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ELearningSystem.Presentantion.Controllers;

[ApiController]
[Route("[controller]")]
public class CourseController(IMediator _mediator) : ControllerBase
{
    [HttpPost("[action]")]
    public async Task<IActionResult> CreateAsync(CreateCourseCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpDelete("[action]")]
    public async Task<IActionResult> DeleteAsync(DeleteCourseCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpPut("[action]")]
    public async Task<IActionResult> UpdateAsync(UpdateCourseCommand request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpGet("[action]")]
    public async Task<IActionResult> GetByIdAsync([FromQuery] GetOneCourseQuery request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpGet("[action]")]
    public async Task<IActionResult> GetListAsync([FromQuery] GetAllCourseQuery request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));

    [HttpGet("[action]")]
    public async Task<IActionResult> GetListCourseWithCategoryAsync([FromQuery] GetAllCourseWithCategoryQuery request, CancellationToken cancellationToken) => Ok(await _mediator.Send(request, cancellationToken));
}
