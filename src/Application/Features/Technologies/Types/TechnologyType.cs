using GraphQL.Types;
using Domain.Models;

namespace Application.Features.Technologies.Types;

public sealed class TechnologyType : ObjectGraphType<Technology>
{
    public TechnologyType()
    {
        Name = nameof(Technology);
        Description = "Technologies to list on a curriculum vitae";
        Field(t => t.Id, nullable: false);
        Field(t => t.Name, nullable: false)
            .Description("Name of the technology");
    }
}