<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ItemMaster.aspx.cs" Inherits="IT_Final_Year_Lohaghat.Web_Forms.ItemMaster" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../CSS/ITFinalStyles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <table>
               <tr>
                   <th colspan="3">Item Master</th>
               </tr>
               <tr>
                   <td class="tdleft"></td>
                   <td></td>
                   <td class="label">
                       <asp:RequiredFieldValidator ID="validateTextBox" runat="server" ErrorMessage="Item Name Should Not Be Empty" ControlToValidate="txtItemName"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td class="tdleft"></td>
                   <td></td>
                   <td class="label">
                       <asp:RangeValidator ID="validateQuantityRange" runat="server" MinimumValue="1" MaximumValue="10" Type="Integer" ErrorMessage="Quantity Must Lies Between 1 and 10" ControlToValidate="txtQuantity"></asp:RangeValidator>
                   </td>
               </tr>
               <tr>
                   <td class="tdleft"></td>
                   <td></td>
                   <td class="label">
                       <asp:RequiredFieldValidator ID="validateQuantity" runat="server" ErrorMessage="Quantity Should Not Empty" ControlToValidate="txtQuantity"></asp:RequiredFieldValidator>
                   </td>
               </tr>
               <tr>
                   <td class="tdleft">Item Name</td>
                   <td>:</td>
                   <td><asp:TextBox ID="txtItemName" runat="server" CssClass="textbox"></asp:TextBox></td>
               </tr>
               <tr>
                   <td class="tdleft">Quantity</td>
                   <td>:</td>
                   <td><asp:TextBox ID="txtQuantity" runat="server" CssClass="textbox"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td class="tdleft">Item Name</td>
                   <td>:</td>
                   <td><asp:DropDownList ID="ddlItemName" runat ="server" AutoPostBack="true" CssClass ="dropdown" OnSelectedIndexChanged="ddlItemName_SelectedIndexChanged"></asp:DropDownList></td>
               </tr>
               <tr>
                   <td class="tdleft"></td>
                   <td></td>
                   <td>
                       <asp:Button ID="btnSave" runat="server" CssClass="button" Text="Save" OnClick="btnSave_Click" />
                       <asp:Button ID="btnReset" runat="server" CssClass="button" Text="Reset" OnClick="btnReset_Click" />
                       <asp:Button ID="btnStock" runat="server" CssClass="button" Text="Display Stock" OnClick="btnStock_Click" />
                   </td>
               </tr>
               <tr>
                   <td colspan="3"> 
                       <asp:GridView ID="gvItems" runat="server" CssClass="myGridClass" Width="100%">
                       </asp:GridView>
                   </td>
               </tr>
               <tr>
                   <th colspan="3"> 
                   <asp:Label ID="lblMessage" runat="server" CssClass="label"></asp:Label>
                   </th>
               </tr>
           </table>
        </div>
        <div>

        </div>
    </form>
</body>
</html>
