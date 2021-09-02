<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDisplayUsersLinqToSQL.aspx.cs" Inherits="IT_Final_Year_Lohaghat.Web_Forms.frmDisplayUsersLINQ" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../CSS/ITFinalStyles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="maindiv">
            <table class="center">
                <tr>
                    <th colspan="3">User Details</th>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:GridView ID="gvUserDetails" runat="server" CssClass="myGridClass"></asp:GridView>
                    </td>
                </tr>
                <tr>
                    <th colspan="3">Item Detail</th>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:GridView ID="gvItemDetails" runat="server" CssClass="myGridClass"></asp:GridView>
                    </td>
                </tr>
                <tr>
                    <th colspan="3">Even Numbers</th>
                </tr>
                <tr>
                    <td class="tdleft">Even Number List</td>
                    <td >:</td>
                    <td class="tdright">
                        <asp:DropDownList ID="ddlEvenNumbers" runat="server" CssClass="dropdown"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="tdleft">Average of Number</td>
                    <td >:</td>
                    <td class="tdright">
                        <asp:Label ID="lblMessage" runat="server" CssClass="label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <th colspan="3">...</th>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
