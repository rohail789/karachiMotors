<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgetPassword.aspx.cs" Inherits="KarachiMotorSystem.ForgetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Forget Password</title>
    <link href="ForgetPasswordStyle.css" rel="stylesheet" />

    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 398px;
        }
        .auto-style2 {
            height: 59px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div id="Container">

        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="X-Large" Text="Forget Password"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TbxEmail" runat="server" Height="41px" Width="366px" PlaceHolder="Email"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TbxCellNo" runat="server" Height="41px" Width="366px" PlaceHolder="Cell Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="BtnCheck" runat="server" Height="41px" Text="Check " Width="300px" OnClick="btncheck"  />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TbxNewPassword" runat="server" Height="41px" Width="366px" PlaceHolder="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TbxConformPassword" runat="server" Height="41px" Width="366px" PlaceHolder="Confirm Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="BtnSumit" runat="server" Height="41px" Text="Submit" Width="300px" OnClick="btnSubmit" />
                </td>
            </tr>
        </table>

    </div>
    </form>
</body>
</html>
