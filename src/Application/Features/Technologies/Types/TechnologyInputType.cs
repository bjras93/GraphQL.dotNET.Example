using GraphQL.Types;
using Domain.Models;

namespace Application.Features.Technologies.Types;

public class TechnologyInputType : InputObjectGraphType<Technology>
{
    public TechnologyInputType()
    {
        Name = "TechnologyInput";
        Field<NonNullGraphType<StringGraphType>>("Name");
    }
}