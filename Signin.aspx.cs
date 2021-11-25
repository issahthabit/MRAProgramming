using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MRA.Models;

namespace MRA
{
    public partial class Signin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            User_Authentification();
            //
        }
        public void User_Authentification()
        {
            User user = new User();
            user.Password = txtpassword.Value;
            user.Email = txtemail.Value;

            UserAuth.user = user.Email;
            UserAuth.pass = user.Password;

            RestClient client = new RestClient(" https://www.mra.mw/sandbox/programming/challenge/webservice/auth/login");
            RestRequest request = new RestRequest(Method.POST);

            Response.Headers.Add("Accept", "application/json");
            Response.Headers.Add("Content-type", "application/json");
            Response.Headers.Add("candidateid", "issahthabit@gmail.com");
            Response.Headers.Add("apikey", "3fdb48c5-336b-47f9-87e4-ae73b8036a1c");
            request.AddJsonBody(user);

            IRestResponse<List<String>> response = client.Execute<List<String>>(request);

            string result = response.Content;

            var logD = JsonConvert.DeserializeObject<LoginDetails>(result);
            

            if (logD.Authenticated)
            {
                Response.Redirect("~/AddTaxPayer.aspx");
            }
            else
            {
                msgLabel.ForeColor = System.Drawing.Color.Red;
                msgLabel.Text = "Invalid Login credentials";
            }

            //Session["email"] = txtemail.Value;
            //Session["password"] = txtpassword.Value;
        }
    }
}