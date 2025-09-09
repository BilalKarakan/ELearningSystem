namespace ELearningSystem.Domain.IRepositories;

public interface IUnitOfWork
{
    Task SaveChangesAsync();
    void SaveChanges();
}
