<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLectureLinqToXml.aspx.cs" Inherits="IT_Final_Year_Lohaghat.Web_Forms.frmLectureLinqToXml" %>

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
                    <th colspan="2"><asp:Label ID="lblMessage" runat="server"></asp:Label></th>
                </tr>
                <tr>
                    <td class="tdleft">Grid View Control</td>
                    <td>
                        <asp:DropDownList ID="ddlOptions" runat="server" AutoPostBack="true" CssClass="dropdown" OnSelectedIndexChanged="ddlOptions_SelectedIndexChanged">
                            <asp:ListItem Value ="1" Text="Update Given XML Elements"></asp:ListItem>
                            <asp:ListItem Value ="2" Text="Insert New XML Element"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="tdleft">Item ID</td>
                    <td>
                        <asp:TextBox ID="txtItemID" Text="" runat="server" CssClass="textbox"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="tdleft">Item Name</td>
                    <td>
                        <asp:TextBox ID="txtName" Text="" runat="server" CssClass="textbox"></asp:TextBox>
                    </td>
                </tr>
                
                <tr>
                    <td class="tdleft">Item Quantity</td>
                    <td>
                        <asp:TextBox ID="txtQuantity" Text="" runat="server" CssClass="textbox"></asp:TextBox>
                    </td>
                </tr>
                <tr id="trSpec" runat="server">
                    <td class="tdleft" runat="server">Item Specification</td>
                    <td>
                        <asp:TextBox ID="txtSpecification" Text="" runat="server" CssClass="textbox"></asp:TextBox>
                    </td>
                </tr>
                <tr id="trMake" runat="server">
                    <td class="tdleft">Make By Company</td>
                    <td>
                        <asp:TextBox ID="txtMake" Text="" runat="server" CssClass="textbox"></asp:TextBox>
                    </td>
                </tr>
                <tr id="trPrice" runat="server">
                    <td class="tdleft" runat="server">Unit Price</td>
                    <td>
                        <asp:TextBox ID="txtPrice" Text="" runat="server" CssClass="textbox"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="tdleft"></td>
                    <td>
                        <asp:Button ID="btnSaveUpdate" Text="Update" runat="server" CssClass="button" OnClick="btnSaveUpdate_Click"></asp:Button>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="GVBookDetails" runat="server" CssClass="myGridClass"></asp:GridView>
                    </td>
                </tr>
                <tr>
                    <th colspan="2">GP Lohaghat</th>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
