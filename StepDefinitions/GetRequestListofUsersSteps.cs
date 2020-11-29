using NUnit.Framework;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace TflAutomationApiTest.StepDefinitions
{
    [Binding]
    public class GetRequestListofUsersSteps
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;

        [Given(@"I send a get request to https://reqres\.in/api/users\?page=(.*)")]
        public void GivenISendAGetRequestToHttpsReqres_InApiUsersPage(int p0)
        {
            client = new RestClient("https://reqres.in/api/users?page=2");
            client.Timeout = -1;

        }
        
        [Given(@"I send a get request to verify a list of users")]
        public void GivenISendAGetRequestToVerifyAListOfUsers()
        {
            client = new RestClient("https://reqres.in/api/users?page=2");
            client.Timeout = -1;
        }
        
        [When(@"the response is received")]
        public void WhenTheResponseIsReceived()
        {
            request = new RestRequest(Method.GET);
            request.AddHeader("Cookie", "__cfduid=df2a862df89f4cc10de007bd305e3f9591606576685");
            response = client.Execute(request);
            
        }
        
        [Then(@"I will receive an ""(.*)"" response")]
        public void ThenIWillReceiveAnResponse(string p0)
        {
            Assert.That(response.Content.Length > 0);
            Assert.That(response.StatusCode.ToString() == "OK");
            Assert.That(response.IsSuccessful.ToString() == "True");
            Assert.That(response.StatusDescription.ToString() == "OK");
            Assert.That(response.ResponseUri.ToString() == "https://reqres.in/api/users?page=2");
            Assert.That(response.ResponseStatus.ToString() == "Completed");
            Assert.That(response.ContentLength.ToString() == "-1");
            Assert.That(response.Server.ToString() == "cloudflare");
        }
    }
}
