using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Repository.Contexts;
using Repository.Tables;

namespace Repository.Repositories.Implementations;

public sealed class CompanyRepository :
    RepositoryBase<TestContext>, ICompanyRepository
{
    private ILogger<CompanyRepository> Logger { get; }

    public CompanyRepository(
        ILogger<CompanyRepository> logger,
        TestContext context) : base(context)
    {
        Logger = logger;
    }

    public async Task<CompanyTable?> CreateAsync(CompanyTable table)
    {
        try
        {
            Context.CompanyRows.Add(table);
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
                .ToListAsync();

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
