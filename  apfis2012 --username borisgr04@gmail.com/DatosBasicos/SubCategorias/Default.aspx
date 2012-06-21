<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="DatosBasicos_Categorias_Default" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server" 
    EnableTheming="True">
</telerik:RadScriptManager>
        
    <telerik:RadComboBox ID="RadComboBox1" Runat="server">
        <Items>
            <telerik:RadComboBoxItem runat="server" Text="RadComboBoxItem1" 
                Value="RadComboBoxItem1" />
            <telerik:RadComboBoxItem runat="server" Text="RadComboBoxItem2" 
                Value="RadComboBoxItem2" />
            <telerik:RadComboBoxItem runat="server" Text="RadComboBoxItem3" 
                Value="RadComboBoxItem3" />
            <telerik:RadComboBoxItem runat="server" Text="RadComboBoxItem4" 
                Value="RadComboBoxItem4" />
            <telerik:RadComboBoxItem runat="server" Text="RadComboBoxItem5" 
                Value="RadComboBoxItem5" />
            <telerik:RadComboBoxItem runat="server" Text="RadComboBoxItem6" 
                Value="RadComboBoxItem6" />
            <telerik:RadComboBoxItem runat="server" Text="RadComboBoxItem7" 
                Value="RadComboBoxItem7" />
        </Items>
    </telerik:RadComboBox>
</asp:Content>

