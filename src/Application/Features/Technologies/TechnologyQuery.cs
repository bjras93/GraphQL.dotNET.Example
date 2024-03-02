using GraphQL;
using GraphQL.Types;
using MindworkingTest.Application.Features.Technologies.Types;
using MindworkingTest.Application.Services;

namespace MindworkingTest.Application.Features.Technologies;

public sealed class TechnologyQuery : ObjectGraphType
{
    public TechnologyQuery(ITechnologyService service)
    {
        Field<TechnologyType>("technology")
        .Argument<int>("id")
        .ResolveAsync(async context =>
        {
            var id = context.GetArgument<int>("id");
            var technology = await service.GetAsync(id);
            return technology;
        });
        Field<ListGraphType<TechnologyType>>("technologies")
        .ResolveAsync(async context =>
        {
            var technology = await service.GetAsync();
            return technology;
        });

        Field<ListGraphType<TechnologyType>>("technologiesByName")
        .Argument<string>("name")
        .ResolveAsync(async context =>
        {
            var name = context.GetArgument<string>("name");
            var technology = await service.GetByNameAsync(name);
            return technology;
        });

    }
}