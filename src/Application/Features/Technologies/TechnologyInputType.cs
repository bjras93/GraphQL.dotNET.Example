using GraphQL.Types;

namespace MindworkingTest.Application.Features.Technologies;

public class TechnologyInputType : InputObjectGraphType
{
    public TechnologyInputType()
    {
        Name = "TechnologyInput";
        Field<NonNullGraphType<StringGraphType>>("name");
    }
}