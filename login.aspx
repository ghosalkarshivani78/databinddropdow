<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="login.aspx.cs" Inherits="login_form.login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <h2> Login form</h2>
               <div class="form-group">
    <label>Username</label>
    <asp:TextBox ID="username" CssClass="form-control" runat="server"></asp:TextBox>
    <label>Passsword</label>
        <asp:TextBox ID="password"  CssClass="form-control" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" onclick="logindata"  CssClass="form-control btn btn-primary" runat="server" Text="Login" />
    <asp:Button ID="Button2" onclick="newaccount" CssClass="form-control btn btn-primary" runat="server" Text="Create new account" />
</div>
</asp:Content>

