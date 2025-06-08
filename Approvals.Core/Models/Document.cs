namespace Approvals.Core.Models;

public class Document
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string FilePath { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    public virtual ICollection<AccessRequest> AccessRequests { get; set; } = [];
}
