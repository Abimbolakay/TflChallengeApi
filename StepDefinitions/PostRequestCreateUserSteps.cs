using NUnit.Framework;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace TflAutomationApiTest.StepDefinitions
{
    [Binding]
    public class PostRequestCreateUserSteps
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;

        [Given(@"I send post request to https://reqres\.in/api/users")]
        public void GivenISendPostRequestToHttpsReqres_InApiUsers()
        {
            client = new RestClient("https://reqres.in/api/users");
            client.Timeout = -1;
        }
        
        [When(@"I send a post request to verify single user is created")]
        public void WhenISendAPostRequestToVerifySingleUserIsCreated()
        {
            request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Cookie", "__cfduid=df2a862df89f4cc10de007bd305e3f9591606576685");
            request.AddParameter("application/json", "{\r\n    \"name\": \"morpheus\",\r\n    \"job\": \"leader\"\r\n}", ParameterType.RequestBody);
            response = client.Execute(request);
        }
        
        [Then(@"I should have response")]
        public void ThenIShouldHaveResponse()
        {
            Assert.That(response.Content.Length > 0);
            Assert.That(response.IsSuccessful.ToString() == "True");
            Assert.That(response.ResponseUri.ToString() == "https://reqres.in/api/users");
            Assert.That(response.ResponseStatus.ToString() == "Completed");
            Assert.That(response.ContentLength.ToString() == "84");
            Assert.That(response.Server.ToString() == "cloudflare");
            Assert.That(response.StatusCode.ToString() == "Created");
        }
    }
}
