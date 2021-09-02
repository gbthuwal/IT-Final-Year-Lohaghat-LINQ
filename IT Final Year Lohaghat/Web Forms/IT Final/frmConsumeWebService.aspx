<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmConsumeWebService.aspx.cs" Inherits="IT_Final_Year_Lohaghat.Web_Forms.IT_Final.frmConsumeWebService" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id ="headPage" runat="server">
    <title></title>
    <link href="../../CSS/ITFinalStyles.css" rel="stylesheet" />
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <th>Consume Web Service</th>
                </tr>
                <tr>
                    <td>
                       <asp:GridView ID="GVDetail" runat="server" CssClass="myGridClass"></asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
        <div id="canvasMap"> </div>  
    </form>
</body>
</html>
