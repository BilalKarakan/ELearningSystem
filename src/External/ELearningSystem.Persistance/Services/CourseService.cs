using AutoMapper;
using ELearningSystem.Application.Features.CourseFeatures.Commands.CreateCourse;
using ELearningSystem.Application.Features.CourseFeatures.Commands.DeleteCourse;
using ELearningSystem.Application.Features.CourseFeatures.Commands.UpdateCourse;
using ELearningSystem.Application.Features.CourseFeatures.Queries.GetAllCourse;
using ELearningSystem.Application.Features.CourseFeatures.Queries.GetAllCourseWithCategory;
using ELearningSystem.Application.Features.CourseFeatures.Queries.GetOneCourse;
using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using ELearningSystem.Domain.IRepositories.Course;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ELearningSystem.Persistance.Services;

public class CourseService(ICourseCommandRepository _commandRepository, ICourseQueryRepository _queryRepository, IMapper _mapper) : ICourseService
{
    public Task CreateAsync(CreateCourseCommand request, CancellationToken cancellationToken) => _commandRepository.CreateAsync(_mapper.Map<Course>(request), cancellationToken);

    public void Delete(DeleteCourseCommand request, CancellationToken cancellationToken) => _commandRepository.Delete(_mapper.Map<Course>(request), cancellationToken);

    public async Task<Course> GetByIdAsync(GetOneCourseQuery request, CancellationToken cancellationToken) => await _queryRepository.GetByIdAsync(request.Id, cancellationToken);

    public async Task<PagedResult<Course>> GetListAsync(GetAllCourseQuery request, CancellationToken cancellationToken)
    {
        IQueryable<Course> courses = _queryRepository.GetQueryable(cancellationToken);

        if (!string.IsNullOrEmpty(request.Search))
            courses = courses.Where(c => EF.Functions.Like(c.Description, c.Name, $"%{request.Search}%"));

        int totalCount = await courses.CountAsync();
        List<Course> items = await courses.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToListAsync();
        return new PagedResult<Course>(items, totalCount, request.PageNumber, request.PageSize);
    }

    public void Update(UpdateCourseCommand request, CancellationToken cancellationToken) => _commandRepository.Update(_mapper.Map<Course>(request), cancellationToken);
    public async Task<PagedResult<Course>> GetListWithCategoryAsync(GetAllCourseWithCategoryQuery request, CancellationToken cancellationToken)
    {
        IEnumerable<Course> courseWithCategories = await _queryRepository.GetListWithCategoryAsync(cancellationToken);

        if (!string.IsNullOrEmpty(request.Search))
            courseWithCategories = courseWithCategories.Where(cc => EF.Functions.Like(cc.Description, cc.Name, $"%{request.Search}%"));

        int totalCount = courseWithCategories.Count();
        IEnumerable<Course> items = courseWithCategories.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToList();
        return new PagedResult<Course>(items, totalCount, request.PageNumber, request.PageSize);
    }
}
