using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MindworkingTest.Repository.Contexts;
using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Repository.Repositories.Implementations;

public sealed class ProjectTechnologyRepository :
    RepositoryBase<MindworkingTestContext>, IProjectTechnologyRepository
{
    private ILogger<ProjectTechnologyRepository> Logger { get; }

    public ProjectTechnologyRepository(
        ILogger<ProjectTechnologyRepository> logger,
        MindworkingTestContext context) : base(context)
    {
        Logger = logger;
    }

    public async Task<ProjectTechnologyTable?> CreateAsync(
        ProjectTechnologyTable table)
    {
        try
        {
            Context.ProjectTechnologyRows.Add(table);
            var rowsAffected = await Context.SaveChangesAsync();

            if (rowsAffected == 0)
                return null;

            return table;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Received exception in {RepositoryName}", nameof(ProjectTechnologyRepository));
            throw;
        }
    }

    public async Task<IEnumerable<ProjectTechnologyTable>> GetByProjectAsync(
        int projectId)
    {
        try
        {
            var projectTechnologies = await Context.ProjectTechnologyRows
                .Where(p => p.ProjectId == projectId)
                .ToListAsync();

            return projectTechnologies;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Received exception in {RepositoryName}", nameof(ProjectTechnologyRepository));
            throw;
        }
    }

    public async Task<IEnumerable<ProjectTechnologyTable>> GetByAsync(
        Expression<Func<ProjectTechnologyTable, bool>> expression)
    {
        try
        {
            var projectTechnologies = await Context.ProjectTechnologyRows
                .Where(expression)
                .ToListAsync();

            return projectTechnologies;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Received exception in {RepositoryName}", nameof(ProjectTechnologyRepository));
            throw;
        }
    }
}
