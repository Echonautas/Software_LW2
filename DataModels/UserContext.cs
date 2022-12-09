using Microsoft.EntityFrameworkCore;
using WebAPI;

public class RallyContext : DbContext
{
    public RallyContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Rally> Rally => Set<Rally>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Rally>()
            .HasKey(b => b.TeamID);

        modelBuilder.Entity<Rally>().ToTable("teams",schema: "rally");

        modelBuilder.Entity<RallyDrivers>().ToTable("drivers", schema: "rally");
    }
}