<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="All_Validations.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" style ="background-color:aqua";width="400px">
            <tr>
                <td>
                    <asp:Label ID ="lblFirst" runat ="server" Text ="First name"></asp:Label></td>
                  <td>  <asp:TextBox ID ="txtFirst" runat ="server"></asp:TextBox>
                      <asp:RequiredFieldValidator ID ="rfvFirst" runat ="server" ControlToValidate ="txtFirst" ErrorMessage ="first name is required" ForeColor ="Red" ></asp:RequiredFieldValidator>
                </td>
            </tr>
                <tr>
    <td> 
        <asp:Label ID ="lblLast" runat ="server" Text ="Last name"></asp:Label></td>
      <td>  <asp:TextBox ID ="txtLast" runat ="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID ="rfvLast" runat="server" ControlToValidate ="txtLast" ErrorMessage ="last name is required" ForeColor ="Red" ></asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
    <td>
        <asp:Label ID ="lblemail" runat ="server" Text ="email"> </asp:Label></td>
       <td> <asp:TextBox ID ="txtemail" runat ="server"> </asp:TextBox>
           <asp:RequiredFieldValidator ID ="rfvemail" runat="server" ControlToValidate ="txtemail" ErrorMessage ="emial is required" ForeColor ="Red" ></asp:RequiredFieldValidator>
           <asp:RegularExpressionValidator ID="revemail" runat="server" ControlToValidate="txtemail" ErrorMessage ="inproper email,please write correct one" ForeColor ="Red" ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$"></asp:RegularExpressionValidator>
    </td>
</tr>
<tr>
    <td>
        <asp:Label ID ="lblpassword" runat ="server" Text ="Password">  </asp:Label></td>
      <td>  <asp:TextBox ID ="txtpassword" runat ="server" TextMode="Password"></asp:TextBox>
          <asp:RequiredFieldValidator ID ="rfvpassword" runat="server" ControlToValidate ="txtpassword" ErrorMessage ="password is required" Forecolor="Red"></asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
    <td>
        <asp:Label ID ="lblConfirmPassword" runat ="server" Text ="Confirm Password">  </asp:Label></td>
       <td> <asp:TextBox ID ="txtConfirmPassword" runat ="server" TextMode="Password"></asp:TextBox>
           <asp:RequiredFieldValidator ID ="rfvconfirmpassword" runat="server" ControlToValidate="txtconfirmpassword" ErrorMessage ="confirm password is required" ForeColor ="Red" ></asp:RequiredFieldValidator>
           <asp:CompareValidator ID ="cvconfirmpassword" runat="server" ControlToValidate="txtConfirmPassword" ControlToCompare="txtpassword"  ErrorMessage="confirm password is does not match" ForeColor ="Red" ></asp:CompareValidator>
    </td>
</tr>

    <td>
        <asp:Label ID ="lblmobile" runat ="server" Text ="mobile number"></asp:Label></td>
      <td>  <asp:TextBox ID="txtmobile" runat ="server"></asp:TextBox>
          <asp:RequiredFieldValidator ID ="rfvmobile" runat="server" ControlToValidate="txtmobile" ErrorMessage ="mobile number is required" ForeColor ="Red"  Display="Dynamic" ></asp:RequiredFieldValidator>
          <asp:RegularExpressionValidator ID="revmobile" runat="server" ControlToValidate ="txtmobile" ErrorMessage ="invalid mobile number(must be 10 digits)" ForeColor ="Red"  ValidationExpression="^\d{10}$"  Display="Dynamic"></asp:RegularExpressionValidator>
    </td>
</tr>
<tr>
    <td>
        <asp:Label ID ="lblage" runat ="server" Text ="age">  </asp:Label></td>
      <td>  <asp:TextBox ID ="txtage" runat ="server"> </asp:TextBox>
          <asp:RequiredFieldValidator ID="rfvage" runat="server" ControlToValidate ="txtage" ErrorMessage ="age is required" ForeColor ="Red" ></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="rvage" runat="server" ControlToValidate ="txtage" ErrorMessage ="age is between 20 to 30" ForeColor ="Red" MinimumValue ="20" MaximumValue ="30"></asp:RangeValidator>
    </td>
</tr>
    <tr>
       <td colspan="2" align="center">
         <asp:Button ID ="btnbutton" runat="server" Text ="button" OnClick ="btnSubmit_Click" />
                    </td>
                </tr>
            
                </table>
            <tr>
                <td>
                    <asp:Label ID="lblFirst" runat="server" Text="First name"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox="txtFirst" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID ="lblLast" runat="server" Text ="Last name"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID ="txtLast" runat ="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID ="lblemail" runat ="server" Text ="email"> </asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID ="txtemail" runat ="server"> </asp:TextBox>
                </td>
            <tr>
                <td>
                    <asp:Label ID ="lblpassword" runat ="server" Text ="Password">  </asp:Label>
                </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
                    </td>
                </tr>
            <tr>
                <td>
                    <asp:Label ID ="lblConfirmPassword" runat ="server" Text ="Confirm Password">  </asp:Label>
                </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID ="txtConfirmPassword" runat ="server"></asp:TextBox>
                    </td>
            <tr>
                <td>
                    <asp:Label ID ="lblmobile" runat ="server" Text ="mobile number"></asp:Label>
                </td>
                </tr>
                    <tr>
                    <td>
                        <asp:TextBox ID="txtmobile" runat ="server"></asp:TextBox>
                    </td>
            <tr>
                <td>
                    <asp:Label ID ="lblage" runat ="server" Text ="age">  </asp:Label>
                </td>
                </tr>
                        <tr>
                    <td>
                        <asp:TextBox ID ="txtage" runat ="server"> </asp:TextBox>
                    </td>

        </div>
    </form>
</body>
</html>
