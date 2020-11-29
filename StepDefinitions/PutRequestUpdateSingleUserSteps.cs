using NUnit.Framework;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace TflAutomationApiTest.StepDefinitions
{
    [Binding]
    public class PutRequestUpdateSingleUserSteps
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;

        [Given(@"I send a put request to https://reqres\.in/api/users/(.*)")]
        public void GivenISendAPutRequestToHttpsReqres_InApiUsers(int p0)
        {
            client = new RestClient("https://reqres.in/api/users/2");
            client.Timeout = -1;
        }
        
        [When(@"I send a put request to verify single user post is updated")]
        public void WhenISendAPutRequestToVerifySingleUserPostIsUpdated()
        {
            request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Cookie", "__cfduid=df2a862df89f4cc10de007bd305e3f9591606576685");
            request.AddParameter("application/json", "{\r\n    \"name\": \"morpheus\",\r\n    \"job\": \"zion resident\"\r\n}", ParameterType.RequestBody);
            response = client.Execute(request);
        }
        
        [Then(@"I should recieve a response sent to me")]
        public void ThenIShouldRecieveAResponseSentToMe()
        {
            Assert.That(response.Content.Length > 0);
            Assert.That(response.StatusCode.ToString() == "OK");
            Assert.That(response.IsSuccessful.ToString() == "True");
            Assert.That(response.ContentLength.ToString() == "-1");
            Assert.That(response.Request.ToString() == "RestSharp.RestRequest");
            Assert.That(response.ResponseStatus.ToString() == "Completed");
        }
    }
}
