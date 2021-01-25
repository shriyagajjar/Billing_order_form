using Billing_order_form.Model;
using FluentAssertions;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Billing_order_form

{
    class BillingOrdertest
    {
        public static string baseURL = "http://localhost:8080/BillingOrder";


        [Test]
        public void CreateTest()
        {
            //genrate data
            BillingOrder expectedData = new BillingOrder();
            //convert to jason
            string JsonString = JsonConvert.SerializeObject(expectedData);
            //post data
            IRestResponse response = Post(JsonString);
            BillingOrder actualData = JsonConvert.DeserializeObject<BillingOrder>(response.Content);
            actualData.id = 0;
            expectedData.Should().BeEquivalentTo(expectedData.firstName);
        }
        [Test]
        public void EmailValidation()
        {
            BillingOrder orderData = new BillingOrder();
            orderData.email = "rdtfgyhjk";

            string JsonString = JsonConvert.SerializeObject(orderData);
            IRestResponse response = Post(JsonString);
            Assert.IsTrue(response.Content.Contains("Email should be valid"));

        }

        [Test]
        public void ZipCodevalidation()
        {
            BillingOrder orderData = new BillingOrder();
            orderData.zipCode = "5623";

            string JsonString = JsonConvert.SerializeObject(orderData);
            IRestResponse response = Post(JsonString);
            Assert.IsTrue(response.Content.Contains("ZipCode should be valid"));

        }
        public IRestResponse Post(string Tempdata)
        {
            //Client
            var client = new RestClient(baseURL);

            //Method
            var request = new RestRequest(Method.POST);

            //Header
            request.AddHeader("Content-Type", "application/json");

            //Body
            request.AddParameter("application/json", Tempdata, ParameterType.RequestBody);

            //Execution
            return = client.Execute(request);
        }
        public IRestResponse Get()
        {
            //Client
            var client = new RestClient(baseURL);

            //Method
            var request = new RestRequest(Method.GET);

            //Header
            request.AddHeader("Content-Type", "application/json");

            //Execution
            return client.Execute(request);
        }/*
        public IRestResponse Getonerecord(string id)
        {
            //Client
            var client = new RestClient($"{baseURL}+{id}");

            //Method
            var request = new RestRequest(Method.GET);

            //Header
            request.AddHeader("Content-Type", "application/json");

            //Execution
            IRestResponse response = client.Execute(request);
        }*/

        public IRestResponse Delete(string id)
        {

            //Client
            var client = new RestClient($"{baseURL}/2");

            //Method
            var request = new RestRequest(Method.DELETE);

            //Header
            request.AddHeader("Content-Type", "application/json");

            //Execution
            return client.Execute(request);
        }

    }
}
