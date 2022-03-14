<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="login_form._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Login form</h2>
              <div class="form-group">

    <label>Username</label>
    <asp:TextBox ID="username" CssClass="form-control" runat="server"></asp:TextBox>
    <label>Passsword</label>
        <asp:TextBox ID="password" CssClass="form-control" runat="server"></asp:TextBox>
                  </div>
<asp:Button ID="Button1" onclick="logindata"  CssClass="form-control btn btn-primary" runat="server" Text="Button" />
<a href="Contact.aspx">Register</a>

</asp:Content>
