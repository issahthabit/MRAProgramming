<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MRA.WebForm1" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server" ID="content1">
 <div class="row">
            <div class="col-md-4 col-md-offset-4 text-center logo-margin ">
              <img src="assets/img/mra.jpg" alt=""/>
                </div>
            <div class="col-md-4 col-md-offset-4">
                <div class="login-panel panel panel-default">                  
                    <div class="panel-heading">
                        <h3 class="panel-title">Please Sign In</h3>
                    </div>
                    <div class="panel-body">
                            <fieldset>
                                <div class="form-group">
                                    <input class="form-control" placeholder="E-mail" name="email" type="email" id="txtemail" runat="server" autofocus>
                                </div>
                                <div class="form-group">
                                    <input class="form-control" placeholder="Password" name="password" type="password" id="txtpassword" runat="server" value="">
                                </div>
                                
                                <asp:Button ID="btnsubmit" Text="Login" CssClass="btn btn-lg btn-success btn-block" runat="server" OnClick="btnsubmit_Click" />
                                <asp:Label ID="msgLabel" Text="" runat="server"/>
                            </fieldset>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>