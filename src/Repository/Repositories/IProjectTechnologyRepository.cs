using System.Linq.Expressions;
using Repository.Tables;

namespace Repository.Repositories;

public interface IProjectTechnologyRepository
{
    /// <summary>
    /// Attempts to insert instance into repository
    /// </summary>
    /// <param name="table">Instance to create</param>
    /// <returns>The created <see cref="ProjectTechnologyTable" /> or null if it is unable to insert instance</returns>
    Task<ProjectTechnologyTable?> CreateAsync(ProjectTechnologyTable table);
    /// <summary>
    /// Gets instances by project identifier from repository
    /// </summary>
    /// <returns>List of <see cref="ProjectTechnologyTable" /></returns>
    Task<IEnumerable<ProjectTechnologyTable>> GetByProjectAsync(int projectId);
    /// <summary>
    /// Gets all instances that matches expression
    /// </summary>
    /// <returns>List of <see cref="TechnologyTable" /></returns>
    Task<IEnumerable<ProjectTechnologyTable>> GetByAsync(Expression<Func<ProjectTechnologyTable, bool>> expression);
}