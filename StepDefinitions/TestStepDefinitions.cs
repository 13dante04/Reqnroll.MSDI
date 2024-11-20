using System;
using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Reqnroll;
using Reqnroll.MSDI.Clients;

namespace Reqnroll.MSDI.StepDefinitions;

[Binding]
public sealed class TestStepDefinitions(ScenarioContext scenarioContext, SomeHttpClient someHttpClient)
{

    [Given("the tenant id is set")]
    public void GivenTheTenantIdIs()
    {
        scenarioContext.Set<Guid>(Guid.NewGuid(), "tenantId");
    }

    [When("an http request is made")]
    public async Task WhenAnHttpRequestIsMade()
    {
        var someResponse = await someHttpClient.PostAsync("someendpoint", new StringContent("somecontent"));
        someResponse.Should().NotBeNull();
    }

    [Then("the next step should execute")]
    public void ThenTheNextStepShouldExecute()
    {
        
    }
}
