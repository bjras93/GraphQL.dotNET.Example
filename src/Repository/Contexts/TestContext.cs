using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Repository.Common.Options;
using Repository.Tables;

namespace Repository.Contexts;

public sealed class TestContext : DbContext
{
    public string Name { get; } = "test_db";
    public string Path { get; init; }
    public TestContext(
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
    public DbSet<CompanyTable> CompanyRows { get; set; }
    public DbSet<SkillTable> SkillRows { get; set; }
    public DbSet<EducationTable> EducationRows { get; set; }
}