using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Repository.Repositories;

public interface ICompanyRepository
{
    /// <summary>
    ///     Attempts to insert <see cref="CompanyTable"/> instance into repository
    /// </summary>
    /// <param name="table">Instance to create</param>
    /// <returns>
    /// The created <see cref="CompanyTable" /> 
    /// <para>
    ///     Null if it is unable to insert instance
    /// </para>
    /// </returns>
    Task<CompanyTable?> CreateAsync(CompanyTable table);
    /// <summary>
    ///     Gets all instances from repository
    /// </summary>
    /// <returns>
    ///     List of <see cref="CompanyTable" />
    /// </returns>
    Task<IEnumerable<CompanyTable>> GetAsync();
    /// <summary>
    ///     Gets single instance
    /// </summary>
    /// <returns>
    ///      <see cref="CompanyTable" />
    /// <para>
    ///     Null when no instance with <paramref name="id"/>
    /// </para>
    /// </returns>
    Task<CompanyTable?> GetAsync(int id);
}