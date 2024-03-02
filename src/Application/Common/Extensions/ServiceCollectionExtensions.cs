using GraphQL;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MindworkingTest.Application.GraphQL;
using MindworkingTest.Application.Services;
using MindworkingTest.Application.Services.Implementations;
using MindworkingTest.Repository.Extensions;

namespace MindworkingTest.Application.Common.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddExternalServices(
        this IServiceCollection services)
    {
        services
            .AddGraphQL(builder =>

                builder.ConfigureExecutionOptions(action =>
                {
#if DEBUG
                    action.EnableMetrics = true;
                    action.ThrowOnUnhandledException = true;
#endif
                })
                .AddGraphTypes()
                .AddSystemTextJson()
                .AddSchema<RootSchema>()
            );

        return services;
    }
    public static IServiceCollection AddServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services
            .AddRepositories(configuration)
            .AddTransient<ITechnologyService, TechnologyService>()
            .AddTransient<ICompanyService, CompanyService>()
            .AddTransient<IProjectService, ProjectService>()
            .AddTransient<ISkillService, SkillService>()
            .AddTransient<IEducationService, EducationService>();

        return services;
    }
}