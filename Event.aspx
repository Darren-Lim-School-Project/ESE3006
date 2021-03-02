<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Event.aspx.cs" Inherits="Event" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            height: 23px;
        }
        .style3
        {
            height: 23px;
            width: 387px;
        }
        .style4
        {
            width: 387px;
        }
        .style5
        {
            height: 23px;
            width: 257px;
        }
        .style6
        {
            width: 257px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<h1><b>Event</b></h1>

<center>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <table class="body">
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style3">
                </td>
                <td class="style2">
                    Search:</td>
            </tr>
            <tr>
                <td class="style6">
                    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                    </asp:ToolkitScriptManager>
                </td>
                <td class="style4">
                    Events:</td>
                <td>
                    <asp:TextBox ID="txtSearch" runat="server" style="margin-bottom: 0px"></asp:TextBox>
                    <asp:AutoCompleteExtender ID="txtSearch_AutoCompleteExtender" runat="server"
                     
                        ServiceMethod="GetNameList" DelimiterCharacters="" Enabled="True" ServicePath=""
TargetControlID="txtSearch" MinimumPrefixLength="1">
                    </asp:AutoCompleteExtender>
                    <br />
                    <asp:RequiredFieldValidator ID="rfvSearchEvent" runat="server" 
                        ControlToValidate="txtSearch" 
                        ErrorMessage="Please enter something before entering"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Button ID="btnGi" runat="server" onclick="btnGi_Click" 
                        Text="Search Event" />
                </td>
            </tr>
            <tr>
                <td class="style6">
                    &nbsp;</td>
                <td class="style4">
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
            GridLines="None">
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
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
</p>
    <p>
&nbsp;&nbsp;&nbsp;
</p>
    <p>
        &nbsp;</p>
</center>

</asp:Content>

