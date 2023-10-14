using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Member.Helpers.HealthCheck;
using Member.Helpers.NSwag;
using Member.Middleware;
using NSwag;
using NSwag.Generation.AspNetCore;
using NSwag.Generation.Processors.Security;

namespace Member;

public static class ConfigureService
{
    public static IServiceCollection AddComponentService(this IServiceCollection services,
    IConfiguration configuration, string environmentName)
    {
        services.AddHttpContextAccessor();

        services.AddHealthChecks()
            .AddCheck<AliveHealthCheck>("alive", tags: new[] { "alive" });


        services.AddCors(options =>
        {
            options.AddPolicy("CORS", policy =>
            {
                policy.AllowAnyOrigin();
                policy.AllowAnyMethod();
                policy.AllowAnyHeader();
            });
        });

        services.AddOpenApiDocument(config =>
        {
            config.Title = "Member API";
            config.Version = "v1";
            config.Description = $"Member API {environmentName}";
            config.OperationProcessors.Add(new AddRequiredHeaderParameter());
        });

        //Middleware
        services.AddTransient<RequestHeaderMiddleware>();

        return services;
    }
}
