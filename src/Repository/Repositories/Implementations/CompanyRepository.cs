using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MindworkingTest.Repository.Contexts;
using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Repository.Repositories.Implementations;

public sealed class CompanyRepository :
    RepositoryBase<MindworkingTestContext>, ICompanyRepository
{
    private ILogger<CompanyRepository> Logger { get; }

    public CompanyRepository(
        ILogger<CompanyRepository> logger,
        MindworkingTestContext context) : base(context)
    {
        Logger = logger;
    }

    public async Task<CompanyTable?> CreateAsync(CompanyTable table)
    {
        try
        {
            _ = await Context.CompanyRows.AddAsync(table);
            var rowsAffected = await Context.SaveChangesAsync();

            if (rowsAffected == 0)
                return null;

            return table;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Received exception in {RepositoryName}", nameof(CompanyRepository));
            throw;
        }
    }

    public async Task<IEnumerable<CompanyTable>> GetAsync()
    {
        try
        {
            var companies = await Context.CompanyRows
                .ToArrayAsync();

            return companies;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Received exception in {RepositoryName}", nameof(CompanyRepository));
            throw;
        }
    }

    public async Task<CompanyTable?> GetAsync(int id)
    {
        try
        {
            var company = await Context.CompanyRows.FindAsync(id);

            return company;
        }
        catch (Exception ex)
        {
            Logger.LogError(ex, "Received exception in {RepositoryName}", nameof(CompanyRepository));
            throw;
        }
    }
}
