
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
            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // List all Names.
            HttpResponseMessage response = client.GetAsync("programming/challenge/webservice/Taxpayers/getAll").Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                var products = response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            //var url = "https://www.mra.mw/programming/challenge/webservice/Taxpayers/getAll";

            //var request = WebRequest.Create(url);
            ////request.Method = "GET";

            //RestRequest Rrequest = new RestRequest("get", Method.GET) { Credentials = new NetworkCredential("issahthabit@gmail.com", "password000122") };

            //Rrequest.AddHeader("Content-Type", "application/json; charset=utf-8");
            //Rrequest.AddHeader("candidateid", "issahthabit@gmail.com");
            //Rrequest.AddHeader("apikey", "3fdb48c5-336b-47f9-87e4-ae73b8036a1c");


            //using var webResponse = request.GetResponse();
            //using var webStream = webResponse.GetResponseStream();

            //using var reader = new StreamReader(webStream);
            //var data = reader.ReadToEnd();

            //Console.WriteLine(data);

            //Console.ReadLine();

            //IRestClient Rclient = new RestClient(); // "https://www.mra.mw/sandbox/programming/challenge/webservice/Taxpayers/add");
            //Uri baseUrl = new Uri("https://www.mra.mw");

            ////Rrequest = new RestRequest(Method.POST);
            //RestRequest Rrequest = new RestRequest("post", Method.POST) { Credentials = new NetworkCredential("issahthabit@gmail.com", "password000122") };


            //Rclient.BaseUrl = baseUrl;
            //Rrequest.Resource = "/sandbox/programming/challenge/webservice/Taxpayers/add";


            //Rrequest.Parameters.Clear();

            //Rrequest.AddHeader("Content-Type", @"application/json; charset=utf-8");
            //Rrequest.AddHeader("candidateid", @"issahthabit@gmail.com");
            //Rrequest.AddHeader("apikey", @"3fdb48c5-336b-47f9-87e4-ae73b8036a1c");

            //Rrequest.AddJsonBody(new
            //{
            //    TPIN = "20203038",
            //    BusinessCertificateNumber = "MBRS123440",
            //    TradingName = "issah thabit",
            //    BusinessRegistrationDate = "2021-11-25",
            //    MobileNumber = "08894598889",
            //    Email = "issahthabit@gmail.com",
            //    PhysicalLocation = "Biwi",
            //    Username = "issahthabit@gmail.com"
            //}

            //); //, "application/json");


        }
    }
}
