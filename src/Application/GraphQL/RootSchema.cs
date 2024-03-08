using GraphQL.Types;

namespace Application.GraphQL;

public sealed class RootSchema : Schema
{
    public RootSchema(
        IServiceProvider provider,
        Query query,
        Mutation mutation) : base(provider)
    {
        Query = query;
        Mutation = mutation;
    }
}