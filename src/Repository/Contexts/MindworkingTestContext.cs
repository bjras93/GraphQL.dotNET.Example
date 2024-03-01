using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MindworkingTest.Repository.Models;
using MindworkingTest.Repository.Options;

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
    public DbSet<TechnologyColumn> TechnologyColumns { get; set; }
}