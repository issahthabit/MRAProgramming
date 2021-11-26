<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteTaxPayer.aspx.cs" Inherits="MRA.DeleteTaxPayer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <!-- Page Header -->
        <div class="col-lg-12">
            <h1 class="page-header">Delete Tax Payer</h1>
        </div>
        <div class="col-lg-12">
        <div class="panel panel-default">
            <div class="panel-heading">
                Updating Tax payers details
            </div>
            <div class="panel-body">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="form-group input-group">
                            <input type="text" class="form-control" id="tpin" runat="server">
                            <span class="input-group-btn">
                                <asp:Button ID="btnsearch" Text="Search" CssClass="btn btn-default" runat="server" />
                                <%--<button class="btn btn-default" type="button" id="btnSearch"   runat="server">
                                    <i class="fa fa-search"></i>
                                </button>--%>
                            </span>
                        </div>
                        <div class="form-group">
                            <label>Business CertificateNumber:</label>
                            <input class="form-control" id="BusinessCertificateNumber" disabled="disabled" runat="server">
                        </div>
                        <div class="form-group">
                            <label>Trading Name:</label>
                            <input class="form-control" id="TradingName" disabled="disabled" runat="server">
                        </div>
                        <div class="form-group">
                            <label>Business Registration Date:</label>
                            <input class="form-control" id="BusinessRegistrationDate" type="date" disabled="disabled" runat="server">
                        </div>
                        <div class="form-group">
                            <label>Mobile Number:</label>
                            <input class="form-control" id="MobileNumber" disabled="disabled" runat="server">
                        </div>
                        <div class="form-group">
                            <label>Email:</label>
                            <input class="form-control" id="Email" disabled="disabled" runat="server">
                        </div>
                        <div class="form-group">
                            <label>Pysical Location</label>
                            <input class="form-control" id="phyiscallocation" disabled="disabled" runat="server">
                        </div>
                        <div class="form-group">
                            <label>Username</label>
                            <input class="form-control" id="username" disabled="disabled" runat="server">
                        </div>
                        <div class="form-group">
                            <asp:Button Text="Submit" CssClass="btn btn-success" runat="server" ID="btupdate" OnClick="btupdate_Click" />
                        </div>
                        <asp:Label ID="MSGLabel" Text="" runat="server" />
                    </div>
                </div>
            </div>
        <!--End Page Header -->
    </div>
</asp:Content>
