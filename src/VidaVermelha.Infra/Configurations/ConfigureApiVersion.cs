using Microsoft.Extensions.DependencyInjection;

namespace VidaVermelha.Infrastructure.Configurations;

public static class ConfigureApiVersion
{
    public static IServiceCollection AddApiVersion(
        this IServiceCollection services
    )
    {
        services.AddApiVersioning(
            options =>
            {
                options.ReportApiVersions = true;
            }
        ).AddApiExplorer(
            options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            }
        );

        return services;
    }
}
