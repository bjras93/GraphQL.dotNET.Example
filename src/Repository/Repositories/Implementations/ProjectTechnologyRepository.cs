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
            var result = await Context.ProjectTechnologyRows.AddAsync(table);
            var rowsAffected = await Context.SaveChangesAsync();

            if (rowsAffected == 0)
                return null;
            return table;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Received exception in {RepositoryName}", nameof(TechnologyRepository));
            throw;
        }
    }

    public async Task<IEnumerable<ProjectTechnologyTable>> GetByProjectAsync(
        int projectId)
    {
        try
        {
            var result = await Context.ProjectTechnologyRows
                .Where(p => p.ProjectId == projectId)
                .ToArrayAsync();

            return result;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Received exception in {RepositoryName}", nameof(TechnologyRepository));
            throw;
        }
    }

    public async Task<IEnumerable<ProjectTechnologyTable>> GetByAsync(
        Expression<Func<ProjectTechnologyTable, bool>> expression)
    {
        try
        {
            var result = await Context.ProjectTechnologyRows
                .Where(expression)
                .ToArrayAsync();

            return result;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Received exception in {RepositoryName}", nameof(TechnologyRepository));
            throw;
        }
    }
}
