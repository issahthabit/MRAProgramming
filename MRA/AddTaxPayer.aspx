<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddTaxPayer.aspx.cs" Inherits="MRA.AddTaxPayer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <!-- Page Header -->
        <div class="col-lg-12">
            <h1 class="page-header">Add New Tax Payer</h1>
        </div>
        <!--End Page Header -->
    </div>
    <div class="col-lg-12">
        <div class="panel panel-default">
            <div class="panel-heading">
                Tax Payer Creation form
            </div>
            <div class="panel-body">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="form-group">
                            <label>TPIN</label> 
                            <input class="form-control" id="tpin" runat="server">
                            <asp:RequiredFieldValidator ControlToValidate="tpin" runat="server" ErrorMessage="TPIN cannot be empty" ForeColor="Red" />
                        </div>
                        <div class="form-group">
                            <label>Business CertificateNumber:</label>
                            <input class="form-control" id="BusinessCertificateNumber" runat="server">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorBCN" ControlToValidate="BusinessCertificateNumber" ForeColor="Red" runat="server" 
                                ErrorMessage="Business Certificate Number can not be empty" />
                        </div>
                        <div class="form-group">
                            <label>Trading Name:</label>
                            <input class="form-control" id="TradingName" runat="server">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorTN" ControlToValidate="TradingName" ForeColor="Red" runat="server" 
                                ErrorMessage="Business Certificate Number can not be empty" />
                        </div>
                        <div class="form-group">
                            <label>Business Registration Date:</label>
                            <input class="form-control" id="BusinessRegistrationDate" type="date" runat="server" >
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorBRD" ControlToValidate="BusinessRegistrationDate" ForeColor="Red" runat="server" 
                                ErrorMessage="Business Registration Date can not be empty" />
                        </div>
                        <div class="form-group">
                            <label>Mobile Number:</label>
                            <input class="form-control" id="MobileNumber" type="number" runat="server">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatormobile" ControlToValidate="MobileNumber" ForeColor="Red" runat="server" 
                                ErrorMessage="Mobile Number can not be empty" />

                        </div>
                        <div class="form-group">
                            <label>Email:</label>
                            <input class="form-control" id="Email" runat="server">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatoremail" ControlToValidate="Email" ForeColor="Red" runat="server" 
                                ErrorMessage="Email can not be empty" />
                        </div>
                        <div class="form-group">
                            <label>Pysical Location</label>
                            <input class="form-control" id="phyiscallocation" runat="server">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorpl" ControlToValidate="phyiscallocation" ForeColor="Red" runat="server" 
                                ErrorMessage="Pysical Location can not be empty" />
                        </div>
                        <div class="form-group">
                            <label>Username</label>
                            <input class="form-control" id="username" runat="server">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorUsername" ControlToValidate="username" ForeColor="Red" runat="server" 
                                ErrorMessage="Username can not be empty" />
                        </div>
                        <div class="form-group">
                            <asp:Button Text="Submit" CssClass="btn btn-success" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click"  />
                        </div>
                        <center>
                            <strong><asp:Label ID="MSGLabel" Text="" runat="server" /></strong>
                        </center>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
