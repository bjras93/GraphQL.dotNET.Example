using GraphQL.Types;
using Domain.Enums;
using Domain.Models;

namespace Application.Features.Skills.Types;

public sealed class SkillInputType : InputObjectGraphType<Skill>
{
    public SkillInputType()
    {
        Field<NonNullGraphType<EnumerationGraphType<ProficiencyLevels>>>("ProficiencyLevel");
        Field<NonNullGraphType<DecimalGraphType>>("ExperienceYears");
        Field<NonNullGraphType<IntGraphType>>("ReferenceId");
        Field<NonNullGraphType<EnumerationGraphType<SkillTypes>>>("ReferenceType");
    }
}