namespace ELearningSystem.Domain.Entities;

public class Course : BaseEntity
{
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public string CourseCategoryId { get; set; }
    public CourseCategory CourseCategory { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public bool IsShown { get; set; }
}
