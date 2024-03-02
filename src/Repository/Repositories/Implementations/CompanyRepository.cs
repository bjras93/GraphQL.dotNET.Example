using MindworkingTest.Repository.Contexts;
using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Repository.Repositories.Implementations;

public sealed class CompanyRepository :
    RepositoryBase<MindworkingTestContext>, ICompanyRepository
{
    public CompanyRepository(MindworkingTestContext context) : base(context)
    {
    }

    public Task<CompanyTable?> CreateAsync(CompanyTable table)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CompanyTable>> GetAsync()
    {
        throw new NotImplementedException();
    }

    public Task<CompanyTable?> GetAsync(int id)
    {
        throw new NotImplementedException();
    }
}
