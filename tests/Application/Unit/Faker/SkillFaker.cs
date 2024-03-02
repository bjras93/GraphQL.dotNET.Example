using Bogus;
using MindworkingTest.Domain.Enums;
using MindworkingTest.Domain.Models;

namespace MindworkingTest.Application.Unit.Faker;

public sealed class SkillFaker : Faker<Skill>
{
    public SkillFaker(
        int referenceId,
        SkillTypes skillType)
    {
        RuleFor(t => t.ExperienceYears, f => f.Random.Decimal());
        RuleFor(t => t.ReferenceId, referenceId);
        RuleFor(t => t.ProficiencyLevel, f => f.PickRandom<ProficiencyLevels>());
        RuleFor(t => t.ReferenceType, skillType);
    }
}