<%@ Page Title="" Language="C#" MasterPageFile="~/MainForm.Master" AutoEventWireup="true" CodeBehind="StockMaster.aspx.cs" Inherits="KarachiMotorSystem.StockMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CPH" runat="server">

    <div id="ContentPage">
        <strong>Welcome to Stock master Page
    </strong>
    <div>
		<table class="auto-style1">
            <tr>
                <td style="width: 110px; height: 26px; text-align: right;">
                    <asp:Label ID="LblstockID" runat="server" Text="Stock ID:"></asp:Label>
                </td>
                <td style="width: 215px; height: 26px; text-align: left;">
                    <asp:TextBox ID="TbxStockID" runat="server" Width="167px" Enabled="False" Height="28px"></asp:TextBox>
                </td>
                <td style="width: 156px; text-align: right; height: 26px;">
                    <asp:Label ID="LblEngineType" runat="server" Text="Engine Type:"></asp:Label>
                </td>
                <td style="width: 209px; height: 26px; text-align: left;">
                    <asp:DropDownList ID="DdnEnginetype" runat="server" Height="35px" Width="153px" style="margin-left: 0px">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>4 Cylinder</asp:ListItem>
                        <asp:ListItem>6 Cylinder</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="height: 26px; text-align: right; width: 162px">
                    <asp:Label ID="LblEngineType0" runat="server" Text="Sun Roof:"></asp:Label>
                </td>
                <td style="height: 26px">
                    <asp:DropDownList ID="DdnSunRoof" runat="server" Height="35px" style="margin-left: 0px" Width="155px">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width: 110px; text-align: right;">
                    <asp:Label ID="LblRegNo" runat="server" Text="Reg No:"></asp:Label>
                </td>
                <td style="width: 215px; text-align: left;">
                    <asp:TextBox ID="TbxRegNo" runat="server" Width="167px" Height="28px"></asp:TextBox>
                </td>
                <td style="width: 156px; text-align: right;">
                    <asp:Label ID="LblTransmissionType" runat="server" Text="Transmission Type:"></asp:Label>
                </td>
                <td style="width: 209px; text-align: left;">
                    <asp:DropDownList ID="DdnTransmissionType" runat="server" Height="35px" style="margin-left: 0px" Width="155px">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>Automatic</asp:ListItem>
                        <asp:ListItem>Manual</asp:ListItem>
                        <asp:ListItem>Steermatic</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="text-align: right; width: 162px">
                    <asp:Label ID="LblEngineType1" runat="server" Text="Wheel Cover:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DdnWheelCover" runat="server" Height="35px" style="margin-left: 0px" Width="155px" >
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width: 110px; text-align: right;">
                    <asp:Label ID="LblMake" runat="server" Text="Make:"></asp:Label>
                </td>
                <td style="width: 215px; text-align: left;">
                    <asp:TextBox ID="TbxMake" runat="server" Width="167px" Height="28px"></asp:TextBox>
                </td>
                <td style="width: 156px; text-align: right;">
                    <asp:Label ID="LblPowerwWindows" runat="server" Text="Power Windows:"></asp:Label>
                </td>
                <td style="width: 209px; text-align: left;">
                    <asp:DropDownList ID="DdnPowerWindow" runat="server" Height="35px" style="margin-left: 0px" Width="155px">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="text-align: right; width: 162px">
                    <asp:Label ID="LblEngineType2" runat="server" Text="Wheel Chrome:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DdnWheelChrome" runat="server" Height="35px" style="margin-left: 0px" Width="155px">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width: 110px; text-align: right;">
                    <asp:Label ID="LblFrameNo" runat="server" Text="Frame No:"></asp:Label>
                </td>
                <td style="width: 215px; text-align: left;">
                    <asp:TextBox ID="TbxFrameNo" runat="server" Width="167px" Height="28px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TbxFrameNo" ErrorMessage="*" ForeColor="Red" ValidationExpression="^[A-Z]{1,3}-\d{5}$"></asp:RegularExpressionValidator>
                </td>
                <td style="width: 156px; text-align: right;">
                    <asp:Label ID="LblstockID11" runat="server" Text="Power Lock:"></asp:Label>
                </td>
                <td style="width: 209px; text-align: left;">
                    <asp:DropDownList ID="DdnPowerLock" runat="server" Height="35px" style="margin-left: 0px" Width="155px">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="text-align: right; width: 162px">
                    <asp:Label ID="DdnwheelAluminum" runat="server" Text="Wheel Aluminum:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DdnWheelAluminium" runat="server" Height="35px" style="margin-left: 0px" Width="155px">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width: 110px; text-align: right;">
                    <asp:Label ID="LblEngineNo" runat="server" Text="Engine No:"></asp:Label>
                </td>
                <td style="width: 215px; text-align: left;">
                    <asp:TextBox ID="TbxEngineNo" runat="server" Width="167px" Height="28px"></asp:TextBox>
                </td>
                <td style="width: 156px; text-align: right;">
                    <asp:Label ID="LblstockID12" runat="server" Text="Cruise Controll:"></asp:Label>
                </td>
                <td style="width: 209px; text-align: left;">
                    <asp:DropDownList ID="DdnCruiseControl" runat="server" Height="35px" style="margin-left: 0px" Width="155px">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="text-align: right; width: 162px">
                    <asp:Label ID="LblEngineType4" runat="server" Text="Type:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DdnType" runat="server" Height="35px" style="margin-left: 0px" Width="155px">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>Trade</asp:ListItem>
                        <asp:ListItem>Purchase</asp:ListItem>
                        <asp:ListItem>USB Player</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width: 110px; text-align: right;">
                    <asp:Label ID="LblVariant" runat="server" Text="Variant:"></asp:Label>
                </td>
                <td style="width: 215px; text-align: left;">
                    <asp:TextBox ID="TbxVariant" runat="server" Width="167px" Height="28px"></asp:TextBox>
                </td>
                <td style="width: 156px; text-align: right;">
                    <asp:Label ID="LblstockID13" runat="server" Text="Air Condition:"></asp:Label>
                </td>
                <td style="width: 209px; text-align: left;">
                    <asp:DropDownList ID="DdnAirCondition" runat="server" Height="35px" style="margin-left: 0px" Width="155px">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="text-align: right; width: 162px" rowspan="3">
                    <asp:Label ID="LblEngineType5" runat="server" Text="Amount :"></asp:Label>
                </td>
                <td rowspan="3">
                    <asp:TextBox ID="TbxOther" runat="server" Width="154px" Height="64px" style="text-align: left" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 110px; text-align: right;">
                    <asp:Label ID="LblModelYear" runat="server" Text="Model Year:"></asp:Label>
                </td>
                <td style="width: 215px; text-align: left;">
                    <asp:TextBox ID="TbxModelYear" runat="server" Width="167px" Height="28px"></asp:TextBox>
                </td>
                <td style="width: 156px; text-align: right;">
                    <asp:Label ID="LblstockID14" runat="server" Text="Radio:"></asp:Label>
                </td>
                <td style="width: 209px; text-align: left;">
                    <asp:DropDownList ID="DdnRadio" runat="server" Height="35px" style="margin-left: 0px" Width="155px">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width: 110px; text-align: right;">
                    <asp:Label ID="LblstockID6" runat="server" Text="Color:"></asp:Label>
                </td>
                <td style="width: 215px; text-align: left;">
                    <asp:TextBox ID="TbxColor" runat="server" Width="167px" Height="28px"></asp:TextBox>
                </td>
                <td style="width: 156px; text-align: right;">
                    <asp:Label ID="LblstockID15" runat="server" Text="Player:"></asp:Label>
                </td>
                <td style="width: 209px; text-align: left;">
                    <asp:DropDownList ID="DdnPlayer" runat="server" Height="35px" style="margin-left: 0px" Width="156px">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>DVD Player</asp:ListItem>
                        <asp:ListItem>F/M </asp:ListItem>
                        <asp:ListItem>USB Player</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            </table>
        <table>
            <tr>
                <td style="width: 1121px; height: 124px">
                    <asp:GridView ID="GridView1" runat="server" CssClass="custom-tab" Height="191px">
                    </asp:GridView>
                </td>
            </tr>
        </table>
        <table style="width: 1128px; height: 111px">
            <tr>
                <td style="text-align: right; width: 86px">
                    <asp:Label ID="LblVariant0" runat="server" Text="Stock ID:" style="text-align: right"></asp:Label>
                </td>
                <td style="width: 178px">
                    <asp:TextBox ID="TbxSearchStockID" runat="server" Width="167px" style="margin-left: 17px"></asp:TextBox>
                </td>
                 <td style="width: 98px">
                    <asp:Label ID="LblVariant1" runat="server" Text="Registration No:"></asp:Label>
                </td>
                 <td style="width: 169px">
                    <asp:TextBox ID="TbxSearchRegistrationNo" runat="server" Width="167px"></asp:TextBox>
                </td>
                 <td style="width: 110px">
                    <asp:Label ID="LblVariant2" runat="server" Text="Chassis No:"></asp:Label>
                </td>
                 <td style="width: 173px">
                    <asp:TextBox ID="TbxSearchChassisNo" runat="server" Width="167px"></asp:TextBox>
                </td>
                 <td>
                     <asp:Button ID="BtnSearch" runat="server" Height="33px" style="margin-right: 0px" Text="Search" Width="207px" OnClick="BtnSearch_Click" />
                </td>   
            </tr>

            <tr>
                 <td colspan="7">
                     <table class="auto-style1" style="height: 35px">
                         <tr>
                             <td>
                                 <asp:Button ID="BtnSSave" runat="server" Height="33px" style="margin-right: 0px" Text="Save" Width="207px" OnClick="BtnSave" />
                             </td>
                             <td>
                                 <asp:Button ID="BtnUpdate" runat="server" Height="33px" style="margin-right: 0px" Text="Update" Width="207px" OnClick="BtnUpdate_Click" />
                             </td>
                             <td>
                                 <asp:Button ID="Button16" runat="server" Height="33px" style="margin-right: 0px" Text="Delete" Width="207px" OnClick="deleteRecord" />
                             </td>
                             <td>
                                 <asp:Button ID="BtnClear" runat="server" Height="33px" style="margin-right: 0px" Text="Clear" Width="207px" OnClick="clear_pressed" />
                             </td>
                             <td>
                                 <asp:Button ID="BtnExit" runat="server" Height="33px" style="margin-right: 0px" Text="Exit" Width="207px" />
                             </td>
                         </tr>
                     </table>
                 </td>
            </tr>
        </table>

		
	</div>

    </div>
</asp:Content>
