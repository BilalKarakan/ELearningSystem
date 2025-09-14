using ELearningSystem.Domain.IRepositories;
using ELearningSystem.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace ELearningSystem.Persistance.Repositories;

public class GenericQueryRepository<T> : IGenericQueryRepository<T> where T : class
{
    protected readonly ELearningSystemDbContext _context;

    public GenericQueryRepository(ELearningSystemDbContext context)
    {
        _context = context;
    }

    public async Task<T> GetByIdAsync(string id, CancellationToken cancellationToken = default) => (await _context.Set<T>().FindAsync(id))!;

    public async Task<ICollection<T>> GetListAsync(CancellationToken cancellationToken = default) => await _context.Set<T>().AsNoTracking().ToListAsync(cancellationToken);

    public IQueryable<T> GetQueryable(CancellationToken cancellationToken = default) => _context.Set<T>().AsNoTracking().AsQueryable();
}
