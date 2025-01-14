using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TableTogether.Application.Common.Interfaces.Authentication;
using TableTogether.Application.Common.Interfaces.Services;
using TableTogether.Infrastructure.Authentication;
using TableTogether.Infrastructure.Services;

namespace TableTogether.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(nameof(JwtSettings)));
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        return services;
    }
}