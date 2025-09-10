namespace ELearningSystem.Application.Shared;

public class PagedResult<T>
{
    public IEnumerable<T> Items { get; set; }
    public int TotalCount { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }

    public PagedResult(IEnumerable<T> items, int totalCount, int pageNumber, int pageSize)
    {
        this.Items = items;
        this.TotalCount = totalCount;
        this.PageNumber = pageNumber;
        this.PageSize = pageSize;
    }
}
