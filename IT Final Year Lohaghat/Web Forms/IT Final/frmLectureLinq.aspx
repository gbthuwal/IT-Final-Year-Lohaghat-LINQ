<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLectureLinq.aspx.cs" Inherits="IT_Final_Year_Lohaghat.Web_Forms.frmLectureLinq" %>

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
                <th colspan="2">Language Integrated Query</th>
            </tr>
             <tr>
                 <td class="tdleft">Select Linq Option : </td>
                <td>
                   <asp:DropDownList ID="ddlOptions" runat="server" CssClass="dropdown" OnSelectedIndexChanged="ddlOptions_SelectedIndexChanged" AutoPostBack="true">
                       <asp:ListItem Value="1" Text="LINQ to List Object"></asp:ListItem>
                       <asp:ListItem Value="2" Text="LINQ to Array Object "></asp:ListItem>
                       <asp:ListItem Value="3" Text="LINQ to Data Table Object "></asp:ListItem>
                   </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="GVStudentDetail" runat="server" CssClass="myGridClass"></asp:GridView>
                </td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
