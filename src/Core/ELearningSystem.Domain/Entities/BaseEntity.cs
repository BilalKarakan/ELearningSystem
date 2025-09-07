namespace ELearningSystem.Domain.Entities;

public abstract class BaseEntity
{
    public string Id { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }

    protected BaseEntity()
    {
        this.Id = Guid.NewGuid().ToString();
    }
}
