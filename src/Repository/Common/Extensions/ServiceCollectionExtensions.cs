using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository.Common.Options;
using Repository.Contexts;
using Repository.Repositories;
using Repository.Repositories.Implementations;

namespace Repository.Common.Extensions;

public static class ServiceCollectionExtensions
{
    private static bool RepositoryConfigIsSetUp = false;
    /// <summary>
    /// Adds available repositories from the project 
    /// </summary>
    /// <returns>
    /// The <see cref="IServiceCollection"/> so that additional calls can be chained. 
    /// </returns>
    public static IServiceCollection AddRepositories(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services
        .RegisterRepository<ITechnologyRepository, TechnologyRepository>(configuration)
        .RegisterRepository<IProjectRepository, ProjectRepository>(configuration)
        .RegisterRepository<IProjectTechnologyRepository, ProjectTechnologyRepository>(configuration)
        .RegisterRepository<ICompanyRepository, CompanyRepository>(configuration)
        .RegisterRepository<ISkillRepository, SkillRepository>(configuration)
        .RegisterRepository<IEducationRepository, EducationRepository>(configuration);

        return services;
    }
    /// <summary>
    /// Registers the <see cref="DbContext"/>
    /// <para>
    ///     Registers transient instance of <typeparamref name="TImplementation"/> 
    /// </para>
    /// </summary>
    /// <returns>
    /// The <see cref="IServiceCollection"/> so that additional calls can be chained. 
    /// </returns>
    private static IServiceCollection RegisterRepository<TInterface, TImplementation>(
    this IServiceCollection services,
    IConfiguration configuration)
    where TInterface : class
    where TImplementation : class, TInterface
    {
        if (!RepositoryConfigIsSetUp)
        {
            services.AddRepositoryOptions(configuration);
            services.AddDbContext<TestContext>();
            RepositoryConfigIsSetUp = true;
        }
        services.AddTransient<TInterface, TImplementation>();
        return services;
    }
    /// <summary>
    /// Adds the repository options from the appsettings
    /// </summary>
    /// <returns>
    /// The <see cref="IServiceCollection"/> so that additional calls can be chained. 
    /// </returns>
    private static IServiceCollection AddRepositoryOptions(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.Configure<DatabaseOptions>(options =>
            configuration.GetSection(DatabaseOptions.Name).Bind(options));

        return services;
    }
}