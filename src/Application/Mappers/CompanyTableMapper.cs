using MindworkingTest.Application.Common.Extensions;
using MindworkingTest.Domain.Models;
using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Application.Mappers;

public static class CompanyTableMapper
{
    public static CompanyTable Map(Company company)
    => new()
    {
        Id = company.Id,
        Name = company.Name,
        StartDate = company.StartDate.ToString("O"),
        EndDate = company.EndDate.ToStringOrNull("O")
    };
    public static IEnumerable<CompanyTable> Map(
        IEnumerable<Company> tableRows)
    => tableRows.Select(Map).ToArray();
}