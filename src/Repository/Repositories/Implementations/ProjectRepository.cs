using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Repository.Contexts;
using Repository.Tables;

namespace Repository.Repositories.Implementations;

public sealed class ProjectRepository(
    ILogger<ProjectRepository> logger,
    TestContext context) : RepositoryBase<TestContext>(context), IProjectRepository
{
    private ILogger<ProjectRepository> Logger { get; } = logger;

    public async Task<ProjectTable?> CreateAsync(ProjectTable table)
    {
        try
        {
            Context.ProjectRows.Add(table);
            var rowsAffected = await Context.SaveChangesAsync();

            if (rowsAffected == 0)
                return null;

            return table;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Received exception in {RepositoryName}", nameof(ProjectRepository));
            throw;
        }
    }

    public async Task<IEnumerable<ProjectTable>> GetAsync()
    {
        try
        {
            var projects = await Context.ProjectRows
                .Include(p => p.ProjectTechnologies)
                .ToListAsync();

            return projects;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Received exception in {RepositoryName}", nameof(ProjectRepository));
            throw;
        }
    }

    public async Task<IEnumerable<ProjectTable>> GetByAsync(Expression<Func<ProjectTable, bool>> expression)
    {
        try
        {
            var projects = await Context.ProjectRows.Where(expression).ToListAsync();

            return projects;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Received exception in {RepositoryName}", nameof(ProjectRepository));
            throw;
        }
    }
}
