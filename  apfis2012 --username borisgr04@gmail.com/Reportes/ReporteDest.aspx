<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="ReporteDest.aspx.vb" Inherits="Reportes_ReporteDest" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 359px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table style="width:100%;">
                <tr>
                    <td>
                        &nbsp;</td>
                    <td class="style1">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Fecha Inicial"></asp:Label>
                    </td>
                    <td class="style1">
                        <asp:Label ID="Label2" runat="server" Text="Fecha Final"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Estado"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TxtFI" runat="server"></asp:TextBox>
                        <ajaxToolkit:CalendarExtender ID="FI" runat="server" Format="dd/MM/yyyy" 
                            TargetControlID="TxtFI">
                        </ajaxToolkit:CalendarExtender>
                    </td>
                    <td class="style1">
                        <asp:TextBox ID="TxtFF" runat="server"></asp:TextBox>
                        <ajaxToolkit:CalendarExtender ID="FF" runat="server" Format="dd/MM/yyyy" 
                            TargetControlID="TxtFF">
                        </ajaxToolkit:CalendarExtender>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjEstados" 
                            DataTextField="Des_Est" DataValueField="Cod_Est">
                        </asp:DropDownList>
                        <asp:ObjectDataSource ID="ObjEstados" runat="server" 
                            OldValuesParameterFormatString="original_{0}" SelectMethod="GetRecords" 
                            TypeName="Estados"></asp:ObjectDataSource>
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Filtrar" />
                    </td>
                </tr>
            </table>
            <br />
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" 
                Font-Size="8pt" InteractiveDeviceInfos="(Collection)" 
                WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="935px">
                <LocalReport ReportPath="Rpt\Rpt_Dest.rdlc">
                    <DataSources>
                        <rsweb:ReportDataSource DataSourceId="ObjActas" Name="DataSet1" />
                    </DataSources>
                </LocalReport>
            </rsweb:ReportViewer>
            <br />
            <asp:ObjectDataSource ID="ObjActas" runat="server" 
                OldValuesParameterFormatString="original_{0}" SelectMethod="GetbyEst" 
                TypeName="Actas">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TxtFI" Name="FI" PropertyName="Text" 
                        Type="DateTime" />
                    <asp:ControlParameter ControlID="TxtFF" Name="FF" PropertyName="Text" 
                        Type="DateTime" />
                    <asp:ControlParameter ControlID="DropDownList1" Name="Estado" 
                        PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

