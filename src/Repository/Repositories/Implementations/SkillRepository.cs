using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Repository.Contexts;
using Repository.Repositories;
using Repository.Tables;

public sealed class SkillRepository :
    RepositoryBase<TestContext>, ISkillRepository
{
    private ILogger<SkillRepository> Logger { get; }
    public SkillRepository(
        ILogger<SkillRepository> logger,
        TestContext context) : base(context)
    {
        Logger = logger;
    }

    public async Task<SkillTable?> CreateAsync(SkillTable table)
    {
        try
        {
            Context.SkillRows.Add(table);
            var rowsAffected = await Context.SaveChangesAsync();

            if (rowsAffected == 0)
                return null;

            return table;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Received exception in {RepositoryName}", nameof(SkillRepository));
            throw;
        }
    }

    public async Task<IEnumerable<SkillTable>> GetAsync()
    {
        try
        {
            var skills = await Context.SkillRows
                .ToListAsync();

            return skills;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Received exception in {RepositoryName}", nameof(SkillRepository));
            throw;
        }
    }

    public async Task<SkillTable?> GetAsync(int id)
    {
        try
        {
            var skill = await Context.SkillRows.FindAsync(id);

            return skill;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Received exception in {RepositoryName}", nameof(SkillRepository));
            throw;
        }
    }
}
