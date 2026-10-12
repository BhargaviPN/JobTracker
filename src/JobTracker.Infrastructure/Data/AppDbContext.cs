using JobTracker.Domain;
using Microsoft.EntityFrameworkCore;
namespace JobTracker.Infrastructure.Data;

public class AppDbContext : DbContext
{
    //constructor
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options){

    }

    //DbSets
    public DbSet<Company> Companies { get; set; }
    public DbSet<JobApplication> JobApplications { get; set; }
    public DbSet<Interview> Interviews { get; set; }
    public DbSet<Reminder> Reminders { get; set; }
    public DbSet<StatusHistory> StatusHistories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}