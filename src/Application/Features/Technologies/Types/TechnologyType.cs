using GraphQL.Types;
using MindworkingTest.Domain.Models;

namespace MindworkingTest.Application.Features.Technologies.Types;

public sealed class TechnologyType : ObjectGraphType<Technology>
{
    public TechnologyType()
    {
        Name = nameof(Technology);
        Description = "Skills to list on a curriculum vitae";
        Field(t => t.Id, nullable: false);
        Field(t => t.Name, nullable: false)
            .Description("Name of the technology");
    }
}