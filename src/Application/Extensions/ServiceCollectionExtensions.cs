using GraphQL;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MindworkingTest.API.Schemas;
using MindworkingTest.Application.Services;
using MindworkingTest.Application.Services.Implementations;
using MindworkingTest.Repository.Extensions;

namespace MindworkingTest.API.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddExternalServices(
        this IServiceCollection services)
    {
        services
            .AddGraphQL(builder =>
                builder.AddSchema<TechnologySchema>());

        return services;
    }
    public static IServiceCollection AddServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services
            .AddRepositories(configuration)
            .AddTransient<ITechnologyService, TechnologyService>()
            .AddGraphQL(builder =>
                builder
                .AddGraphTypes()
                .AddSystemTextJson()
                .AddSchema<TechnologySchema>());

        return services;
    }
}