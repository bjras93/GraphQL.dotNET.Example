using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MindworkingTest.Repository.Options;
using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Repository.Contexts;

public sealed class MindworkingTestContext : DbContext
{
    public string Name { get; } = "MindworkingTest";
    public string Path { get; init; }
    public MindworkingTestContext(
        IOptions<DatabaseOptions> options)
    {
        options.Value.ConnectionStrings.TryGetValue(Name, out var path);
        if (string.IsNullOrWhiteSpace(path))
            throw new ApplicationException($"Configuration for {Name} is not set, check the configuration");

        Path = path;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={Path}");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ProjectTable>()
                 .HasMany(p => p.ProjectTechnologies)
                 .WithOne()
                 .HasForeignKey(p => p.ProjectId);

    }
    public DbSet<TechnologyTable> TechnologyRows { get; set; }
    public DbSet<ProjectTable> ProjectRows { get; set; }
    public DbSet<ProjectTechnologyTable> ProjectTechnologyRows { get; set; }
}