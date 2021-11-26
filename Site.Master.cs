using MRA.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MRA
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            usernametxt.Text = UserAuth.user;
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {

            string users = UserAuth.user, pwd = UserAuth.pass;

            TaxPayer taxPayer = new TaxPayer();
            taxPayer.Email = "issahthabit@gmail.com";

            IRestClient Rclient = new RestClient();
            Uri baseUrl = new Uri("https://www.mra.mw");
            RestRequest Rrequest = new RestRequest("post", Method.POST) { Credentials = new NetworkCredential(users, pwd) };
            Rclient.BaseUrl = baseUrl;
            Rrequest.Resource = "/sandbox/programming/challenge/webservice/auth/logout";
            Rrequest.Parameters.Clear();
            Rrequest.AddHeader("Content-Type", "application/json; charset=utf-8");
            Rrequest.AddHeader("candidateid", "issahthabit@gmail.com");
            Rrequest.AddHeader("apikey", "3fdb48c5-336b-47f9-87e4-ae73b8036a1c");
            Rrequest.AddJsonBody(taxPayer);

            IRestResponse<TaxPayer> Rresponse = Rclient.Execute<TaxPayer>(Rrequest);

            if (Rresponse.StatusCode == HttpStatusCode.OK)
            {
                Response.Redirect("~/Signin.aspx");
            }
        }
    }
}