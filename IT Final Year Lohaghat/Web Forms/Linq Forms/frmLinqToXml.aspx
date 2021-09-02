<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLinqToXml.aspx.cs" Inherits="IT_Final_Year_Lohaghat.Web_Forms.frmLinqToXml" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <th>Grid View Control</th>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GVBookDetails" runat="server"></asp:GridView>
                    </td>
                </tr>
                <tr>
                    <th><asp:Label ID="lblMessage" runat="server"></asp:Label></th>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
