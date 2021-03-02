<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UCP.aspx.cs" Inherits="UCP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <h1><b>User's Control Panel</b></h1>
    <p>Welcome
        <asp:Label ID="lblName" runat="server"></asp:Label>
        ! Last logged in: 
        <asp:Label ID="lblTime" runat="server"></asp:Label>
    </p>

    <center>
    <p>
        <asp:Button ID="btnEditProfile" runat="server" Text="Edit Profile" 
            PostBackUrl="~/EditProfile.aspx" />
    </p>
        <p>
            <asp:Button ID="btnDonateHistory" runat="server" onclick="btnDonateHistory_Click" 
                Text="Donate History" />
    </p>
    <p>
        <asp:Button ID="btnAddEvent" runat="server" Text="Add Event" 
            PostBackUrl="~/AddEvent.aspx" />
    </p>
        <p>
            <asp:Button ID="btnLogout" runat="server" onclick="btnLogout_Click" 
                Text="Logout" Visible="False" />
    </p>
    </center>



</asp:Content>

