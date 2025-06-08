using Approvals.Core.Models.Enums;

namespace Approvals.Core.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public UserRole Role { get; set; }

    public virtual ICollection<AccessRequest> AccessRequests { get; set; } = [];
}
