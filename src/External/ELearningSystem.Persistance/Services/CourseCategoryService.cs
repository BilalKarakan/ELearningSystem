using AutoMapper;
using ELearningSystem.Application.Features.CourseCategoryFeatures.Commands.CreateCourseCategory;
using ELearningSystem.Application.Features.CourseCategoryFeatures.Commands.DeleteCourseCategory;
using ELearningSystem.Application.Features.CourseCategoryFeatures.Commands.UpdateCourseCategory;
using ELearningSystem.Application.Features.CourseCategoryFeatures.Queries.GetAllCourseCategory;
using ELearningSystem.Application.Features.CourseCategoryFeatures.Queries.GetAllCourseCategoryWithCourse;
using ELearningSystem.Application.Features.CourseCategoryFeatures.Queries.GetOneCourseCategory;
using ELearningSystem.Application.IServices;
using ELearningSystem.Application.Shared;
using ELearningSystem.Domain.Entities;
using ELearningSystem.Domain.IRepositories.CourseCategory;
using Microsoft.EntityFrameworkCore;

namespace ELearningSystem.Persistance.Services;

public class CourseCategoryService(ICourseCategoryCommandRepository _commandRepository, ICourseCategoryQueryRepository _queryRepository, IMapper _mapper) : ICourseCategoryService
{
    public Task CreateAsync(CreateCourseCategoryCommand request, CancellationToken cancellationToken) => _commandRepository.CreateAsync(_mapper.Map<CourseCategory>(request), cancellationToken);

    public void Delete(DeleteCourseCategoryCommand request, CancellationToken cancellationToken) => _commandRepository.Delete(_mapper.Map<CourseCategory>(request), cancellationToken);

    public async Task<CourseCategory> GetByIdAsync(GetOneCourseCategoryQuery request, CancellationToken cancellationToken) => await _queryRepository.GetByIdAsync(request.Id, cancellationToken);

    public async Task<PagedResult<CourseCategory>> GetListAsync(GetAllCourseCategoryQuery request, CancellationToken cancellationToken)
    {
        IQueryable<CourseCategory> courseCategories = _queryRepository.GetQueryable(cancellationToken);

        if (!string.IsNullOrEmpty(request.Search))
            courseCategories = courseCategories.Where(cc => EF.Functions.Like(cc.Name, cc.Description, $"%{request.Search}%"));

        int totalCount = await courseCategories.CountAsync();
        List<CourseCategory> items = await courseCategories.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToListAsync();
        return new PagedResult<CourseCategory>(items, totalCount, request.PageNumber, request.PageSize);
    }

    public void Update(UpdateCourseCategoryCommand request, CancellationToken cancellationToken) => _commandRepository.Update(_mapper.Map<CourseCategory>(request), cancellationToken);
    public async Task<PagedResult<CourseCategory>> GetListWithCourseAsync(GetAllCourseCategoryWithCourseQuery request, CancellationToken cancellationToken)
    {
        IEnumerable<CourseCategory> categoryWithCourses = await _queryRepository.GetListWithCourseAsync(cancellationToken);

        if (!string.IsNullOrEmpty(request.Search))
            categoryWithCourses = categoryWithCourses.Where(cc => EF.Functions.Like(cc.Name, cc.Description, $"%{request.Search}%"));

        int totalCount = categoryWithCourses.Count();
        List<CourseCategory> items = categoryWithCourses.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToList();
        return new PagedResult<CourseCategory>(items, totalCount, request.PageNumber, request.PageSize);
    }
}
