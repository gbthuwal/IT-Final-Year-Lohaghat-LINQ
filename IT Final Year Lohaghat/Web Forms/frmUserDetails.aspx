<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmUserDetails.aspx.cs" Inherits="IT_Final_Year_Lohaghat.Web_Forms.frmUserDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../CSS/ITFinalStyles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <th colspan="3">Hello <asp:Label ID="lblUserName" runat="server" Text=""></asp:Label></th>
                </tr>
                <tr>
                    <td class="tdleft">User LoginID</td>
                    <td>:</td>
                    <td><asp:Label ID="lblUserID" runat="server" Text="" CssClass="label"></asp:Label></td>
                </tr>
                <tr>
                    <td class="tdleft"></td>
                    <td></td>
                    <td></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
