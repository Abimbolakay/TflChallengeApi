using NUnit.Framework;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace TflAutomationApiTest.StepDefinitions
{
    [Binding]
    public class GetRequestSingleUserNotFoundSteps
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;

        [Given(@"I send a get request to https://reqres\.in/api/users/(.*)")]
        public void GivenISendAGetRequestToHttpsReqres_InApiUsers(int p0)
        {
            client = new RestClient("https://reqres.in/api/users/23");
            client.Timeout = -1;
        }
        
        [When(@"I send a get request to verify no single user found")]
        public void WhenISendAGetRequestToVerifyNoSingleUserFound()
        {
            request = new RestRequest(Method.GET);
            response = client.Execute(request);
        }
        
        [Then(@"I should recieve a response")]
        public void ThenIShouldRecieveAResponse()
        {


            Assert.That(response.Request.ToString() == "RestSharp.RestRequest");
            Assert.That(response.IsSuccessful.ToString() == "False");
            Assert.That(response.ResponseStatus.ToString() == "Completed");
            Assert.That(response.ContentLength.ToString() == "2");


        }
    }
}
