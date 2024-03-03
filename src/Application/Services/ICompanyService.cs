using MindworkingTest.Domain.Models;

namespace MindworkingTest.Application.Services;

public interface ICompanyService
{
    /// <summary>
    /// Sends create request to repository
    /// </summary>
    /// <returns>
    /// Instance of created <see cref="Company"/>
    /// <para>
    /// Null when it is unable to create
    /// </para>
    /// </returns>
    Task<Company?> CreateAsync(Company company);
    /// <summary>
    /// Gets all <see cref="Company"/> as list from repository
    /// </summary>
    /// <returns>
    /// List of instances in the repository
    /// </returns>
    Task<IEnumerable<Company>> GetAsync();
    /// <summary>
    /// Gets <see cref="Company"/> from repository
    /// </summary>
    /// <param name="id"></param>
    /// <returns>
    /// Single instance of <see cref="Company"/>
    /// </returns>
    Task<Company?> GetAsync(int id);
}