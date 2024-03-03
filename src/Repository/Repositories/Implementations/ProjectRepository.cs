using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MindworkingTest.Repository.Contexts;
using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Repository.Repositories.Implementations;

public sealed class ProjectRepository : RepositoryBase<MindworkingTestContext>, IProjectRepository
{
    private ILogger<ProjectRepository> Logger { get; }

    public ProjectRepository(
        ILogger<ProjectRepository> logger,
        MindworkingTestContext context) : base(context)
    {
        Logger = logger;
    }

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
