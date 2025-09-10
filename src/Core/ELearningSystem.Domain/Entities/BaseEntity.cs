namespace ELearningSystem.Domain.Entities;

public abstract class BaseEntity
{
    public string Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }

    protected BaseEntity()
    {
        this.Id = Guid.NewGuid().ToString();
    }
}
