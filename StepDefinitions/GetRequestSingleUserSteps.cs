using NUnit.Framework;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace TflAutomationApiTest.StepDefinitions
{
    [Binding]
    public class GetRequestSingleUserSteps
    {

        RestClient client;
        RestRequest request;
        IRestResponse response;

        [Given(@"I send a GET request to https://reqres\.in/api/users/(.*)")]
        public void GivenISendAGETRequestToHttpsReqres_InApiUsers(int p0)
        {
            client = new RestClient("https://reqres.in/api/users/2");
            client.Timeout = -1;
        }
        
        [Given(@"I send a GET request to enquire a single user details")]
        public void GivenISendAGETRequestToEnquireASingleUserDetails()
        {
            client = new RestClient("https://reqres.in/api/users/2");
            client.Timeout = -1;
        }
        
        [When(@"the reply is received")]
        public void WhenTheReplyIsReceived()
        {
            request = new RestRequest(Method.GET);
            request.AddHeader("company", "StatusCode Weekly");
            request.AddHeader("url", "http://statuscode.org");
            request.AddHeader("text", "A weekly newsletter focusing on software development, infrastructure, the server, performance, and the stack end of things");
            request.AddHeader("Cookie", "__cfduid=df2a862df89f4cc10de007bd305e3f9591606576685");
            response = client.Execute(request);


            

        }

        [Then(@"I should get a status code OK")]
        public void ThenIShouldGetAStatusCodeOK()
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
