<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ACP.aspx.cs" Inherits="ACP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<h1><b>Admin's Control Panel</b></h1>
    <center>
        <p>
            <asp:Button ID="btnSearchMember" runat="server" onclick="btnSearchMember_Click" 
                Text="Search Member" />
    </p>
        <p>
            <asp:Button ID="btnSearchEvent" runat="server" Text="Disable Event" 
                onclick="btnSearchEvent_Click" />
    </p>
        <p>
        <asp:Button ID="btnEventStatus" runat="server" Text="Pending Event" 
            onclick="btnEventStatus_Click" style="margin-left: 0px" />
    </p>
        </center>
</asp:Content>

