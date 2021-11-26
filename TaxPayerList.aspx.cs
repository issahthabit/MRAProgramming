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
using System.Net;

namespace MRA
{
    public partial class TaxPayerList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        

        protected void btnViewTaxPayers_Click(object sender, EventArgs e)
        {
            string users = UserAuth.user, pwd=UserAuth.pass;
            IRestClient Rclient = new RestClient(); // "https://www.mra.mw/sandbox/programming/challenge/webservice/Taxpayers/add");
            Uri baseUrl = new Uri("https://www.mra.mw");

            RestRequest Rrequest = new RestRequest("get", Method.GET) { Credentials = new NetworkCredential(users, pwd) };

            Rclient.BaseUrl = baseUrl;
            Rrequest.Resource = "/programming/challenge/webservice/Taxpayers/getAll";


            Rrequest.Parameters.Clear();

            Rrequest.AddHeader("Content-Type", "application/json; charset=utf-8");
            Rrequest.AddHeader("candidateid", "issahthabit@gmail.com");
            Rrequest.AddHeader("apikey", "3fdb48c5-336b-47f9-87e4-ae73b8036a1c");

            IRestResponse<TaxPayer> Rresponse = Rclient.Execute<TaxPayer>(Rrequest);

            string result = Rresponse.Content;

            DataTable dt = (DataTable)JsonConvert.DeserializeObject(result, (typeof(DataTable)));
            Gridview1.DataSource = dt;
            Gridview1.DataBind();

            MsgLabel.Text = result;

            //string Result = Rresponse.Content;
            //var data = JsonConvert.DeserializeObject<TaxPayer>(Result);

            //User user = new User();
            //string users = UserAuth.user, pwd = UserAuth.pass;

            //user.Email = users;
            //user.Password = pwd;

            //RestClient client = new RestClient(" https://www.mra.mw/sandbox/programming/challenge/webservice/auth/login");
            //RestRequest request = new RestRequest(Method.POST);

            //Response.Headers.Add("Accept", "application/json");
            //Response.Headers.Add("Content-type", "application/json");
            //Response.Headers.Add("candidateid", "issahthabit@gmail.com");
            //Response.Headers.Add("apikey", "3fdb48c5-336b-47f9-87e4-ae73b8036a1c");
            ////Response.Headers.Add("Authorization", logD.Token.Value);
            //request.AddJsonBody(user);

            //IRestResponse<List<String>> response = client.Execute<List<String>>(request);

            //string result = response.Content;

            //var logD = JsonConvert.DeserializeObject<LoginDetails>(result);

            //if (logD.Authenticated)
            //{
            //    //Display_Tax_Payer_List();
            //    RestClient Client = new RestClient("https://www.mra.mw/sandbox/programming/challenge/webservice/Taxpayers/getAll?access_token="+logD.Token.Value+"");
            //    RestRequest Request = new RestRequest(Method.GET);


            //    Response.Headers.Add("Accept", "application/json");
            //    Response.Headers.Add("Content-type", "application/json");
            //    Response.Headers.Add("candidateid", "issahthabit@gmail.com");
            //    Response.Headers.Add("apikey", "3fdb48c5-336b-47f9-87e4-ae73b8036a1c");
            //    //Response.Headers.Add("Authorization",  logD.Token.Value);

            //    try
            //    {
            //        IRestResponse<List<String>> Response = Client.Execute<List<String>>(Request);

            //        string card = Response.Content;

            //        //DataTable dt = (DataTable)JsonConvert.DeserializeObject(card, (typeof(DataTable)));
            //        //Gridview1.DataSource = dt;
            //        //Gridview1.DataBind();
            //    }
            //    catch (Exception ex)
            //    {
            //        MsgLabel.Text = "Error!!! ";
            //    }
            //    string data = logD.UserDetails.FirstName;
            //    DataTable dt = (DataTable)JsonConvert.DeserializeObject(data, (typeof(DataTable)));
            //    Gridview1.DataSource = dt;
            //    Gridview1.DataBind();
            //}
        }
    }
}