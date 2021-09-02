<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StoreStockRegister.aspx.cs" Inherits="IT_Final_Year_Lohaghat.Web_Forms.XML.WebForm1" %>

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
                   <th colspan="3">Stock Book</th>
               </tr>
               <tr>
                   <td class="tdleft">Item Name</td>
                   <td>:</td>
                   <td><asp:TextBox ID="txtItemName" runat="server" CssClass="textbox"></asp:TextBox></td>
               </tr>
               <tr>
                   <td class="tdleft">Department Name</td>
                   <td>:</td>
                   <td><asp:TextBox ID="txtDeptName" runat="server" CssClass="textbox"></asp:TextBox></td>
               </tr>
               <tr>
                   <td class="tdleft">Quantity Available</td>
                   <td>:</td>
                   <td><asp:TextBox ID="txtQty" runat="server" CssClass="textbox"></asp:TextBox></td>
               </tr>
               <tr>
                   <td colspan="3"> 
                       
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