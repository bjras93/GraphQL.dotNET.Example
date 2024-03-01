using GraphQL.Types;
using MindworkingTest.API.Features.Technologies;
using MindworkingTest.API.Queries;

namespace MindworkingTest.API.Schemas;

public sealed class TechnologySchema : Schema
{
    public TechnologySchema(
        IServiceProvider provider,
        TechnologyQuery query,
        TechnologyMutation mutation) : base(provider)
    {
        Query = query;
        Mutation = mutation;
    }
}