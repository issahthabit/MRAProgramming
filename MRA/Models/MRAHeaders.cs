using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using RestSharp;

namespace MRA.Models
{
    public class MRAHeaders : System.Web.UI.Page
    {
        public void GetHeaders()
        {
            
            Response.Headers.Add("Accept", "application/json");
            Response.Headers.Add("Content-type", "application/json");
            Response.Headers.Add("candidateid", "issahthabit@gmail.com");
            Response.Headers.Add("apikey", "3fdb48c5-336b-47f9-87e4-ae73b8036a1c");
        }
    }
}