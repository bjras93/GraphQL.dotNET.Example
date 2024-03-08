using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Repository.Contexts;
using Repository.Tables;

namespace Repository.Repositories.Implementations;

public sealed class TechnologyRepository(
    ILogger<TechnologyRepository> logger,
    TestContext context) :
    RepositoryBase<TestContext>(context), ITechnologyRepository
{
    private ILogger<TechnologyRepository> Logger { get; } = logger;

    public async Task<TechnologyTable?> CreateAsync(TechnologyTable table)
    {
        try
        {
            Context.TechnologyRows.Add(table);
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

    public async Task<IEnumerable<TechnologyTable>> GetAsync(IEnumerable<int> ids)
    {
        try
        {
            var technologies = await Context.TechnologyRows
                .Where(t => ids.Contains(t.Id))
                .ToListAsync();

            return technologies;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Received exception in {RepositoryName}", nameof(TechnologyRepository));
            throw;
        }
    }

    public async Task<TechnologyTable?> GetAsync(int id)
    {
        try
        {
            var technology = await Context.TechnologyRows.FindAsync(id);

            return technology;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Received exception in {RepositoryName}", nameof(TechnologyRepository));
            throw;
        }
    }
    public async Task<IEnumerable<TechnologyTable>> GetAsync()
    {
        try
        {
            var technologies = await Context.TechnologyRows
                .ToListAsync();

            return technologies;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Received exception in {RepositoryName}", nameof(TechnologyRepository));
            throw;
        }
    }

    public async Task<IEnumerable<TechnologyTable>> GetByAsync(Expression<Func<TechnologyTable, bool>> expression)
    {
        try
        {
            var technologies = await Context.TechnologyRows
                .Where(expression)
                .ToListAsync();

            return technologies;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Received exception in {RepositoryName}", nameof(TechnologyRepository));
            throw;
        }
    }
}