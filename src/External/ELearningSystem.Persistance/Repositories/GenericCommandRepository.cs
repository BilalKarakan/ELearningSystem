using ELearningSystem.Domain.IRepositories;
using ELearningSystem.Persistance.Context;

namespace ELearningSystem.Persistance.Repositories;

public class GenericCommandRepository<T>(ELearningSystemDbContext _context, IUnitOfWork _unitOfWork) : IGenericCommandRepository<T> where T : class
{
    public async Task CreateAsync(T entity, CancellationToken cancellationToken = default)
    {
        await _context.Set<T>().AddAsync(entity, cancellationToken);
        await _unitOfWork.SaveChangesAsync();
    }

    public void Delete(T entity, CancellationToken cancellationToken = default)
    {
        _context.Set<T>().Remove(entity);
        _unitOfWork.SaveChanges();
    }

    public void Update(T entity, CancellationToken cancellationToken = default)
    {
        _context.Set<T>().Update(entity);
        _unitOfWork.SaveChanges();
    }
}
