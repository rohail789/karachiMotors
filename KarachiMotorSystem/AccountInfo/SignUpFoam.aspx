<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUpFoam.aspx.cs" Inherits="KarachiMotorSystem.SignUpFoam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="SignUpStyle.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 446px;
        }
        .auto-style2 {
        }
        .auto-style4 {
        }
        .auto-style6 {
            width: 413px;
            height: 76px;
        }
        .auto-style7 {
            height: 76px;
        }
        .auto-style8 {
            width: 100%;
        }
        .auto-style9 {
            height: 23px;
            text-align: left;
        }
        .auto-style10 {
            width: 127px;
            height: 26px;
        }
        .auto-style11 {
            width: 122px;
            height: 26px;
        }
        .auto-style12 {
            height: 26px;
            width: 150px;
        }
        .auto-style13 {
            height: 23px;
            text-align: left;
        }
        .auto-style14 {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
    
        <table class="auto-style1">
            <tr>
                <td colspan="2">
                    <asp:Label Text="Create A New Account" runat="server"  ID="LblCreateAccounts" Font-Bold="True" Font-Size="X-Large"/>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"> 
                    <asp:TextBox runat="server" ID="TbxFirstName" Height="31px" Width="230px" PlaceHolder="First Name" ControlToValidate="TbxFirstName" /><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="TbxFirstName"></asp:RequiredFieldValidator>

                </td>
                <td> 
                    <asp:TextBox runat="server" ID="TxtSurname" Height="31px" Width="230px" PlaceHolder="Surname"/>
                </td>
            </tr>
            <tr>
                <td class="auto-style6"> 
                    <asp:TextBox runat="server" ID="Txtpassword" Height="31px" Width="230px" PlaceHolder="Password" TextMode="Password"/>
                </td>
                <td class="auto-style7"> 
                    <asp:TextBox runat="server" ID="TxtConformpassword" Height="31px" Width="230px" PlaceHolder="Confirm Password" TextMode="Password"/>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2"> 
                    <asp:TextBox runat="server" ID="TxtEmailAddress" Height="31px" style="margin-left: 0px" Width="564px" PlaceHolder="Email Address"/>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2"> 
                    <asp:TextBox runat="server" ID="TxthomeAddress" Height="31px" Width="564px" PlaceHolder="Home Address "/>
                </td>
            </tr>
            <tr>
                <td class="auto-style4" colspan="2"> 
                    <asp:TextBox runat="server" ID="Txtphoneno" Height="31px" Width="564px" PlaceHolder="Cell Number"/>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <table class="auto-style8">
                        <tr>
                            <td colspan="3" class="auto-style9">
                                <asp:Label Text="Brithday" runat="server" style="text-align: right; font-weight: 700;" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style10">
                                <asp:DropDownList ID="DropDownDay" runat="server" Height="25px" Width="89px">
                                    <asp:ListItem>Day</asp:ListItem>
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem>4</asp:ListItem>
                                    <asp:ListItem>5</asp:ListItem>
                                    <asp:ListItem>6</asp:ListItem>
                                    <asp:ListItem>7</asp:ListItem>
                                    <asp:ListItem>8</asp:ListItem>
                                    <asp:ListItem>9</asp:ListItem>
                                    <asp:ListItem>10</asp:ListItem>
                                    <asp:ListItem>11</asp:ListItem>
                                    <asp:ListItem>12</asp:ListItem>
                                    <asp:ListItem>13</asp:ListItem>
                                    <asp:ListItem>14</asp:ListItem>
                                    <asp:ListItem>15</asp:ListItem>
                                    <asp:ListItem>16</asp:ListItem>
                                    <asp:ListItem>17</asp:ListItem>
                                    <asp:ListItem>18</asp:ListItem>
                                </asp:DropDownList>

                            </td>
                            <td class="auto-style11">
                                <asp:DropDownList ID="DropDownMonth" runat="server" Height="25px" Width="89px">
                                    <asp:ListItem>Month</asp:ListItem>
                                    <asp:ListItem>Jan</asp:ListItem>
                                    <asp:ListItem>Feb</asp:ListItem>
                                    <asp:ListItem>March</asp:ListItem>
                                    <asp:ListItem>April</asp:ListItem>
                                    <asp:ListItem>March</asp:ListItem>
                                    <asp:ListItem>May</asp:ListItem>
                                    <asp:ListItem>June</asp:ListItem>
                                    <asp:ListItem>July</asp:ListItem>
                                    <asp:ListItem>Aug</asp:ListItem>
                                    <asp:ListItem>Sep</asp:ListItem>
                                    <asp:ListItem>Oct</asp:ListItem>
                                    <asp:ListItem>Nov</asp:ListItem>
                                    <asp:ListItem>Dec</asp:ListItem>
                                </asp:DropDownList>

                            </td>
                            <td class="auto-style12">
                                <asp:DropDownList ID="DropDownYear" runat="server" Height="25px" Width="89px">
                                    <asp:ListItem>Year</asp:ListItem>
                                    <asp:ListItem>2017</asp:ListItem>
                                    <asp:ListItem>2016</asp:ListItem>
                                    <asp:ListItem>2015</asp:ListItem>
                                    <asp:ListItem>2014</asp:ListItem>
                                    <asp:ListItem>2013</asp:ListItem>
                                    <asp:ListItem>2012</asp:ListItem>
                                    <asp:ListItem>2011</asp:ListItem>
                                    <asp:ListItem>2010</asp:ListItem>
                                    <asp:ListItem>2009</asp:ListItem>
                                    <asp:ListItem>2008</asp:ListItem>
                                    <asp:ListItem>2007</asp:ListItem>
                                    <asp:ListItem>2006</asp:ListItem>
                                    <asp:ListItem>2005</asp:ListItem>
                                    <asp:ListItem>2004</asp:ListItem>
                                    <asp:ListItem>2003</asp:ListItem>
                                    <asp:ListItem>2002</asp:ListItem>
                                    <asp:ListItem>2001</asp:ListItem>
                                    <asp:ListItem>2000</asp:ListItem>
                                </asp:DropDownList>

                            </td>
                        </tr>
                    </table>
                </td>
                <td>
                    <table class="auto-style8">
                        <tr>
                            <td class="auto-style13">
                                <asp:Label Text="Gender" runat="server" ID="LblGender" style="font-weight: 700" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style14">
                                <asp:RadioButtonList ID="RdBtngender" runat="server" RepeatDirection="Horizontal" style="text-align: left" Width="227px" OnSelectedIndexChanged="mailRadioButton_SelectedIndexChanged">
                                    <asp:ListItem>  Male</asp:ListItem>
                                    <asp:ListItem>Female</asp:ListItem>
                                    <asp:ListItem>Other</asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td class="auto-style4" colspan="2">
                    <asp:Button Text="Create Account" runat="server" ID="btnCreateAccount" Height="35px" Width="564px" OnClick="CreateAccount" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
