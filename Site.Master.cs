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

            FormsAuthentication.SignOut();
            Response.Redirect("Signin.aspx", true);
            //User user = new User();
            //user.Email= Request.QueryString["email"];

            //RestClient client = new RestClient(" https://www.mra.mw/sandbox/programming/challenge/webservice/auth/logout");
            //RestRequest request = new RestRequest(Method.POST);

            //Response.Headers.Add("Accept", "application/json");
            //Response.Headers.Add("Content-type", "application/json");
            //Response.Headers.Add("candidateid", "issahthabit@gmail.com");
            //Response.Headers.Add("apikey", "3fdb48c5-336b-47f9-87e4-ae73b8036a1c");
            //request.AddJsonBody(user);

            //IRestResponse<List<String>> response = client.Execute<List<String>>(request);

            //string result = response.Content;

            //var logD = JsonConvert.DeserializeObject<LoginDetails>(result);

            //if (logD.Authenticated==false)
            //{
            //    Response.Redirect("~/Signin.aspx");
            //}
        }
    }
}