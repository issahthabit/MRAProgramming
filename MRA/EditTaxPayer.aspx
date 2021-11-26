<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditTaxPayer.aspx.cs" Inherits="MRA.EditTaxPayer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <!-- Page Header -->
        <div class="col-lg-12">
            <h1 class="page-header">Edit Tax Payer</h1>
        </div>
        <!--End Page Header -->
    </div>
    <div class="col-lg-12">
        <div class="panel panel-default">
            <div class="panel-heading">
                Updating Tax payers details
            </div>
            <div class="panel-body">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="form-group">
                            <label>TPIN</label>
                            <input class="form-control" id="tpin" runat="server">
                        </div>
                        <div class="form-group">
                            <label>Business CertificateNumber:</label>
                            <input class="form-control" id="BusinessCertificateNumber" runat="server">
                        </div>
                        <div class="form-group">
                            <label>Trading Name:</label>
                            <input class="form-control" id="TradingName" runat="server">
                        </div>
                        <div class="form-group">
                            <label>Business Registration Date:</label>
                            <input class="form-control" id="BusinessRegistrationDate" type="date" runat="server" >
                        </div>
                        <div class="form-group">
                            <label>Mobile Number:</label>
                            <input class="form-control" id="MobileNumber" runat="server">
                        </div>
                        <div class="form-group">
                            <label>Email:</label>
                            <input class="form-control" id="Email" runat="server">
                        </div>
                        <div class="form-group">
                            <label>Pysical Location</label>
                            <input class="form-control" id="phyiscallocation" runat="server">
                        </div>
                        <div class="form-group">
                            <label>Username</label>
                            <input class="form-control" id="username" runat="server">
                        </div>
                        <div class="form-group">
                            <asp:Button Text="Submit" CssClass="btn btn-success" runat="server" ID="btupdate" OnClick="btupdate_Click" />
                        </div>
                        <asp:Label ID="MSGLabel" Text="" runat="server" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
