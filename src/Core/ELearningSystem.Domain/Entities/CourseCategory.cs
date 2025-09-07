namespace ELearningSystem.Domain.Entities;

public class CourseCategory : BaseEntity
{
    public string Name { get; set; }
    public string Icon { get; set; }
    public string Description { get; set; }
    public bool IsShown { get; set; }
    public ICollection<Course> Courses { get; set; }
}
