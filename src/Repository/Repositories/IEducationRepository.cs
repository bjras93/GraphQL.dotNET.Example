using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Repository.Repositories;

public interface IEducationRepository
{
    /// <summary>
    ///     Attempts to insert <see cref="EducationTable"/> instance into repository
    /// </summary>
    /// <param name="table">Instance to create</param>
    /// <returns>
    /// The created <see cref="EducationTable" /> 
    /// <para>
    ///     Null if it is unable to insert instance
    /// </para>
    /// </returns>
    Task<EducationTable?> CreateAsync(EducationTable table);
    /// <summary>
    ///     Gets all instances from repository
    /// </summary>
    /// <returns>
    ///     Array of <see cref="EducationTable" />
    /// </returns>
    Task<IEnumerable<EducationTable>> GetAsync();
    /// <summary>
    ///     Gets single instance
    /// </summary>
    /// <returns>
    ///      <see cref="EducationTable" />
    /// <para>
    ///     Null when no instance with <paramref name="id"/>
    /// </para>
    /// </returns>
    Task<EducationTable?> GetAsync(int id);
}