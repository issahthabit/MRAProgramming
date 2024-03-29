﻿using MRA.Models;
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
    public partial class DeleteTaxPayer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void DeleteDetails()
        {
            string users = UserAuth.user, pwd=UserAuth.pass;
            if (Page.IsValid)
            {
                DeleteTaxPayers Dpayer = new DeleteTaxPayers();
                Dpayer.TPIN = tpin.Value;

                IRestClient Rclient = new RestClient();
                Uri baseUrl = new Uri("https://www.mra.mw");

                RestRequest Rrequest = new RestRequest("post", Method.POST) { Credentials = new NetworkCredential(users, pwd) };


                Rclient.BaseUrl = baseUrl;
                Rrequest.Resource = "/sandbox/programming/challenge/webservice/Taxpayers/delete";


                Rrequest.Parameters.Clear();

                Rrequest.AddHeader("Content-Type", "application/json; charset=utf-8");
                Rrequest.AddHeader("candidateid", "issahthabit@gmail.com");
                Rrequest.AddHeader("apikey", "3fdb48c5-336b-47f9-87e4-ae73b8036a1c");

                Rrequest.AddJsonBody(Dpayer);


                try
                {

                    IRestResponse<TaxPayer> Rresponse = Rclient.Execute<TaxPayer>(Rrequest);

                    if (Rresponse.StatusCode == HttpStatusCode.OK)
                    {
                        string Result = Rresponse.Content;

                        var data = JsonConvert.DeserializeObject<TaxPayer>(Result);

                        MSGLabel.Text = "Record has been Deleted successfully";

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
                        MSGLabel.Text = "Failed to Delete Taxpayer";
                    }
                }
                catch (Exception ex)
                {
                    MSGLabel.Text = "Failed to Delete Record " + ex;
                }
            }
        }

        protected void btupdate_Click(object sender, EventArgs e)
        {
            DeleteDetails();
        }
    }
}