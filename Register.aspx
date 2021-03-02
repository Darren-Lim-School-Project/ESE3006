<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style2
    {
        height: 23px;
    }
    .style3
    {
        height: 30px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h1><b>Registration<asp:ScriptManager ID="ScriptManager2" runat="server">
        </asp:ScriptManager>
        </b></h1>
    
    <table class="body">
    <tr>
        <td>
            Username:</td>
        <td>
            <asp:TextBox ID="txtUsername" runat="server" MaxLength="30"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvUsername" runat="server" 
                ControlToValidate="txtUsername" ErrorMessage="Username is required!"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            Password:</td>
        <td>
            <asp:TextBox ID="txtPassword" runat="server" MaxLength="30" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" 
                ControlToValidate="txtPassword" ErrorMessage="Password is required!"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style3">
            Confirm Password:</td>
        <td class="style3">
            <asp:TextBox ID="txtConfirmPassword" runat="server" MaxLength="30" 
                TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvConfirmPassword" runat="server" 
                ControlToValidate="txtConfirmPassword" 
                ErrorMessage="Confirm Password is required!"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="cvConfirmPassword" runat="server" 
                ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" 
                ErrorMessage="Password is not matched!"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td>
            First Name:</td>
        <td>
            <asp:TextBox ID="txtFirstName" runat="server" MaxLength="20"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" 
                ControlToValidate="txtFirstName" ErrorMessage="First name is required!"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            Last Name:</td>
        <td>
            <asp:TextBox ID="txtLastName" runat="server" MaxLength="20"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvLastName" runat="server" 
                ControlToValidate="txtLastName" ErrorMessage="Last name is required!"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            Email:</td>
        <td>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" 
                ControlToValidate="txtEmail" ErrorMessage="Email is required!"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style2">
            Gender:</td>
        <td class="style2">
            <asp:RadioButtonList ID="rbGender" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator ID="rfvGender" runat="server" 
                ControlToValidate="rbGender" ErrorMessage="Gender is required!"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            Birth Date:</td>
        <td>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:TextBox ID="txtCalendar" runat="server" Enabled="False" 
                        ontextchanged="txtCalendar_TextChanged"></asp:TextBox>
                    <asp:Calendar ID="cldBirthDate" runat="server" 
                        onselectionchanged="cldBirthDate_SelectionChanged"></asp:Calendar>
                    <asp:RequiredFieldValidator ID="rfvBirthDate" runat="server" 
                        ControlToValidate="txtCalendar" ErrorMessage="Birth Date is required!"></asp:RequiredFieldValidator>
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
    <tr>
        <td>
            Address:</td>
        <td>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvAddress" runat="server" 
                ControlToValidate="txtAddress" ErrorMessage="Address is required!"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            Postal Code:</td>
        <td>
            <asp:TextBox ID="txtPostalCode" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPostalCode" runat="server" 
                ControlToValidate="txtPostalCode" ErrorMessage="Postal Code is required!"></asp:RequiredFieldValidator>
            <br />
            <asp:RangeValidator ID="RangeValidator1" runat="server" 
                ControlToValidate="txtPostalCode" ErrorMessage="Invalid Postal Code" 
                MaximumValue="999999" MinimumValue="100000" Type="Integer"></asp:RangeValidator>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <asp:Button ID="btnRegister" runat="server" Text="Register" 
                onclick="btnRegister_Click" />
            <br />
            <br />
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>

