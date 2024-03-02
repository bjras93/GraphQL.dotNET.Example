using MindworkingTest.Domain.Enums;
using MindworkingTest.Domain.Models;

namespace MindworkingTest.Application.Services;

public interface ISkillService
{
    /// <summary>
    /// Sends create request to repository
    /// </summary>
    /// <returns>
    /// Instance of created <see cref="Skill"/>
    /// <para>
    /// Null when it is unable to create
    /// </para>
    /// </returns>
    Task<Skill?> CreateAsync(Skill skill);
    /// <summary>
    /// Gets <see cref="Skill"/> as array from repository by <see cref="SkillTypes"/> 
    /// </summary>
    /// <returns>
    /// Array of instances in the repository
    /// </returns>
    Task<IEnumerable<Skill>> GetAsync(IEnumerable<SkillTypes> skillTypes);
}