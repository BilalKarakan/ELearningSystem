using ELearningSystem.Domain.IRepositories;
using ELearningSystem.Persistance.Context;
using System.Threading.Tasks;

namespace ELearningSystem.Persistance.Repositories;

public class UnitOfWork(ELearningSystemDbContext _context) : IUnitOfWork
{
    public void SaveChanges() => _context.SaveChanges();

    public async Task SaveChangesAsync() => await _context.SaveChangesAsync();
}
