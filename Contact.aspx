<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="login_form.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <h2> Register form</h2>
                  <div class="form-group">
    <label>Username</label>
    <asp:TextBox ID="username" CssClass="form-control" runat="server"></asp:TextBox>
    <label>Passsword</label>
        <asp:TextBox ID="password"  CssClass="form-control" runat="server"></asp:TextBox>
        <label>city</label>
        <asp:TextBox ID="city"  CssClass="form-control" runat="server"></asp:TextBox>
<asp:Button ID="Button1" onclick="registerdata"  CssClass="form-control btn btn-primary" runat="server" Text="Button" />
</div>
</asp:Content>
