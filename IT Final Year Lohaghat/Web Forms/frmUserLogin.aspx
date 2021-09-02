<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmUserLogin.aspx.cs" Inherits="IT_Final_Year_Lohaghat.Web_Forms.frmUserLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../CSS/ITFinalStyles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table style="width:100%;">
                <tr>
                    <th colspan="3"> User Login </th>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td>
                        <asp:Label ID="lblMessage" runat="server" Text="" CssClass="label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="tdleft">User Name</td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server" CssClass="textbox"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="tdleft">Password</td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="textbox" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td>
                        <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="button" OnClick="btnLogin_Click" />
                        <asp:Button ID="btnNewUser" runat="server" Text="New User Registration" CssClass="button" OnClick="BtnNewUser_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="tdleft"></td>
                    <td></td>
                    <td></td>
                </tr>
               
                <tr>
                    <th colspan="3"></th>
                </tr>
               
            </table>

        </div>
    </form>
</body>
</html>
