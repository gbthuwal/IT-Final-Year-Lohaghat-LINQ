<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmReadXmlFile.aspx.cs" Inherits="IT_Final_Year_Lohaghat.Web_Forms.ReadXmlFile" %>

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
                    <th>Read XML File</th>
                    </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GVStudentDetail" runat="server" CssClass="myGridClass"></asp:GridView>
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
