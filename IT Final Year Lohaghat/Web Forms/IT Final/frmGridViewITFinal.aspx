<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmGridViewITFinal.aspx.cs" Inherits="IT_Final_Year_Lohaghat.Web_Forms.frmGridViewITFinal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../CSS/ITFinalStyles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <th colspan="2">Grid View Control</th>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="GVDetail" runat="server"></asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td>List of Machines</td>
                    <td><asp:DropDownList ID="ddlMachines" runat="server"></asp:DropDownList></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
