<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h1><b>Home</b></h1>
    
    <center>
    <p>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <b>
        <asp:Image ID="Image1" runat="server" Height="259px" Width="721px" />
        <asp:SlideShowExtender ID="Image1_SlideShowExtender" runat="server" 
            AutoPlay="True" Enabled="True" Loop="True" PlayInterval="5000" 
            SlideShowServiceMethod="GetSlides" SlideShowServicePath="" 
            TargetControlID="Image1" UseContextKey="True">
        </asp:SlideShowExtender>
        </b>
    </p>
        <h3 class="section_head1" 
            style="margin: 0px 20px 9px 0px; padding: 0px; border: 0px; outline: 0px; font-weight: bold; font-style: normal; font-size: 14px; font-family: Helvetica, Arial, sans-serif; vertical-align: baseline; line-height: 18px; color: rgb(51, 51, 51); font-variant-ligatures: normal; font-variant-caps: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255);">
            Key facts</h3>
        <ul class="disc" 
            style="margin: 0px 20px 18px 0px; padding: 0px; border: 0px; outline: 0px; font-weight: normal; font-style: normal; font-size: 13px; font-family: Helvetica, Arial, sans-serif; vertical-align: baseline; list-style: none outside; color: rgb(51, 51, 51); font-variant-ligatures: normal; font-variant-caps: normal; letter-spacing: normal; line-height: 13px; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255);">
            <li style="border-style: none; border-color: inherit; border-width: 0px; margin: 0px; padding: 2px 0px 1px 18px; outline: 0px; font-weight: inherit; font-style: inherit; font-size: 13px; font-family: inherit; vertical-align: baseline; line-height: 15px; background-image: url('http://www.who.int/mediacentre/factsheets/img/list.gif'); background-position: left 0.5em; background-repeat: no-repeat;">
                5.9 million children under the age of 5 years died in 2015.</li>
            <li style="border-style: none; border-color: inherit; border-width: 0px; margin: 0px; padding: 2px 0px 1px 18px; outline: 0px; font-weight: inherit; font-style: inherit; font-size: 13px; font-family: inherit; vertical-align: baseline; line-height: 15px; background-image: url('http://www.who.int/mediacentre/factsheets/img/list.gif'); background-position: left 0.5em; background-repeat: no-repeat;">
                More than half of these early child deaths are due to conditions that could be 
                prevented or treated with access to simple, affordable interventions.</li>
            <li style="border-style: none; border-color: inherit; border-width: 0px; margin: 0px; padding: 2px 0px 1px 18px; outline: 0px; font-weight: inherit; font-style: inherit; font-size: 13px; font-family: inherit; vertical-align: baseline; line-height: 15px; background-image: url('http://www.who.int/mediacentre/factsheets/img/list.gif'); background-position: left 0.5em; background-repeat: no-repeat;">
                Leading causes of death in children under 5 years are preterm birth 
                complications, pneumonia, birth asphyxia, diarrhoea and malaria. About 45% of 
                all child deaths are linked to malnutrition.</li>
            <li style="border-style: none; border-color: inherit; border-width: 0px; margin: 0px; padding: 2px 0px 1px 18px; outline: 0px; font-weight: inherit; font-style: inherit; font-size: 13px; font-family: inherit; vertical-align: baseline; line-height: 15px; background-image: url('http://www.who.int/mediacentre/factsheets/img/list.gif'); background-position: left 0.5em; background-repeat: no-repeat;">
                Children in sub-Saharan Africa are more than 14 times more likely to die before 
                the age of 5 than children in developed regions.</li>
        </ul>
        <p>
            LEARN MORE IN OUR FAQ.....</p>
        <p>
            &nbsp;</p>
    </center>

</asp:Content>

