namespace Approvals.Core.Models;

public class Decision
{
    public int Id { get; set; }
    public int AccessRequestId { get; set; }
    public int ApproverId { get; set; }
    public bool IsApproved { get; set; }
    public string? Comment { get; set; }
    public DateTime DecisionDate { get; set; } = DateTime.UtcNow;

    public virtual AccessRequest AccessRequest { get; set; } = null!;
    public virtual User Approver { get; set; } = null!;
}
