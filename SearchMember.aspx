<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="SearchMember.aspx.cs" Inherits="SearchMember" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style2
        {
            height: 137px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1>
        <b>Search Member 
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </h1>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table class="body">
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                    <center>
                        <asp:Label ID="lblTips" runat="server" 
                            Text="Tips: Enter &quot;VIEW ALL&quot; to see all members"></asp:Label>
                        <br />
                        <asp:Label ID="lblFirstName" runat="server" Text="Search First Name:"></asp:Label>
                        <asp:TextBox ID="txtSearchName" runat="server"></asp:TextBox>
                        <br />
                        <asp:Button ID="btnSearchMember" runat="server" OnClick="btnSearchMember_Click" 
                            Text="Search First Name" />
                            <b>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvSearchMember" runat="server" 
                            ControlToValidate="txtSearchName" 
                            ErrorMessage="Please enter the user first name"></asp:RequiredFieldValidator>
                        </b>
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
                        <asp:GridView ID="gvFirstName" runat="server">
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
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                    <center>
                        <asp:DropDownList ID="ddlGender" runat="server" AutoPostBack="True">
                            <asp:ListItem Value="Male">Male</asp:ListItem>
                            <asp:ListItem Value="Female">Female</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <asp:Button ID="btnSearchGender" runat="server" CausesValidation="False" 
                            onclick="btnSearchGender_Click" Text="Search Gender" />
                            </center>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style2">
                        </td>
                    <td class="style2">
                    <center>
                        <asp:GridView ID="gvGender" runat="server">
                        </asp:GridView>
                        </center>
                    </td>
                    <td class="style2">
                        </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
    <br />
    </asp:Content>
