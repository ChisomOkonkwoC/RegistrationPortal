using Application.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Infastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<WorkFlow> workFlows { get; set; }
        public DbSet<ApplicationForm> applicationForms { get; set; }
        public DbSet<StageType> stageTypes { get; set; }
        public DbSet<VideoInterview> videoInterviews { get; set; }
        public DbSet<Preview> previews { get; set; }
        public DbSet<ProgramDetail> programDetails { get; set; }


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