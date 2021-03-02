<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EventStatus.aspx.cs" Inherits="EventStatus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

<script type = "text/javascript">
    function Confirm() {
        var confirm_value = document.createElement("INPUT");
        confirm_value.tyoe = "hidden";
        confirm_value.name = "confirm_value";

        if (confirm("Are you sure with your choice?" + "\nDecline an event will delete the event")) {
            confirm_value.value = "Yes";
        } else {
            confirm_value.value = "No";
        }
        document.forms[0].appendChild(confirm_value);
    }
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <h1><b>
    Event Status
    </b></h1>
    <table class="body">
        <tr>
            <td>
                &nbsp;</td>
            <td>
            <center>
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
                <asp:DropDownList ID="ddlEvent" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="ddlEvent_SelectedIndexChanged" Visible="False">
                </asp:DropDownList>
                </center>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
            <center>
                <asp:GridView ID="gvEvent" runat="server" Visible="False">
                </asp:GridView>
                <asp:DropDownList ID="ddlApprove" runat="server" Visible="False">
                    <asp:ListItem Value="1">Approve</asp:ListItem>
                    <asp:ListItem Value="0">Decline</asp:ListItem>
                </asp:DropDownList>
                </center>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
            <center>
                <asp:Button ID="btnSubmitEV" runat="server" onclientclick="Confirm();" 
                    Text="Submit" onclick="btnSubmitEV_Click" Visible="False" />
                </center>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

