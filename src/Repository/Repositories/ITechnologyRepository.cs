using System.Linq.Expressions;
using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Repository.Repositories;

public interface ITechnologyRepository
{
    /// <summary>
    /// Attempts to insert instance into repository
    /// </summary>
    /// <param name="table">Instance to create</param>
    /// <returns>The created <see cref="TechnologyTable" /> or null if it is unable to insert instance</returns>
    Task<TechnologyTable?> CreateAsync(TechnologyTable table);
    /// <summary>
    /// Gets <see cref="TechnologyTable" /> from repository by identifiers
    /// </summary>
    /// <param name="id">Identifier of the instance</param>
    /// <returns>Array of <see cref="TechnologyTable" /> if any exists otherwise null</returns>
    Task<IEnumerable<TechnologyTable>> GetAsync(IEnumerable<int> ids);
    /// <summary>
    /// Gets <see cref="TechnologyTable" /> from repository by identifier
    /// </summary>
    /// <param name="id">Identifier of the instance</param>
    /// <returns><see cref="TechnologyTable" /> if any exists otherwise null</returns>
    Task<TechnologyTable?> GetAsync(int id);
    /// <summary>
    /// Gets all instances repository
    /// </summary>
    /// <returns>Array of <see cref="TechnologyTable" /></returns>
    Task<IEnumerable<TechnologyTable>> GetAsync();
    /// <summary>
    /// Gets all instances that matches expression
    /// </summary>
    /// <returns>Array of <see cref="TechnologyTable" /></returns>
    Task<IEnumerable<TechnologyTable>> GetByAsync(Expression<Func<TechnologyTable, bool>> expression);
}