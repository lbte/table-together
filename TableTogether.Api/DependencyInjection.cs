using MediatR;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using TableTogether.Api.Common.Errors;
using TableTogether.Api.Common.Mapping;

namespace TableTogether.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddMappings();
        services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory, TableTogetherProblemDetailsFactory>();
        return services;
    }
}