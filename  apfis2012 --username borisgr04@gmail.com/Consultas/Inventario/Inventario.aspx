<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Inventario.aspx.vb" Inherits="Consultas_Inventario_Inventario" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="demoarea">
  <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" runat="Server" EnableScriptGlobalization="true"
        EnableScriptLocalization="true">
    </ajaxToolkit:ToolkitScriptManager> 
    <table style="width: 79%">
        <tr>
            <td style="width: 95px">
                &nbsp;</td>
            <td style="width: 147px">
                &nbsp;</td>
            <td style="width: 108px">
                &nbsp;</td>
            <td style="width: 217px">
                &nbsp;</td>
            <td style="width: 94px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 95px">
                Fecha Inicial</td>
            <td style="width: 147px">
                <asp:TextBox ID="TxtF1" runat="server"></asp:TextBox>
            </td>
            <td style="width: 108px">
                Fecha Final</td>
            <td style="width: 217px">
                <asp:TextBox ID="TxtFf" runat="server"></asp:TextBox>
            </td>
            <td style="width: 94px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 95px">
                Producto</td>
            <td style="width: 147px">
                <asp:TextBox ID="TxtProd" runat="server"></asp:TextBox>
            </td>
            <td style="width: 108px">
                &nbsp;</td>
            <td style="width: 217px">
                <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" />
            </td>
            <td style="width: 94px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <br />
    <rsweb:ReportViewer ID="ReportViewer2" runat="server" Font-Names="Verdana" 
        Font-Size="8pt" InteractiveDeviceInfos="(Collection)" 
        WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%">
        <LocalReport ReportPath="Rpt\RptInv.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="ObjInvRpt" Name="DataSet1" />
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>
    <asp:ObjectDataSource ID="ObjInv" runat="server" SelectMethod="GetInventario" 
        TypeName="ConActas">
        <SelectParameters>
            <asp:ControlParameter ControlID="TxtF1" Name="fecha_ini" PropertyName="Text" />
            <asp:ControlParameter ControlID="TxtFf" Name="fecha_fin" PropertyName="Text" />
            <asp:ControlParameter ControlID="TxtProd" Name="Prod" PropertyName="Text" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <br />


    <asp:ObjectDataSource ID="ObjInvRpt" runat="server" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetInventarioRpt" 
        TypeName="ConActas">
        <SelectParameters>
            <asp:ControlParameter ControlID="TxtF1" Name="fecha_ini" PropertyName="Text" 
                Type="String" />
            <asp:ControlParameter ControlID="TxtFf" Name="fecha_fin" PropertyName="Text" 
                Type="String" />
            <asp:ControlParameter ControlID="TxtProd" Name="prod" PropertyName="Text" 
                Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>


</div>
</asp:Content>

