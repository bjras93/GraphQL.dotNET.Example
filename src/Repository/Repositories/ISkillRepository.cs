using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Repository.Repositories;

public interface ISkillRepository
{
    /// <summary>
    ///     Attempts to insert <see cref="SkillTable"/> instance into repository
    /// </summary>
    /// <param name="table">Instance to create</param>
    /// <returns>
    /// The created <see cref="SkillTable" /> 
    /// <para>
    ///     Null if it is unable to insert instance
    /// </para>
    /// </returns>
    Task<SkillTable?> CreateAsync(SkillTable table);
    /// <summary>
    ///     Gets all instances from repository
    /// </summary>
    /// <returns>
    ///     Array of <see cref="SkillTable" />
    /// </returns>
    Task<IEnumerable<SkillTable>> GetAsync();
    /// <summary>
    ///     Gets single instance
    /// </summary>
    /// <returns>
    ///      <see cref="SkillTable" />
    /// <para>
    ///     Null when no instance with <paramref name="id"/>
    /// </para>
    /// </returns>
    Task<SkillTable?> GetAsync(int id);
}