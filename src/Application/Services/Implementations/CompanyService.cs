using Microsoft.Extensions.Logging;
using MindworkingTest.Application.Mappers;
using MindworkingTest.Application.Services;
using MindworkingTest.Domain.Models;
using MindworkingTest.Repository.Repositories;

public sealed class CompanyService : ICompanyService
{
    public readonly ILogger<CompanyService> Logger;
    public readonly ICompanyRepository Repository;
    public CompanyService(
        ILogger<CompanyService> logger,
        ICompanyRepository repository
    )
    {
        Logger = logger;
        Repository = repository;
    }
    public async Task<Company?> CreateAsync(Company company)
    {
        var row = CompanyTableMapper.Map(company);

        var newCompany = await Repository.CreateAsync(row);

        if (newCompany == null)
            return null;

        var mappedCompany = CompanyMapper.Map(newCompany);

        return mappedCompany;
    }

    public async Task<IEnumerable<Company>> GetAsync()
    {
        var rows = await Repository.GetAsync();

        var mappedCompanies = CompanyMapper.Map(rows);

        return mappedCompanies;
    }

    public async Task<Company?> GetAsync(int id)
    {
        var row = await Repository.GetAsync(id);

        if (row == null)
        {
            Logger.LogInformation("Id {CompanyId} does not exist", id);
            return null;
        }

        var mappedCompanies = CompanyMapper.Map(row);

        return mappedCompanies;
    }
}
