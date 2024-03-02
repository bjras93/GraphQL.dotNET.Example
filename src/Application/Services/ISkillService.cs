using MindworkingTest.Domain.Enums;
using MindworkingTest.Domain.Models;

namespace MindworkingTest.Application.Services;

public interface ISkillService
{
    Task<Skill?> CreateAsync(Skill skill);
    Task<IEnumerable<Skill>> GetAsync(IEnumerable<SkillTypes> skillTypes);
}