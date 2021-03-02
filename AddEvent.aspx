<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddEvent.aspx.cs" Inherits="AddEvent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<h1>
<b>
Add Event
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
</b>
</h1>
    <table class="body">
        <tr>
            <td>
                Event Name:</td>
            <td>
                <asp:TextBox ID="txtEventName" runat="server" Width="250px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Event Start Date:</td>
            <td>
                <asp:UpdatePanel ID="upEventStartDate" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="txtEventStartDate" runat="server" Enabled="False"></asp:TextBox>
                        <asp:Calendar ID="cldEventStartDate" runat="server" 
                            onselectionchanged="Calendar1_SelectionChanged"></asp:Calendar>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td>
                Event End Date:</td>
            <td>
                <asp:UpdatePanel ID="upEventEndDate" runat="server">
                    <ContentTemplate>
                        <asp:TextBox ID="txtEventEndDate" runat="server" Enabled="False"></asp:TextBox>
                        <asp:Calendar ID="cldEventEndDate" runat="server" 
                            onselectionchanged="Calendar2_SelectionChanged"></asp:Calendar>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </td>
        </tr>
        <tr>
            <td>
                Description:</td>
            <td>
                <asp:TextBox ID="txtDescription" runat="server" Height="53px" TextMode="MultiLine" 
                    Width="249px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                URL:</td>
            <td>
                <asp:TextBox ID="txtURL" runat="server" Width="246px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
                    onclick="btnSubmit_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

