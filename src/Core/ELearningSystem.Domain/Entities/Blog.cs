namespace ELearningSystem.Domain.Entities;

public class Blog : BaseEntity
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string ImageUrl { get; set; }
    public DateTime PublishDate { get; set; }
    public string BlogCategoryId { get; set; }
    public BlogCategory BlogCategory { get; set; }
}
