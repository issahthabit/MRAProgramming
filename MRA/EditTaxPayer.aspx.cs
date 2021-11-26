using MRA.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MRA
{
    public partial class EditTaxPayer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       

        protected void btupdate_Click(object sender, EventArgs e)
        {
            TaxPayer taxPayer = new TaxPayer();
            taxPayer.TPIN = tpin.Value.ToString();
            taxPayer.BusinessCertificateNumber = BusinessCertificateNumber.Value.ToString();
            taxPayer.TradingName = TradingName.Value.ToString();
            taxPayer.BusinessRegistrationDate = BusinessRegistrationDate.Value.ToString();
            taxPayer.MobileNumber = MobileNumber.Value.ToString();
            taxPayer.Email = Email.Value.ToString();
            taxPayer.PhysicalLocation = phyiscallocation.Value.ToString();
            taxPayer.Username = "issahthabit@gmail.com".ToString(); // username.Value;

            IRestClient Rclient = new RestClient(); // "https://www.mra.mw/sandbox/programming/challenge/webservice/Taxpayers/add");
            Uri baseUrl = new Uri("https://www.mra.mw");

            RestRequest Rrequest = new RestRequest("post", Method.POST) { Credentials = new NetworkCredential("issahthabit@gmail.com", "password000122") };


            Rclient.BaseUrl = baseUrl;
            Rrequest.Resource = "/sandbox/programming/challenge/webservice/Taxpayers/edit";


            Rrequest.Parameters.Clear();

            Rrequest.AddHeader("Content-Type", "application/json; charset=utf-8");
            Rrequest.AddHeader("candidateid", "issahthabit@gmail.com");
            Rrequest.AddHeader("apikey", "3fdb48c5-336b-47f9-87e4-ae73b8036a1c");

            Rrequest.AddJsonBody(taxPayer);

            try
            {
                IRestResponse<TaxPayer> Rresponse = Rclient.Execute<TaxPayer>(Rrequest);

                if (Rresponse.StatusCode == HttpStatusCode.OK)
                {
                    string Result = Rresponse.Content;

                    var data = JsonConvert.DeserializeObject<TaxPayer>(Result);

                    MSGLabel.Text = "Record has been updated successfully";

                    tpin.Value = string.Empty;
                    BusinessCertificateNumber.Value = string.Empty;
                    TradingName.Value = string.Empty;
                    BusinessRegistrationDate.Value = string.Empty;
                    MobileNumber.Value = string.Empty;
                    Email.Value = string.Empty;
                    phyiscallocation.Value = string.Empty;
                    username.Value = string.Empty;
                }
                else
                {
                    MSGLabel.Text = "Failed to update Record";
                }
            }
                catch (Exception ex)
                {
                    MSGLabel.Text = "Failed to update Record " + ex;
                }
        }
    }
}