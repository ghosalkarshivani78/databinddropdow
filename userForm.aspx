<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userForm.aspx.cs" Inherits="login_form.userForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Enter name:  <asp:TextBox ID="name" runat="server"></asp:TextBox>
        Enter email<asp:TextBox ID="email" runat="server"></asp:TextBox>
                Enter number<asp:TextBox ID="number" runat="server"></asp:TextBox>
        <select name="cityid">
            <asp:Repeater ID="cityList" runat="server">  
            <ItemTemplate>
                <option value="<%#Eval("cityid") %>"><%#Eval("name") %></option>
            </ItemTemplate>
                </asp:Repeater>
        </select>
        <asp:Button ID="Button1" runat="server" OnClick="submit" Text="submit" />


        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="cityid" HeaderText="cityid" SortExpression="cityid" />
                <asp:BoundField DataField="cityname" HeaderText="cityname" SortExpression="cityname" />
            </Columns>
        </asp:GridView>

      
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbconnection %>" SelectCommand="SELECT p.id, p.name, p.email, p.cityid, cf.name AS cityname FROM person1 AS p INNER JOIN city_fk AS cf ON p.cityid = cf.cityid"></asp:SqlDataSource>

      
    </form>
    <script>
       let dt =  document.getElementById(`<%# Eval("Label1")%>`);
        console.log('Hello', dt)
    </script>
</body>
</html>
