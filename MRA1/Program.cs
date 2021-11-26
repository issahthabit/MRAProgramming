
using Newtonsoft.Json;
using System;
using RestSharp;
using System.Net;
using MRA.Models;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MRA1
{
    class Program
    {
        static void Main(string[] args)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://www.mra.mw");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            RestRequest Rrequest = new RestRequest("get", Method.GET) { Credentials = new NetworkCredential("issahthabit@gmail.com", "password000122") };
            Rrequest.AddHeader("candidateid", "issahthabit@gmail.com");
            Rrequest.AddHeader("apikey", "3fdb48c5-336b-47f9-87e4-ae73b8036a1c");

            HttpResponseMessage response = client.GetAsync("/programming/challenge/webservice/Taxpayers/getAll").Result;

            Console.WriteLine(response.Content.ReadAsStringAsync().Result);

        }
    }
}
