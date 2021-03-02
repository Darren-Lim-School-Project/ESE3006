<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="DisableEvent.aspx.cs" Inherits="SearchEvent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1>
        <b>Disable Event </b>
    </h1>
    <table class="body">
        <tr>
            <center>
                <td>
                    &nbsp;
                </td>
                <td>
                    <center>
                        <asp:Label ID="lblEvent" runat="server" Text="Select an active event to be disabled"></asp:Label>
                        <br />
                        <asp:DropDownList ID="ddlEvents" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlEvents_SelectedIndexChanged">
                        </asp:DropDownList>
                    &nbsp;<asp:Button ID="btnListAllEvent" runat="server" 
                            OnClick="btnListAllEvent_Click" Text="List all Events" />
                    </center>
                </td>
                <td>
                    &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                <center>
                    <asp:GridView ID="gvEvent" runat="server">
                    </asp:GridView>
                    <asp:Button ID="btnDelete" runat="server" Text="Disable Event" 
                        onclick="btnDisable_Click" />
                </center>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
</asp:Content>
