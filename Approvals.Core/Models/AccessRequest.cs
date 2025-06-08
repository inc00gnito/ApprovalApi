using Approvals.Core.Models.Enums;

namespace Approvals.Core.Models;

public class AccessRequest
{
    public int Id { get; set; }
    public int DocumentId { get; set; }
    public int UserId { get; set; }
    public string Reason { get; set; } = string.Empty;
    public AccessType RequestedAccessType { get; set; }
    public RequestStatus Status { get; set; } = RequestStatus.Pending;
    public string? Comment { get; set; }
    public DateTime RequestDate { get; set; } = DateTime.UtcNow;
    public DateTime? DecisionDate { get; set; }

    public virtual Document Document { get; set; } = null!;
    public virtual User User { get; set; } = null!;
    public virtual ICollection<Decision> Decisions { get; set; } = new List<Decision>();
}
