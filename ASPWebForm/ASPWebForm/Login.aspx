<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASPWebForm.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            text-align: right;
            width: 370px;
        }
        .auto-style4 {
            width: 370px;
        }
        .auto-style5 {
            text-align: right;
            width: 370px;
            font-size: large;
        }
        .auto-style6 {
            width: 232px;
        }
        .auto-style7 {
            width: 251px;
        }
        .auto-style8 {
            width: 251px;
            font-size: large;
        }
        .auto-style9 {
            font-size: large;
        }
        .auto-style10 {
            width: 370px;
            height: 53px;
        }
        .auto-style11 {
            width: 232px;
            height: 53px;
        }
        .auto-style12 {
            width: 251px;
            font-size: large;
            height: 53px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <strong>Login Page</strong><table class="auto-style2">
            <tr>
                <td class="auto-style3" style="font-size: medium">Username</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtUsername" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername" CssClass="auto-style9" ErrorMessage="Please enter User Name" style="text-align: left; color: #FF0000"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Password</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" CssClass="auto-style9" ErrorMessage="Please Enter Password" style="text-align: left; color: #FF0000"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style10"></td>
                <td class="auto-style11">
                    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" Width="81px" />
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Registration.aspx" style="font-size: medium">New User Register Here</asp:HyperLink>
                </td>
                <td class="auto-style12"></td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
