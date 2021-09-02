<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmAccessClassLibrary.aspx.cs" Inherits="IT_Final_Year_Lohaghat.Web_Forms.frmAccessClassLibrary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>

    </style>
    <script>

    </script>

    <link href="../CSS/ITFinalStyles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <th colspan="2"></th>
                </tr>
                <tr>
                    <td class="tdleft"></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="tdleft"></td>
                    <td><asp:Label ID="lblMessage" runat="server" Text="Message"></asp:Label></td>
                </tr>
                <tr>
                    <td class="tdleft"></td>
                    <td><asp:DropDownList ID="ddlEvenNumbers" runat="server" CssClass="dropdown"></asp:DropDownList></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
