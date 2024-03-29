using Domain.Models;

namespace Application.Services;

public interface ITechnologyService
{
    /// <summary>
    /// Sends create request to repository
    /// </summary>
    /// <returns>
    /// Instance of created <see cref="Technology"/>
    /// <para>
    /// Null when request is unable to create
    /// </para>
    /// </returns>
    Task<Technology?> CreateAsync(Technology technology);
    /// <summary>
    /// Gets <see cref="Technology"/> from repository
    /// </summary>
    /// <param name="id"></param>
    /// <returns>
    /// Single instance of <see cref="Technology"/>
    /// </returns>
    Task<Technology?> GetAsync(int id);
    /// <summary>
    /// Gets all <see cref="Technology"/> as list from repository
    /// </summary>
    /// <returns>
    /// List of <see cref="Technology"/>
    /// <para>
    /// Empty list when none present
    /// </para>
    /// </returns>
    Task<IEnumerable<Technology>> GetAsync();
    /// <summary>
    /// Gets <see cref="Technology" /> from repository by identifiers
    /// </summary>
    /// <param name="id">Identifier of the instance</param>
    /// <returns>List of <see cref="Technology" /> if any exists otherwise null</returns>
    Task<IEnumerable<Technology>> GetAsync(IEnumerable<int> ids);
    /// <summary>
    /// Gets <see cref="Technology"/> from repository
    /// </summary>
    /// <param name="name"></param>
    /// <returns>
    /// List of <see cref="Technology"/> 
    /// <para>
    /// Empty list when no matches
    /// </para>
    /// </returns>
    Task<IEnumerable<Technology>> GetByNameAsync(string name);
}