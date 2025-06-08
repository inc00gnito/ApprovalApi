namespace Approvals.Core.DTOs;

public class AccessRequestResponseDto
{
    public int Id { get; set; }
    public int DocumentId { get; set; }
    public string DocumentTitle { get; set; } = string.Empty;
    public string Reason { get; set; } = string.Empty;
    public string RequestedAccessType { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string? Comment { get; set; }
    public DateTime RequestDate { get; set; }
    public DateTime? DecisionDate { get; set; }
}
