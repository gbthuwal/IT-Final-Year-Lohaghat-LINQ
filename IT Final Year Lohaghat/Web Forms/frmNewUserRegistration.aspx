<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmNewUserRegistration.aspx.cs" Inherits="IT_Final_Year_Lohaghat.Web_Forms.frmNewUserRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../CSS/ITFinalStyles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
                <div>

            <table style="width:100%;">
                <tr>
                    <th colspan="3"> New User Registration </th>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td>
                        <asp:Label ID="lblMessage" runat="server" Text="" CssClass="label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="tdleft">First Name</td>
                    <td class="tdcenter">:</td>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server" CssClass="textbox"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="tdleft">Last Name</td>
                    <td class="tdcenter">:</td>
                    <td>
                        <asp:TextBox ID="txtLastName" runat="server" CssClass="textbox" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="tdleft">LoginID</td>
                    <td class="tdcenter">:</td>
                    <td>
                        <asp:TextBox ID="txtLoginID" runat="server" CssClass="textbox" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="tdleft">Password</td>
                    <td class="tdcenter">:</td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="textbox" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="tdleft">ConfirmPassword</td>
                    <td class="tdcenter">:</td>
                    <td>
                        <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="textbox" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="tdleft">Security Question</td>
                    <td class="tdcenter">:</td>
                    <td>
                        <asp:DropDownList ID="ddlSecurityQuestion" runat="server" CssClass="dropdown">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="tdleft">Security Answer</td>
                    <td class="tdcenter">:</td>
                    <td>
                        <asp:TextBox ID="txtSecurityAnswer" runat="server" CssClass="textbox" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="tdleft"></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="tdleft"></td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td>
                        <asp:Button ID="btnRegister" runat="server" Text="Register" CssClass="button" OnClick="BtnRegister_Click" />
                        <asp:Button ID="btnReset" runat="server" Text="Reset" CssClass="button" OnClick="btnReset_Click" />
                        <asp:Button ID="btnBack" runat="server" Text="Goto Login" CssClass="button" />
                    </td>
                </tr>
                <tr>
                    <td class="tdleft"></td>
                    <td></td>
                    <td></td>
                </tr>
               
                <tr>
                    <th colspan="3"></th>
                </tr>
               
            </table>

        </div>
    </form>
</body>
</html>
