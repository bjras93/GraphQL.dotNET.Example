using GraphQL;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Application.GraphQL;
using Application.Services;
using Application.Services.Implementations;
using Repository.Common.Extensions;

namespace Application.Common.Extensions;

public static class ServiceCollectionExtensions
{

    /// <summary>
    /// Adds services from external libraries
    /// </summary>
    /// <param name="services"></param>
    /// <returns>
    /// The <see cref="IServiceCollection"/> so that additional calls can be chained. 
    /// </returns>
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
    /// <summary>
    /// Adds internal services
    /// </summary>
    /// <param name="services"></param>
    /// <returns>
    /// The <see cref="IServiceCollection"/> so that additional calls can be chained. 
    /// </returns>
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