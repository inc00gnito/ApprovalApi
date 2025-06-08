namespace Approvals.Core.DTOs;

public class CreateAccessRequestDto
{
    public int DocumentId { get; set; }
    public string Reason { get; set; } = string.Empty;
    public int RequestedAccessType { get; set; }
}
