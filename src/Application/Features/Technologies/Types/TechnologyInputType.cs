using GraphQL.Types;
using MindworkingTest.Domain.Models;

namespace MindworkingTest.Application.Features.Technologies.Types;

public class TechnologyInputType : InputObjectGraphType<Technology>
{
    public TechnologyInputType()
    {
        Name = "TechnologyInput";
        Field<NonNullGraphType<StringGraphType>>("Name");
    }
}