<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master" CodeBehind="register.aspx.cs" Inherits="login_form.register" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <h2> Register form</h2>
               <div class="form-group">
    <label>Username</label>
    <asp:TextBox ID="username" CssClass="form-control" runat="server"></asp:TextBox>
    <label>Passsword</label>
        <asp:TextBox ID="password"  CssClass="form-control" runat="server"></asp:TextBox>
        <label>Confirm Password</label>
        <asp:TextBox ID="confirmpassword"  CssClass="form-control" runat="server"></asp:TextBox>
                      </div>
    <asp:Button ID="Button2" onclick="login" CssClass="form-control btn btn-primary" runat="server" Text="login" />
<asp:Button ID="Button1" onclick="registerdata"  CssClass="form-control btn btn-primary" runat="server" Text="Button" />
</asp:Content>