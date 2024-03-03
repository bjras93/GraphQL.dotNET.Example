using System.Linq.Expressions;
using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Repository.Repositories;

public interface IProjectRepository
{
    /// <summary>
    /// Attempts to insert instance into repository
    /// </summary>
    /// <param name="table">Instance to create</param>
    /// <returns>The created <see cref="ProjectTable" /> or null if it is unable to insert instance</returns>
    Task<ProjectTable?> CreateAsync(ProjectTable table);
    /// <summary>
    /// Gets all instances repository
    /// </summary>
    /// <returns>List of <see cref="ProjectTable" /></returns>
    Task<IEnumerable<ProjectTable>> GetAsync();
    /// <summary>
    /// Gets all instances that matches expression
    /// </summary>
    /// <returns>List of <see cref="TechnologyTable" /></returns>
    Task<IEnumerable<ProjectTable>> GetByAsync(Expression<Func<ProjectTable, bool>> expression);
}