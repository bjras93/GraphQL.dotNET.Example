using Application.Common.Extensions;
using Domain.Models;
using Repository.Tables;

namespace Application.Mappers;

public static class CompanyTableMapper
{
    /// <summary>
    /// Creates new instance of <see cref="CompanyTable"/> from <see cref="Company"/>
    /// </summary>
    /// <returns>New instance of <see cref="CompanyTable"/></returns>
    public static CompanyTable Map(Company company)
    => new()
    {
        Id = company.Id,
        Name = company.Name,
        StartDate = company.StartDate.ToString("O"),
        EndDate = company.EndDate.ToStringOrNull("O")
    };
    /// <summary>
    /// Creates new instances of <see cref="CompanyTable"/> from enumerable <see cref="Company"/>
    /// </summary>
    /// <returns>List of <see cref="CompanyTable"/></returns>
    public static IEnumerable<CompanyTable> Map(
        IEnumerable<Company> companies)
    => companies.Select(Map).ToList();
}