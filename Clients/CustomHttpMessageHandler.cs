using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Reqnroll.MSDI.Clients;


public class CustomHttpMessageHandler(IServiceProvider serviceProvider) : HttpClientHandler
{
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var scenarioContext = serviceProvider.GetRequiredService<ScenarioContext>();
        if (scenarioContext != null)
        {
            var tenantId = scenarioContext.Get<Guid>("tenantId").ToString();
            request.Headers.Add("tenantid", tenantId);
        }

        return base.SendAsync(request, cancellationToken);
    }

}