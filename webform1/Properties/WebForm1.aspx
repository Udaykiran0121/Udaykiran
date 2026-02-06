<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="webform1.Properties.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="firstnumber"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />   

            <asp:Label ID="label2" runat="server" Text="secondnumber"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="Label3" runat="server" Text="Result"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" ReadOnly ="true"></asp:TextBox>
            <br />
            
            <asp:Button ID="btnAdd" runat="server" Text="Addition" OnClick="btnAdd_Click" />
           


          

        </div>
    </form>
</body>
</html>
