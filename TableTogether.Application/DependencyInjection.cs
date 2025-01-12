using Microsoft.Extensions.DependencyInjection;
using TableTogether.Application.Services.Authentication;

namespace TableTogether.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}