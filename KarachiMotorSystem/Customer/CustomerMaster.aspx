<%@ Page Title="" Language="C#" MasterPageFile="~/MainForm.Master" AutoEventWireup="true" CodeBehind="CustomerMaster.aspx.cs" Inherits="KarachiMotorSystem.CustomerMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="CPH" runat="server" >
    <div id ="ContentPage" >
        
        <br />
        
        <table class="auto-style1" style="width: 98%">
            <tr>
                <td colspan="14">
                    <asp:Label Text="Customer Master" runat="server" Font-Bold="True" Font-Size="Larger" />
                </td>
            </tr>
            <tr>
                <td style="width: 81px">
                    <asp:Button ID="btnSave" runat="server" Text="Save" Width="80px" OnClick="BtnSave" />
                </td>
                <td>
                    <asp:Button ID="BtnUpdateb" runat="server" Text="Update" Width="80px" OnClick="BtnUpdate" />
                </td>
                <td>
                    <asp:Button ID="BtnDeleteB" runat="server" Text="Delete" Width="80px" OnClick="BtnDelete" />
                </td>
                <td>
                    <asp:Button ID="BtnPrint" runat="server" Text="Print" Width="80px" />
                </td>
                <td style="width: 49px">&nbsp;</td>
                <td>
                    <asp:Button ID="BtnFirst" runat="server" Text="First" Width="80px" />
                </td>
                <td>
                    <asp:Button ID="BtnPrevious" runat="server" Text="Previous" Width="80px" />
                </td>
                <td>
                    <asp:Button ID="BtnNext" runat="server" Text="Next" Width="80px" />
                </td>
                <td>
                    <asp:Button ID="BtnLast" runat="server" Text="Last" Width="80px" />
                </td>
                <td style="width: 49px">&nbsp;</td>
                <td>
                    <asp:Button ID="BtnSearch" runat="server" Text="Search" Width="80px" OnClick="BtnSearch_Click" />
                </td>
                <td>
                    <asp:Button ID="BtnViewAll" runat="server" Text="ViewAll" Width="80px" />
                </td>
                <td>
                    <asp:Button ID="BtnSClear" runat="server" Text="Clear" Width="80px" OnClick="BtnClear" />
                </td>
                <td>
                    <asp:Button ID="BtnSBack" runat="server" Text="Back" Width="80px" OnClick="BtnBack" />
                </td>
            </tr>
            </table>


        <table class="auto-style1" style="width: 98%">
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Search Order" Font-Bold="True"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Customer Id:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TbxSearchCustomerID" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="C.Name:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TbxSearchCName" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="C.N.I.C:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TbxSearchCNIC" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="Cell#:"></asp:Label>
                </td>
                <td style="width: 90px">
                    <asp:TextBox ID="TbxSearchCellNo" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
           
        <table class="auto-style1" style="width: 97%">
            <tr>
                <td colspan="9">
                    <asp:Label ID="Label10" runat="server" Font-Bold="True" Text="Personal Information"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label14" runat="server" Text="Customer Id:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TbxCustomerId" runat="server" Enabled="False"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label15" runat="server" Text="Customer Name:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TbxCustomerName" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label16" runat="server" Text="Father Name:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DdnListFatherName" runat="server" Height="23px" style="margin-left: 0px" Width="137px">
                        <asp:ListItem>Select Item</asp:ListItem>
                        <asp:ListItem>S/O</asp:ListItem>
                        <asp:ListItem>D/O</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:TextBox ID="TbxFatherName" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label17" runat="server" Text="D.O.B:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TbxDOB" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label18" runat="server" Text="C.N.I.C:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TbxCNIC" PlaceHolder="00000-0000000-0"  runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label19" runat="server" Text="HPA Sales:"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="TbxHPASales" runat="server" Width="227px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="9" style="height: 23px">
                    <asp:Label ID="Label11" runat="server" Font-Bold="True" Text="Contact Information"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label20" runat="server" Text="Residential #:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TbxResidentialNo" PlaceHolder="000-00000000"  runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label21" runat="server" Text="Office #:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TbxOfficeNo" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label22" runat="server" Text="Cell #:"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="TbxCellNo1" PlaceHolder="0000-0000000"  runat="server" Width="227px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label23" runat="server" Text="Driver #:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TbxDriverNo" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label24" runat="server" Text="Email Address:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TbxEmailAddress" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label25" runat="server" Text="H Address:"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="TbxHomeAddress" runat="server" Width="227px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="9">
                    <asp:Label ID="Label12" runat="server" Font-Bold="True" Text="Offical  Information"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="height: 26px">
                    <asp:Label ID="Label26" runat="server" Text="N.T.N #:"></asp:Label>
                </td>
                <td style="height: 26px">
                    <asp:TextBox ID="TbxNTNNo" runat="server"></asp:TextBox>
                </td>
                <td style="height: 26px">
                    <asp:Label ID="Label27" runat="server" Text="Customer Type:"></asp:Label>
                </td>
                <td style="height: 26px">
                    <asp:DropDownList ID="DdnListCustomerType" runat="server" Height="23px" style="margin-left: 0px" Width="137px">
                        <asp:ListItem>Select Item</asp:ListItem>
                        <asp:ListItem>Cash</asp:ListItem>
                        <asp:ListItem>Credit</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="height: 26px">
                    <asp:Label ID="Label28" runat="server" Text="Recovery By:"></asp:Label>
                </td>
                <td colspan="2" style="height: 26px">
                    <asp:TextBox ID="TbxRecdoveryBy" runat="server" Width="227px"></asp:TextBox>
                </td>
                <td style="height: 26px"></td>
                <td style="height: 26px"></td>
            </tr>
            <tr>
                <td colspan="9">
                    <asp:Label ID="Label13" runat="server" Font-Bold="True" Text="Other Information"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label29" runat="server" Text="Inserted By:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TbxInsertedBy" runat="server" Width="128px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Label ID="Label30" runat="server" Text="Updated By:"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="TbxUpdatedBy" runat="server" Width="227px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
               <td>
                
             </td>
            
            </tr>

        </table>

      <div style="width: 100%; height: 215px; overflow-y: scroll">
        <asp:GridView ID="GirdViewdiv" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" CssClass="custom-tab" DataSourceID="SqlDataSource1" Height="50px">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="firstName" HeaderText="firstName" SortExpression="firstName" />
                <asp:BoundField DataField="surName" HeaderText="surName" SortExpression="surName" />
                <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                <asp:BoundField DataField="emailAddress" HeaderText="emailAddress" SortExpression="emailAddress" />
                <asp:BoundField DataField="homeAddress" HeaderText="homeAddress" SortExpression="homeAddress" />
                <asp:BoundField DataField="CellNumber" HeaderText="CellNumber" SortExpression="CellNumber" />
                <asp:BoundField DataField="dob" HeaderText="dob" SortExpression="dob" />
                <asp:BoundField DataField="gender" HeaderText="gender" SortExpression="gender" />
            </Columns>
         
        </asp:GridView>
      </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KarachiMotorsConnectionString %>" SelectCommand="SELECT * FROM [UserAccountDetails]"></asp:SqlDataSource>

  </div>
    
</asp:Content>

