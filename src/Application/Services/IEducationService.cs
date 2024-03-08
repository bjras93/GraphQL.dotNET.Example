using Domain.Models;

namespace Application.Services;

public interface IEducationService
{
    /// <summary>
    /// Sends create request to repository
    /// </summary>
    /// <returns>
    /// Instance of created <see cref="Education"/>
    /// <para>
    /// Null when it is unable to create
    /// </para>
    /// </returns>
    Task<Education?> CreateAsync(Education education);
    /// <summary>
    /// Gets all <see cref="Education"/> as list from repository
    /// </summary>
    /// <returns>
    /// List of instances in the repository
    /// </returns>
    Task<IEnumerable<Education>> GetAsync();
}