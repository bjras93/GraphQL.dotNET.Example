using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Repository.Contexts;
using Repository.Repositories;
using Repository.Tables;

public sealed class EducationRepository(
    ILogger<EducationRepository> logger,
    TestContext context) :
    RepositoryBase<TestContext>(context), IEducationRepository
{
    private ILogger<EducationRepository> Logger { get; } = logger;

    public async Task<EducationTable?> CreateAsync(EducationTable table)
    {
        try
        {
            Context.EducationRows.Add(table);
            var rowsAffected = await Context.SaveChangesAsync();

            if (rowsAffected == 0)
                return null;

            return table;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Received exception in {RepositoryName}", nameof(EducationRepository));
            throw;
        }
    }

    public async Task<IEnumerable<EducationTable>> GetAsync()
    {
        try
        {
            var educations = await Context.EducationRows
                .ToListAsync();

            return educations;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Received exception in {RepositoryName}", nameof(EducationRepository));
            throw;
        }
    }

    public async Task<EducationTable?> GetAsync(int id)
    {
        try
        {
            var education = await Context.EducationRows.FindAsync(id);

            return education;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Received exception in {RepositoryName}", nameof(EducationRepository));
            throw;
        }
    }
}
