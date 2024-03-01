using GraphQL;
using GraphQL.Types;
using MindworkingTest.Application.Features.Technologies;
using MindworkingTest.Application.Services;

namespace MindworkingTest.API.Queries;

public sealed class TechnologyQuery : ObjectGraphType
{
    private const string InputName = "id";
    public TechnologyQuery(ITechnologyService service)
    {
        Field<TechnologyType>("technology")
        .Argument<int>(InputName)
        .ResolveAsync(async context =>
        {
            var id = context.GetArgument<int>(InputName);
            var technology = await service.GetAsync(id);
            return technology;
        });

    }
}