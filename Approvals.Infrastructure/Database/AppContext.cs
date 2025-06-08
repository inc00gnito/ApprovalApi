using Approvals.Core.Models;
using Approvals.Core.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using Document = Approvals.Core.Models.Document;

namespace Approvals.Infrastructure.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships
            modelBuilder.Entity<AccessRequest>()
                .HasOne(ar => ar.Document)
                .WithMany(d => d.AccessRequests)
                .HasForeignKey(ar => ar.DocumentId);

            modelBuilder.Entity<AccessRequest>()
                .HasOne(ar => ar.User)
                .WithMany(u => u.AccessRequests)
                .HasForeignKey(ar => ar.UserId);

            modelBuilder.Entity<Decision>()
                .HasOne(d => d.AccessRequest)
                .WithMany(ar => ar.Decisions)
                .HasForeignKey(d => d.AccessRequestId);

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Jan User", Email = "januser@test.com", Role = UserRole.User },
                new User { Id = 2, Name = "Tomasz Approver", Email = "tomaszapprover@test.com", Role = UserRole.Approver }
            );

            modelBuilder.Entity<Document>().HasData(
                new Document { Id = 1, Title = "Confidential Report", Description = "Q4 Financial Report", FilePath = "/docs/dokument1.pdf" },
                new Document { Id = 2, Title = "Strategy Document", Description = "Company Strategy 2024", FilePath = "/docs/dokument2.pdf" }
            );
        }
    }
}
