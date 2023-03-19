using Application.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Infastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<WorkFlow> WorkFlows { get; set; }
        public DbSet<ApplicationForm> ApplicationForms { get; set; }
        public DbSet<StageType> StageTypes { get; set; }
        public DbSet<VideoInterview> VideoInterviews { get; set; }
        public DbSet<Preview> Previews { get; set; }
        public DbSet<ProgramDetail> ProgramDetails { get; set; }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries().Where(entry => entry.Entity is BaseEntity);

            foreach (var entry in entries)
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        ((BaseEntity)entry.Entity).CreatedAt = ((BaseEntity)entry.Entity).CreatedAt == default ? DateTime.Now : ((BaseEntity)entry.Entity).CreatedAt;
                        break;
                    case EntityState.Modified:
                        ((BaseEntity)entry.Entity).ModifiedAt = DateTime.Now;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}