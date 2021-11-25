<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TaxPayerList.aspx.cs" Inherits="MRA.TaxPayerList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <!-- Page Header -->
        <div class="col-lg-12">
            <h1 class="page-header">TaxPayersList</h1>
        </div>
        <!--End Page Header -->
    </div>
    <div class="col-lg-12">
        <div class="panel panel-default">
            <div class="panel-heading">
                All Tax Payers
                <asp:Button ID="btnViewTaxPayers" CssClass="btn btn-primary pull-right" Text="View Tax Payers" runat="server" OnClick="btnViewTaxPayers_Click" />
            </div>
            <div class="panel-body">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="form-group">
                            <%--<asp:Table ID="Table1" CssClass="table table-striped table-bordered table-hover" runat="server" />--%>
                            <asp:GridView ID="Gridview1" CssClass="table table-striped table-bordered table-hover" runat="server" />
                        </div>
                        <asp:Label ID="MsgLabel" Text="" runat="server" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
