namespace ELearningSystem.Application.Shared;

public class PagedResult<T> where T : class
{
    public IEnumerable<T> Items { get; set; }
    public int ToTalCount { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }

    public PagedResult(IEnumerable<T> items, int totalCount, int pageNumber, int pageSize)
    {
        this.Items = items;
        this.ToTalCount = totalCount;
        this.PageNumber = pageNumber;
        this.PageSize = pageSize;
    }
}
