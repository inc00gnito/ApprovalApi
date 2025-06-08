using Microsoft.EntityFrameworkCore;

namespace Approvals.Infrastructure.Database
{
    public class AppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("ApprovalsDatabase");
        }
    }
}
