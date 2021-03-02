<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Donate.aspx.cs" Inherits="Donate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="font-family: Arial, Helvetica, sans-serif; font-size: 18pt; font-weight: bold; font-style: italic">
    Donate</p>
    <center>
<p style="font-family: Arial, Helvetica, sans-serif; font-size: 18pt; font-weight: bold; font-style: italic">

    
    &nbsp;</p>
        <table class="body">
            <tr>
                <td>
                    &nbsp;</td>
                <td>

    
    <asp:Label ID="lblEventSel" runat="server" Text="Select the event to donate:"></asp:Label>
    <asp:DropDownList ID="ddlEventSel" runat="server" AutoPostBack="True" 
        onselectedindexchanged="ddlEventSel_SelectedIndexChanged">
    </asp:DropDownList>
    
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                <center>
            <asp:GridView ID="gvEvent" runat="server" CellPadding="4" ForeColor="#333333" 
                GridLines="None" Width="274px">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            </center>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
            <asp:Label ID="lblDonate" runat="server" 
                Text="Key in the amount you want to donate:"></asp:Label>
                    <br />
                    $<asp:TextBox ID="txtDonate" runat="server"></asp:TextBox>
                    <br />
                    <asp:RangeValidator ID="rfvValue" runat="server" ControlToValidate="txtDonate" 
                        ErrorMessage="Incorrect value! Donation bigger than S$1,000,000 , please contact the administrator." 
                        MaximumValue="1000000" MinimumValue="1" Type="Currency"></asp:RangeValidator>
                    <br />
            <asp:Button ID="btnDonate" runat="server" onclick="btnDonate_Click" 
                Text="Donate" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
</center>
</asp:Content>

