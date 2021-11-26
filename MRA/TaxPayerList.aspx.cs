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
            string users = UserAuth.user, pwd = UserAuth.pass;
            IRestClient Rclient = new RestClient();
            Uri baseUrl = new Uri("https://www.mra.mw");

            RestRequest Rrequest = new RestRequest("get", Method.GET) { Credentials = new NetworkCredential(users, pwd) };

            Rclient.BaseUrl = baseUrl;
            Rrequest.Resource = "/programming/challenge/webservice/Taxpayers/getAll";


            Rrequest.Parameters.Clear();

            Rrequest.AddHeader("Content-Type", "application/json; charset=utf-8");
            Rrequest.AddHeader("candidateid", "issahthabit@gmail.com");
            Rrequest.AddHeader("apikey", "3fdb48c5-336b-47f9-87e4-ae73b8036a1c");

            //IRestResponse<TaxPayer> Rresponse = Rclient.Execute<TaxPayer>(Rrequest);
            IRestResponse Rresult = Rclient.Execute<List<TaxPayer>>(Rrequest);

            string result= Rresult.Content;

            DataTable dt = (DataTable)JsonConvert.DeserializeObject(result, (typeof(DataTable)));
            Gridview1.DataSource = dt;
            Gridview1.DataBind();
            //MsgLabel.Text = result;
        }
    }
}