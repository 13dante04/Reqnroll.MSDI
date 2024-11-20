using System;
using Microsoft.Extensions.DependencyInjection;
using Reqnroll.Infrastructure;
using Reqnroll.Microsoft.Extensions.DependencyInjection;
using Reqnroll.MSDI.Clients;

namespace Reqnroll.MSDI;

public class DependencyInjection
{
    [ScenarioDependencies]
    public static IServiceCollection CreateContainer()
    {
        var services = new ServiceCollection();
        services.AddSingleton<ReqnrollOutputHelper>();
        services.AddTransient<CustomHttpMessageHandler>();
        services.AddHttpClient<SomeHttpClient>().ConfigurePrimaryHttpMessageHandler(sp => new CustomHttpMessageHandler(sp));           
        return services;
    }
}