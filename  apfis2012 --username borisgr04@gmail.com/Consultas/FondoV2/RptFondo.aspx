<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="RptFondo.aspx.vb" Inherits="Consultas_FondoV2_RptFondo" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="demoarea">

    <ajaxToolkit:ToolkitScriptManager ID="ScriptManager1" runat="Server" EnableScriptGlobalization="true"
        EnableScriptLocalization="true">
    </ajaxToolkit:ToolkitScriptManager>       

     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                           <ContentTemplate>
                               <table>
                                   <tr>
                                       <td colspan="11" style="height: 20px; text-align: center;">
                                           &nbsp;</td>
                                   </tr>
                                   <tr>
                                       <td colspan="11" style="height: 20px; text-align: center;">
                                           <strong>CONSULTA DE APREHENSIONES </strong>
                                       </td>
                                   </tr>
                                   <tr>
                                       <td >
                                           &nbsp;</td>
                                       <td >
                                           &nbsp;</td>
                                       <td >
                                           &nbsp;</td>
                                       <td >
                                           &nbsp;</td>
                                       <td >
                                           &nbsp;</td>
                                       <td >
                                           &nbsp;</td>
                                       <td >
                                           &nbsp;</td>
                                       <td >
                                           &nbsp;</td>
                                       <td >
                                           &nbsp;</td>
                                       <td >
                                           &nbsp;</td>
                                       <td >
                                           &nbsp;</td>
                                   </tr>
                                   <tr>
                                       <td >
                                           &nbsp;</td>
                                       <td >
                                       </td>
                                       <td colspan="2">
                                           Fecha Inicial</td>
                                       <td >
                                           <asp:TextBox ID="txtfecini" runat="server"></asp:TextBox>
                                       </td>
                                       <td >
                                           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                               ControlToValidate="txtfecini" ErrorMessage="Se requiere Fecha Inicial">*</asp:RequiredFieldValidator>
                                       </td>
                                       <td >
                                           Fecha Final</td>
                                       <td >
                                           <asp:TextBox ID="TxtFecFin" runat="server"></asp:TextBox>
                                       </td>
                                       <td >
                                           <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                               ControlToValidate="TxtFecFin" ErrorMessage="Se requiere Fecha Final">*</asp:RequiredFieldValidator>
                                           <asp:ImageButton ID="ImgBtnBuscar" runat="server" 
                                               ImageUrl="~/images/search4.png" OnClick="ImageButton1_Click" 
                                               ToolTip="Consulte sus pagos en linea" />
                                       </td>
                                       <td >
                                           <asp:ImageButton ID="IBtnExcel" runat="server" Height="33px" 
                                               ImageUrl="~/images/excel2007.gif" Width="39px" />
                                       </td>
                                       <td >
                                       </td>
                                   </tr>
                                   
                               </table>
                               <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                               &nbsp;&nbsp;<rsweb:ReportViewer ID="ReportViewer2" runat="server" 
                                   Font-Names="Verdana" Font-Size="8pt" InteractiveDeviceInfos="(Collection)" 
                                   WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="900px">
                                   <LocalReport ReportPath="Rpt\ReportFNDV02.rdlc">
                                       <DataSources>
                                           <rsweb:ReportDataSource DataSourceId="ObjFnd" Name="DSFondo" />
                                       </DataSources>
                                   </LocalReport>
                               </rsweb:ReportViewer>
                               <asp:ObjectDataSource ID="ObjFnd" runat="server" 
                                   OldValuesParameterFormatString="original_{0}" SelectMethod="GetFondoV2" 
                                   TypeName="ConActas">
                                   <SelectParameters>
                                       <asp:ControlParameter ControlID="txtfecini" Name="fecha_ini" 
                                           PropertyName="Text" Type="DateTime" />
                                       <asp:ControlParameter ControlID="TxtFecFin" Name="fecha_fin" 
                                           PropertyName="Text" Type="DateTime" />
                                   </SelectParameters>
                               </asp:ObjectDataSource>
                               <br />
                               &nbsp;<br />
                            </ContentTemplate>
                           <Triggers>
                               <asp:PostBackTrigger ControlID="IBtnExcel" />
                           </Triggers>
                       </asp:UpdatePanel>
                        <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
            <ProgressTemplate>
                <div class="Loading">
                    <img alt="" src="../images/loading.gif" title="" />
                    Cargando …
                </div>
            </ProgressTemplate>
        </asp:UpdateProgress>
        <br />
</div>
<div style="z-index: 101; left: 0px; visibility: hidden; overflow: auto; width: 100px;
            position: absolute; top: 0px; height: 100px">
             <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" 
        Font-Size="8pt" Height="400px" Width="400px">
        <LocalReport ReportPath="Rpt\ReportFNDV02.rdlc">
        </LocalReport>
             </rsweb:ReportViewer>
    </div>

</asp:Content>

