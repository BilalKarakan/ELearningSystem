namespace ELearningSystem.Domain.Entities;

public class Subscriber : BaseEntity
{
    public string Email { get; set; }
    public bool IsActive { get; set; }
}
