<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EditProfile.aspx.cs" Inherits="EditProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<h1>
<b>
Edit Profile
</b>
</h1>
    <table class="body">
        <tr>
            <td>
                Username:</td>
            <td>
                <asp:TextBox ID="txtUsername" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                First Name:</td>
            <td>
                <asp:TextBox ID="txtFirstName" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Last Name:</td>
            <td>
                <asp:TextBox ID="txtLastName" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Email:</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Address:</td>
            <td>
                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Postal Code:</td>
            <td>
                <asp:TextBox ID="txtPostalCode" runat="server"></asp:TextBox>
                <asp:RangeValidator ID="rfvPostalCode" runat="server" 
                    ControlToValidate="txtPostalCode" ErrorMessage="Invalid Postal Code!" 
                    MaximumValue="999999" MinimumValue="000000"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
                <br />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" 
                    onclick="btnUpdate_Click" />
            </td>
        </tr>
    </table>

</asp:Content>

