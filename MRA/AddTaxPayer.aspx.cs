﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.UI;
using System.Web.UI.WebControls;
using MRA.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace MRA
{
    public partial class AddTaxPayer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        [Authorize]
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //User user = new User();
            string users = UserAuth.user, pwd=UserAuth.pass;

            if (Page.IsValid)
            {
                TaxPayer taxPayer = new TaxPayer();
                taxPayer.TPIN = tpin.Value.ToString();
                taxPayer.BusinessCertificateNumber = BusinessCertificateNumber.Value.ToString();
                taxPayer.TradingName = TradingName.Value.ToString();
                taxPayer.BusinessRegistrationDate = BusinessRegistrationDate.Value.ToString();
                taxPayer.MobileNumber = MobileNumber.Value.ToString();
                taxPayer.Email = Email.Value.ToString();
                taxPayer.PhysicalLocation = phyiscallocation.Value.ToString();
                taxPayer.Username = username.Value;
                
                IRestClient Rclient = new RestClient();
                Uri baseUrl = new Uri("https://www.mra.mw");
                RestRequest Rrequest = new RestRequest("post", Method.POST) { Credentials = new NetworkCredential(users, pwd) };
                Rclient.BaseUrl = baseUrl;
                Rrequest.Resource = "/sandbox/programming/challenge/webservice/Taxpayers/add";
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
                        //var data = JsonConvert.DeserializeObject<TaxPayer>(Result);
                        MSGLabel.ForeColor = System.Drawing.Color.Green;
                        MSGLabel.Text = "Record has been saved successfully";
                        MSGLabel.ForeColor = System.Drawing.Color.Black;
                        tpin.Value = string.Empty;
                        BusinessCertificateNumber.Value = string.Empty;
                        TradingName.Value = string.Empty;
                        BusinessRegistrationDate.Value = string.Empty;
                        MobileNumber.Value = string.Empty;
                        Email.Value = string.Empty;
                        phyiscallocation.Value = string.Empty;
                        username.Value = string.Empty;
                    }
                    else if(Rresponse.StatusCode == HttpStatusCode.Ambiguous)
                    {
                        MSGLabel.ForeColor = System.Drawing.Color.Red;
                        MSGLabel.Text = "User Already Exists".ToUpper();
                        MSGLabel.ForeColor = System.Drawing.Color.Black;
                    }
                    else if(Rresponse.StatusCode==HttpStatusCode.BadRequest)
                    {
                        MSGLabel.ForeColor = System.Drawing.Color.Red;
                        MSGLabel.Text = "Username doest not exists ".ToUpper();
                        MSGLabel.ForeColor = System.Drawing.Color.Black;
                    }
                    else if(Rresponse.StatusCode==HttpStatusCode.InternalServerError)
                    {
                        MSGLabel.Text = "Internal Server Error!!!";
                    }
                    
                }
                catch (Exception ex)
                {
                    MSGLabel.Text = "Failed to create Record " + ex;
                }
            }
        }
    }
}