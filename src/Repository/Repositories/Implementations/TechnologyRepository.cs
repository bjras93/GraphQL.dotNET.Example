using Microsoft.Extensions.Logging;
using MindworkingTest.Repository.Contexts;
using MindworkingTest.Repository.Models;

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
    public async Task<TechnologyColumn?> CreateAsync(TechnologyColumn column)
    {
        try
        {
            var result = await Context.TechnologyColumns.AddAsync(column);
            var rowsAffected = await Context.SaveChangesAsync();
            if (rowsAffected == 0)
                return null;
            return column;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Received exception in {RepositoryName}", nameof(TechnologyRepository));
            throw;
        }
    }

    public async Task<TechnologyColumn?> GetAsync(int id)
    {
        try
        {
            var result = await Context.TechnologyColumns.FindAsync(id);
            return result;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Received exception in {RepositoryName}", nameof(TechnologyRepository));
            throw;
        }
    }
}