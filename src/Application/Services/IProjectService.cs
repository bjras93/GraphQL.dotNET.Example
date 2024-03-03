using MindworkingTest.Domain.Models;

namespace MindworkingTest.Application.Services;

public interface IProjectService
{
    /// <summary>
    /// Sends create request to repository
    /// </summary>
    /// <returns>
    /// Instance of created <see cref="Project"/>
    /// <para>
    /// Null when it is unable to create
    /// </para>
    /// </returns>
    Task<Project?> CreateAsync(Project project);
    /// <summary>
    /// Gets all <see cref="Project"/> as list from repository
    /// </summary>
    /// <returns>
    /// List of instances in the repository
    /// </returns>
    Task<IEnumerable<Project>> GetAsync();
    /// <summary>
    /// Adds technology to project
    /// </summary>
    /// <param name="id"></param>
    /// <param name="technologyId"></param>
    /// <returns>
    /// New instance added to repository
    /// <para>
    /// Null if unable to create
    /// </para>
    /// </returns>
    Task<ProjectTechnology?> AddTechnologyAsync(int id, int technologyId);
}