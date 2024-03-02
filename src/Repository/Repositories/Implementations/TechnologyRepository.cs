using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MindworkingTest.Repository.Contexts;
using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Repository.Repositories.Implementations;

public sealed class TechnologyRepository :
    RepositoryBase<MindworkingTestContext>, ITechnologyRepository
{
    private ILogger<TechnologyRepository> Logger { get; }
    public TechnologyRepository(
        ILogger<TechnologyRepository> logger,
        MindworkingTestContext context) : base(context)
    {
        Logger = logger;
    }
    public async Task<TechnologyTable?> CreateAsync(TechnologyTable table)
    {
        try
        {
            var result = await Context.TechnologyRows.AddAsync(table);
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
            var result = await Context.TechnologyRows
                .Where(t => ids.Contains(t.Id))
                .ToArrayAsync();

            return result;
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
            var result = await Context.TechnologyRows.FindAsync(id);
            return result;
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
            var result = await Context.TechnologyRows.ToArrayAsync();
            return result;
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
            var result = await Context.TechnologyRows
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