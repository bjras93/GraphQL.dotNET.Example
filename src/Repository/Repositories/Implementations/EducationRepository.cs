using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MindworkingTest.Repository.Contexts;
using MindworkingTest.Repository.Repositories;
using MindworkingTest.Repository.Tables;

public sealed class EducationRepository :
    RepositoryBase<MindworkingTestContext>, IEducationRepository
{
    private ILogger<EducationRepository> Logger { get; }
    public EducationRepository(
        ILogger<EducationRepository> logger,
        MindworkingTestContext context) : base(context)
    {
        Logger = logger;
    }

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
