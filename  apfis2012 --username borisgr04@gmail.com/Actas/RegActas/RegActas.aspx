<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="RegActas.aspx.vb" Inherits="Actas_RegActas" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register src="../../CtrlUsr/AdmTercero/AdmTercero.ascx" tagname="admtercero" tagprefix="uc3" %>
<%@ Register src="../../CtrlUsr/Entidad/ConsultaEnt.ascx" tagname="ConsultaEnt" tagprefix="uc1" %>
<%@ Register src="../../CtrlUsr/Entidad/AdmEntidad.ascx" tagname="AdmEntidad" tagprefix="uc2" %>
<%@ Register src="../../CtrlUsr/Productos/AdmProductos.ascx" tagname="AdmProductos" tagprefix="uc4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link href="../App_Themes/BlueTheme/cssactas.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style2
        {
            width: 170px;
        }
        .style3
        {
            width: 28px;
        }
        .style4
        {
            width: 295px;
        }
        .style5
        {
            height: 32px;
        }
        .style7
        {
            width: 412px;
        }
        .style8
        {
            width: 204px;
        }
        .style9
        {
            height: 19px;
        }
        .style10
        {
            width: 34px;
        }
        .style11
        {
            width: 95px;
        }
        .style13
        {
            height: 19px;
            width: 251px;
        }
        .style14
        {
            width: 251px;
        }
        .style15
        {
            width: 162px;
        }
        .style16
        {
            width: 253px;
        }
        .style17
        {
            width: 128px;
        }
        .style19
        {
            width: 149px;
        }
        .style21
        {
            width: 20px;
        }
        .style22
        {
            width: 143px;
        }
        .style23
        {
            width: 52px;
        }
        .style24
        {
            width: 53px;
        }
        .style25
        {
            width: 62px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" CssClass="Titulo" 
        Text="Registro de Actas de Aprehensión"></asp:Label>
    <br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table style="width: 41%;">
                <tr>
                    <td class="style21">
                        &nbsp;</td>
                    <td class="style22">
                        &nbsp;</td>
                    <td class="style23">
                        &nbsp;</td>
                    <td class="style23">
                        &nbsp;</td>
                    <td class="style24">
                        &nbsp;</td>
                    <td class="style25">
                        &nbsp;</td>
                    <td class="style25">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style21">
                        <asp:ImageButton ID="BtnNuevo" runat="server" Height="32px" 
                            ImageUrl="~/images/Operaciones/New.png" Width="32px" />
                    </td>
                    <td class="style22">
                        <asp:TextBox ID="TxtNumActaI" runat="server" AutoPostBack="True"></asp:TextBox>
                    </td>
                    <td class="style23">
                        <asp:ImageButton ID="BtnAbrir0" runat="server" Height="32px" 
                            ImageUrl="~/images/Operaciones/Search.png" Width="32px" 
                            SkinID="IBtnBuscar" />
                    </td>
                    <td class="style23">
                        <asp:ImageButton ID="BtnAbrir" runat="server" Height="32px" 
                            ImageUrl="~/images/Operaciones/Utilizadas/open-icon48.png" Width="32px" />
                    </td>
                    <td class="style24">
                        <asp:ImageButton ID="BtnEdit" runat="server" Height="32px" 
                            ImageUrl="~/images/Operaciones/Edit2.png" Width="32px" />
                    </td>
                    <td class="style25">
                        <asp:ImageButton ID="BtnGuardar" runat="server" Height="32px" Width="32px" 
                            SkinID="IBtnGuardar" ValidationGroup="Guardar" Visible="False" />
                    </td>
                    <td class="style25">
                        <asp:ImageButton ID="BtnAnu" runat="server" Height="32px" 
                            ImageUrl="~/images/Operaciones/Delete.png" Width="32px" />
                    </td>
                    <td>
                        <asp:ImageButton ID="BtnCancel" runat="server" Height="32px" 
                            ImageUrl="~/images/Operaciones/Deshacer.png" Width="32px" />
                    </td>
                </tr>
                <tr>
                    <td class="style21">
                        &nbsp;</td>
                    <td class="style22">
                        &nbsp;</td>
                    <td class="style23">
                        Buscar</td>
                    <td class="style23">
                        Abrir</td>
                    <td class="style24">
                        Editar</td>
                    <td class="style25">
                        <asp:Label ID="LbGuar" runat="server" Text="Guardar" Visible="False"></asp:Label>
                    </td>
                    <td class="style25">
                        Anular</td>
                    <td>
                        Cancelar</td>
                </tr>
            </table>
            <asp:Label ID="MsgResult" runat="server" SkinID="MsgResult"></asp:Label>
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                SkinID="ValidationSummary1" ValidationGroup="Guardar" />
            <table border="0" align="center" cellpadding="3" cellspacing="1" class="tableActa" width="100%">
                <tr>
                    <th bgcolor="#999999" class="style5" colspan="8">
                        DATOS GENERALES</th>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="ACTA Nº(*)"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="FECHA INICIAL(*)"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="FECHA FINAL(*)"></asp:Label>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="FACTURA Nº"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="OTRO DOCUMENTO"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TxtNumActa" runat="server" Height="19px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                            ControlToValidate="TxtNumActa" ErrorMessage="Debe Escribir el Numero de Acta" 
                            ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <telerik:RadDatePicker ID="DtFi" Runat="server" Height="19px">
                            <Calendar UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" 
                                ViewSelectorText="x">
                            </Calendar>
                            <DateInput DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MM/yyyy" Height="19px">
                            </DateInput>
                            <DatePopupButton HoverImageUrl="" ImageUrl="" />
                        </telerik:RadDatePicker>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                            ControlToValidate="DtFi" 
                            ErrorMessage="Debe Seleccionar o Escribir la Fecha Inicial" 
                            ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <telerik:RadDatePicker ID="DTFf" Runat="server" Height="19px">
                            <Calendar UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" 
                                ViewSelectorText="x">
                            </Calendar>
                            <DateInput DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MM/yyyy" Height="19px">
                            </DateInput>
                            <DatePopupButton HoverImageUrl="" ImageUrl="" />
                        </telerik:RadDatePicker>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                            ControlToValidate="DTFf" 
                            ErrorMessage="Debe Seleccionar o Escribir la Fecha Final" 
                            ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtFact" runat="server" Height="19px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtOtro" runat="server" Height="19px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <table border="0" align="center" cellpadding="3" cellspacing="1" class="tableActa" width="100%">
                <tr>
                    <th bgcolor="#999999" colspan="3" class="style5">
                        LUGAR DE APRHENSIÓN Y DESTINO DE PRODUCTOS</th>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="MUNICIPIO APREHENSIÓN(*)"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label8" runat="server" Text="MUNICIPIO DESTINO(*)"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="BODEGA DESTINO(*)"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="CmbMunOri" runat="server" DataSourceID="ObjMun" 
                            DataTextField="Nom_Mun" DataValueField="Cod_Mun" Height="22px">
                        </asp:DropDownList>
                        <asp:ObjectDataSource ID="ObjMun" runat="server" 
                            OldValuesParameterFormatString="original_{0}" SelectMethod="GetRecords" 
                            TypeName="Municipios"></asp:ObjectDataSource>
                    </td>
                    <td>
                        <asp:DropDownList ID="CmbMunDes" runat="server" AutoPostBack="True" 
                            DataSourceID="ObjMun" DataTextField="Nom_Mun" DataValueField="Cod_Mun" 
                            Height="22px">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:DropDownList ID="CmbBodDes" runat="server" DataSourceID="ObjBod" 
                            DataTextField="Nom_Bod" DataValueField="Cod_Bod" Height="22px">
                        </asp:DropDownList>
                        <asp:ObjectDataSource ID="ObjBod" runat="server" DeleteMethod="Delete" 
                            InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
                            SelectMethod="GetbyMun" TypeName="Bodegas" UpdateMethod="Update">
                            <DeleteParameters>
                                <asp:Parameter Name="Cod_Bod" Type="String" />
                            </DeleteParameters>
                            <InsertParameters>
                                <asp:Parameter Name="Nom_Est" Type="String" />
                                <asp:Parameter Name="Dir_Est" Type="String" />
                                <asp:Parameter Name="Nit_Est" Type="String" />
                                <asp:Parameter Name="Tel_Est" Type="String" />
                                <asp:Parameter Name="Cor_Est" Type="String" />
                                <asp:Parameter Name="Cod_mun" Type="String" />
                                <asp:Parameter Name="Est_Bod" Type="String" />
                            </InsertParameters>
                            <SelectParameters>
                                <asp:ControlParameter ControlID="CmbMunDes" Name="Cod_Mun" 
                                    PropertyName="SelectedValue" Type="String" />
                            </SelectParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="Nom_Est" Type="String" />
                                <asp:Parameter Name="Dir_Est" Type="String" />
                                <asp:Parameter Name="Nit_Est" Type="String" />
                                <asp:Parameter Name="Tel_Est" Type="String" />
                                <asp:Parameter Name="Cor_Est" Type="String" />
                                <asp:Parameter Name="cod_mun" Type="String" />
                                <asp:Parameter Name="Est_Bod" Type="String" />
                                <asp:Parameter Name="Original_Nit" Type="String" />
                            </UpdateParameters>
                        </asp:ObjectDataSource>
                    </td>
                </tr>
            </table>
            <br />
            <table border="0" align="center" cellpadding="3" cellspacing="1" class="tableActa" width="100%">
                <tr>
                    <th bgcolor="#999999" colspan="4" class="style5">
                        ESTABLECIMIENTO</th>
                </tr>
                <tr>
                    <td class="style2">
                        <asp:Label ID="Label10" runat="server" Text="IDENTIFICACIÓN(*)"></asp:Label>
                    </td>
                    <td class="style3">
                        &nbsp;</th>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="TxtIdEst" 
                            ErrorMessage="Debe Seleccionar o Escribir la Identificación del Representante de Bodega" 
                            ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
                    <td class="style4">
                        <asp:Label ID="Label11" runat="server" Text="NOMBRE"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label12" runat="server" Text="DIRECCIÓN"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <asp:TextBox ID="TxtIdEst" runat="server" Height="19px" AutoPostBack="True"></asp:TextBox>
                    </td>
                    <td class="style3">
                        <asp:Button ID="BtnBuscEst" runat="server" Text="..." />
                    </td>
                    <td class="style4">
                        <asp:TextBox ID="TxtNomEst" runat="server" Height="19px" Width="293px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtDirEst" runat="server" Height="19px" Width="293px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <table border="0" align="center" cellpadding="3" cellspacing="1" class="tableActa" width="100%">
                <tr>
                    <th bgcolor="#999999" class="style5" colspan="4">
                        INFRACTOR O RESPONSABLE</th>
                </tr>
                <tr>
                    <td class="style11">
                        <asp:Label ID="Label13" runat="server" Text="CC(*)"></asp:Label>
                    </td>
                    <td class="style10">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="TxtCedInf" 
                            ErrorMessage="Debe Seleccionar o Escribir la Identificación del Infractor" 
                            ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="style4">
                        <asp:Label ID="Label14" runat="server" Text="EXPEDIDA EN"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label15" runat="server" Text="APELLIDOS Y NOMBRES"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style11">
                        <asp:TextBox ID="TxtCedInf" runat="server" Height="19px" AutoPostBack="True"></asp:TextBox>
                    </td>
                    <td class="style10">
                        <asp:Button ID="BtnBuscInf" runat="server" Height="22px" Text="..." />
                    </td>
                    <td class="style4">
                        <asp:TextBox ID="TxtExpInf" runat="server" Height="19px" Width="293px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtNomInf" runat="server" Height="19px" Width="293px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style11">
                        <asp:Label ID="Label16" runat="server" Text="DIRECCIÓN"></asp:Label>
                    </td>
                    <td class="style10">
                        &nbsp;</td>
                    <td class="style4">
                        <asp:Label ID="Label17" runat="server" Text="TÉLEFONO"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label18" runat="server" Text="CORREO ELECTRÓNICO"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style11">
                        <asp:TextBox ID="TxtDirInf" runat="server" Height="19px"></asp:TextBox>
                    </td>
                    <td class="style10">
                        &nbsp;</td>
                    <td class="style4">
                        <asp:TextBox ID="TxtTelInf" runat="server" Height="19px" Width="293px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtCorInf" runat="server" Height="19px" Width="293px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <table border="0" align="center" cellpadding="3" cellspacing="1" class="tableActa" width="100%">
                <tr>
                    <th bgcolor="#999999" class="style5" colspan="3">
                        OTROS DATOS</th>
                </tr>
                <tr>
                    <td class="style7">
                        <asp:Label ID="Label19" runat="server" Text="EXPLICACION DE LA APRHENSiÓN"></asp:Label>
                    </td>
                    <td class="style8">
                        <asp:Label ID="Label20" runat="server" Text="FACTURA DE COMPRA Nº"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label21" runat="server" Text="Nº DE FOLIOS"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style7" rowspan="5">
                        <asp:TextBox ID="TxtExpl" runat="server" Height="150px" TextMode="MultiLine" 
                            Width="410px"></asp:TextBox>
                    </td>
                    <td class="style8">
                        <asp:TextBox ID="TxtFacCom" runat="server" Height="19px" Width="164px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtNumFolioFac" runat="server" Height="19px" Width="164px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style8">
                        <asp:Label ID="Label23" runat="server" Text="MANIFIESTO DE CARGA Nº"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label24" runat="server" Text="Nº DE FOLIOS"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style8">
                        <asp:TextBox ID="TxtManCar" runat="server" Height="19px" Width="164px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtNumFolioMarcar" runat="server" Height="19px" Width="164px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style8">
                        <asp:Label ID="Label25" runat="server" Text="OTROS Nº"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label26" runat="server" Text="Nº DE FOLIOS"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style8">
                        <asp:TextBox ID="TxtOtros" runat="server" Height="19px" Width="164px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtNumFolOtros" runat="server" Height="19px" Width="164px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <table border="0" align="center" cellpadding="3" cellspacing="1" class="tableActa" width="100%">
   <tr>
     <th bgcolor="#999999" class="style5" colspan="5">
                        REGISTRO DE LAS FIRMAS</th>
   </tr>
   <tr>
    <td colspan="5">EN CONSTANCIA SE FIRMA UNA VEZ NOTIFICADA PERSONALMENTE
        <asp:RadioButton ID="Rb1" runat="server" Checked="True" GroupName="Firma" />
        &nbsp;O
        <asp:RadioButton ID="Rb2" runat="server" GroupName="1" />
        CON TESTIGO&nbsp; POR QUIENES EN ELLA INTERVIERON</td>
    </tr>
  <tr>
    <td><div align="center"></div></td>
    <td class="style14">
        <asp:Label ID="Label38" runat="server" Text="COORDINADOR GRUPO OPERATIVO"></asp:Label>
      </td>
      <td>
          &nbsp;</td>
    <td>
        <asp:Label ID="Label27" runat="server" Text="CC"></asp:Label>
      </td>
    <td>
        <asp:Label ID="Label31" runat="server" Text="DIRECCIÓN"></asp:Label>
      </td>
    </tr>
  <tr>
    <td><div align="center">
        <asp:CheckBox ID="ChkCoor" runat="server" />
        &nbsp;</div></td>
    <td class="style14">        
        <asp:TextBox ID="TxtNomCG" runat="server" Height="22px" Width="250px"></asp:TextBox>
      </td>
      <td>
          <asp:Button ID="BtnBuscCoor" runat="server" Text="..." />
      </td>
      <td>
          <telerik:RadNumericTextBox ID="TxtCedCG" Runat="server" 
              Culture="es-CO" DataType="System.String">
              <NumberFormat DecimalDigits="0" DecimalSeparator="." />
          </telerik:RadNumericTextBox>
      </td>
    <td>
        <asp:TextBox ID="TxtDirCG" runat="server" Height="22px" Width="250px"></asp:TextBox>
      </td>
    </tr>
  <tr>
    <td><div align="center"></div></td>
    <td class="style14">
        <asp:Label ID="Label37" runat="server" Text="INFRACTOR"></asp:Label>
      </td>
      <td>
          &nbsp;</td>
    <td>
        <asp:Label ID="Label28" runat="server" Text="CC"></asp:Label>
      </td>
    <td>
        <asp:Label ID="Label32" runat="server" Text="DIRECCIÓN"></asp:Label>
      </td>
    </tr>
  <tr>
    <td>
      <div align="center">
          <asp:CheckBox ID="ChkInf" runat="server" />
          &nbsp;</div></td>
    <td class="style14">
        <asp:TextBox ID="TxtNomInfFir" runat="server" Height="22px" Width="250px"></asp:TextBox>
      </td>
      <td>
          <asp:Button ID="BtnBuscInf1" runat="server" Text="..." />
      </td>
    <td>
        <telerik:RadNumericTextBox ID="TxtCedInfFir" Runat="server" 
            Culture="es-CO" DataType="System.String" AutoPostBack="True">
            <NumberFormat DecimalDigits="0" DecimalSeparator="." />
        </telerik:RadNumericTextBox>
      </td>
    <td>
        <asp:TextBox ID="TxtDirInfFir" runat="server" Height="22px" Width="250px"></asp:TextBox>
      </td>
    </tr>
  <tr>
    <td class="style9"><div align="center"></div></td>
    <td class="style13">
        <asp:Label ID="Label36" runat="server" 
            Text="REPRESENTANTE AUTORIDAD QUE RETUVO"></asp:Label>
      </td>
      <td class="style9">
          &nbsp;</td>
    <td class="style9">
        <asp:Label ID="Label29" runat="server" Text="CC"></asp:Label>
      </td>
    <td class="style9">
        <asp:Label ID="Label33" runat="server" Text="DIRECCIÓN"></asp:Label>
      </td>
    </tr>
  <tr>
    <td>
      <div align="center">
          <asp:CheckBox ID="ChkRA" runat="server" />
          &nbsp;</div></td>
    <td class="style14">
        <asp:TextBox ID="TxtNomRA" runat="server" Height="22px" Width="250px"></asp:TextBox>
      </td>
      <td>
          <asp:Button ID="BtnBuscRA" runat="server" Text="..." />
      </td>
    <td>
        <telerik:RadNumericTextBox ID="TxtCedRA" Runat="server" 
            Culture="es-CO" DataType="System.String">
            <NumberFormat DecimalDigits="0" DecimalSeparator="." />
        </telerik:RadNumericTextBox>
      </td>
    <td>
        <asp:TextBox ID="TxtDirRA" runat="server" Height="22px" Width="250px"></asp:TextBox>
      </td></tr>
  <tr>
    <td><div align="center"></div></td>
    <td class="style14">
        <asp:Label ID="Label35" runat="server" 
            Text="REPRESENTANTE BODEGA QUE RECIBE(*)"></asp:Label>
      </td>
      <td>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
              ControlToValidate="TxtCedRB" 
              ErrorMessage="Debe Seleccionar o Escribir la Identificación del Representante de Bodega" 
              ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
      </td>
    <td>
        <asp:Label ID="Label30" runat="server" Text="CC"></asp:Label>
      </td>
    <td>
        <asp:Label ID="Label34" runat="server" Text="DIRECCIÓN"></asp:Label>
      </td>
    </tr>
  <tr>
    <td><div align="center">
        <asp:CheckBox ID="ChkRB" runat="server" />
        &nbsp;</div></td>
    <td class="style14">
        <asp:TextBox ID="TxtNomRB" runat="server" Height="22px" Width="250px"></asp:TextBox>
      </td>
      <td>
          <asp:Button ID="BtnBuscRB" runat="server" Text="..." />
      </td>
    <td>
        <telerik:RadNumericTextBox ID="TxtCedRB" Runat="server" 
            Culture="es-CO" DataType="System.String">
            <NumberFormat DecimalDigits="0" DecimalSeparator="." />
        </telerik:RadNumericTextBox>
      </td>
    <td>
        <asp:TextBox ID="TXTDirRB" runat="server" Height="22px" Width="250px"></asp:TextBox>
      </td>
    </tr>
  <tr>
    <td colspan="5"><div align="left"><strong>Nota: </strong>Los Campos con <strong>(*)</strong> son Requeridos </div></td>
    </tr>
  <tr>
    <td colspan="5"><div align="right">
        &nbsp;<asp:Button ID="BtnSig" runat="server" Text="Siguiente&gt;&gt;" 
            ValidationGroup="Guardar" />
    </div></td>
  </tr>
   
    </table>
            
            <br />
            
        </ContentTemplate>
    </asp:UpdatePanel>
     <ajaxToolkit:ModalPopupExtender ID="ModalPopup" runat="server" 
                            BackgroundCssClass="modalBackground" 
                            BehaviorID="programmaticModalPopupBehavior" DropShadow="True" 
                            PopupControlID="programmaticPopup" 
                            PopupDragHandleControlID="programmaticPopupDragHandle" 
                            RepositionMode="RepositionOnWindowScroll" TargetControlID="Button8">
                        </ajaxToolkit:ModalPopupExtender>
    <asp:Button style="DISPLAY: none" id="Button8" runat="server"></asp:Button>
            <asp:UpdatePanel ID="UdpProd" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Panel ID="Panel1" runat="server" Visible="False">
                        <table align="center" border="0" cellpadding="3" cellspacing="1" 
                            class="tableActa" width="100%">
                            <tr>
                                <th bgcolor="#999999" class="style5" colspan="6">
                                    REGISTRO DE PRODUCTOS</th>
                                <th bgcolor="#999999" class="style5">
                                    &nbsp;</th>
                            </tr>
                            <tr>
                                <td align="left" colspan="5">
                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                        CellPadding="4" DataKeyNames="NroActa,Codigo" DataSourceID="ObjProd" 
                                        EmptyDataText="No se han registrado productos" EnableModelValidation="True" 
                                        ForeColor="#333333" GridLines="None" Width="523px">
                                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                        <Columns>
                                            <asp:BoundField DataField="Codigo" HeaderText="Código" />
                                            <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
                                            <asp:BoundField DataField="Unidades" HeaderText="Cantidad" />
                                            <asp:BoundField DataField="PrecioUnit" HeaderText="Valor Unitario" />
                                            <asp:BoundField DataField="Val_Par" DataFormatString="{0:c}" 
                                                HeaderText="Valor Parcial" />
                                            <asp:ButtonField ButtonType="Image" CommandName="Editar" 
                                                ImageUrl="~/images/Operaciones/Edit2.png" Text="Editar" />
                                            <asp:ButtonField ButtonType="Image" CommandName="Eliminar" 
                                                ImageUrl="~/images/Operaciones/delete2.png" Text="Eliminar" />
                                        </Columns>
                                        <EditRowStyle BackColor="#999999" />
                                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    </asp:GridView>
                                    <asp:ObjectDataSource ID="ObjProd" runat="server" 
                                        OldValuesParameterFormatString="original_{0}" SelectMethod="GetbyActa" 
                                        TypeName="ProdActas">
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="TxtNumActa" Name="NumActa" PropertyName="Text" 
                                                Type="String" />
                                        </SelectParameters>
                                    </asp:ObjectDataSource>
                                </td>
                                <td align="left" class="style19">
                                    &nbsp;</td>
                                <td align="left">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td align="left" colspan="5">
                                    <asp:Label ID="MsgResultProd" runat="server" SkinID="MsgResult"></asp:Label>
                            <br />
                                    <asp:ValidationSummary ID="ValidationSummary2" runat="server" 
                                        SkinID="ValidationSummary1" ValidationGroup="GuardarProd" />
                                </td>
                                <td align="left" class="style19">
                                    &nbsp;</td>
                                <td align="left">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <div align="center">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                            ControlToValidate="TxtCodProd" 
                                            ErrorMessage="Digite o Seleccione el Código del producto" 
                                            ValidationGroup="GuardarProd">*</asp:RequiredFieldValidator>
                                    </div>
                                </td>
                                <td class="style15">
                                    <asp:Label ID="Label39" runat="server" Text="CÓDIGO"></asp:Label>
                                </td>
                                <td>
                                    &nbsp;</td>
                                <td class="style16">
                                    DESCRIPCIÓN</td>
                                <td class="style17">
                                    CANTIDAD<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                        ControlToValidate="TxtCanProd" ErrorMessage="Digite la Cantidad" 
                                        ValidationGroup="GuardarProd">*</asp:RequiredFieldValidator>
                                </td>
                                <td class="style19">
                                    VALOR<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                        ControlToValidate="TxtValProd" ErrorMessage="Digite el Valor" 
                                        ValidationGroup="GuardarProd">*</asp:RequiredFieldValidator>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;</td>
                                <td class="style15">
                                    <asp:TextBox ID="TxtCodProd" runat="server" AutoPostBack="True" Height="21px" 
                                        Width="179px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Button ID="Button16" runat="server" Text="..." />
                                </td>
                                <td class="style16">
                                    <asp:TextBox ID="TxtDesProd" runat="server" Height="22px" Width="250px"></asp:TextBox>
                                </td>
                                <td class="style17">
                                    <telerik:RadNumericTextBox ID="TxtCanProd" Runat="server" Culture="es-CO" 
                                        DataType="System.Int16">
                                        <NumberFormat DecimalDigits="0" DecimalSeparator="." />
                                    </telerik:RadNumericTextBox>
                                </td>
                                <td class="style19">
                                    <telerik:RadNumericTextBox ID="TxtValProd" Runat="server" Culture="es-CO" 
                                        DataType="System.Decimal" Type="Currency" Width="125px">
                                        <NumberFormat DecimalDigits="0" DecimalSeparator="." />
                                    </telerik:RadNumericTextBox>
                                </td>
                                <td>
                                    <asp:ImageButton ID="BtnGuardarProd" runat="server" Height="32px" 
                                        ImageUrl="~/images/Operaciones/Add.png" ToolTip="Agregar Producto" 
                                        ValidationGroup="GuardarProd" Width="32px" />
                                </td>
                            </tr>
                            <tr>
                                <td colspan="5">
                                    <div align="right">
                                        &nbsp;</div>
                                </td>
                                <td align="right" class="style19">
                                    &nbsp;</td>
                                <td align="right">
                                    <asp:Button ID="BtnConf" runat="server" Text="Confirmar" 
                                        ValidationGroup="Guardar" />
                                    <ajaxToolkit:ConfirmButtonExtender ID="Cb1" runat="server" 
                                        ConfirmText="Al confirmar el acta afectara el inventario. ¿Realmente desea confirmar el Acta?" 
                                        TargetControlID="BtnConf">
                                    </ajaxToolkit:ConfirmButtonExtender>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </ContentTemplate>
    </asp:UpdatePanel>
            <br />
    <br />
            <asp:Panel id="programmaticPopup" runat="server" Width="800px" Height="600px" CssClass="ModalPanel2" ScrollBars="Auto" >
            <asp:Panel id="programmaticPopupDragHandle" runat="Server" Width="100%" 
                    Height="33px" CssClass="BarTitleModal2" >
            <DIV style="PADDING-RIGHT: 5px; PADDING-LEFT: 5px; PADDING-BOTTOM: 5px; VERTICAL-ALIGN: middle; PADDING-TOP: 5px">
            <DIV style="FLOAT: left">
                Buscar Tercero </DIV>
             <DIV style="FLOAT: right" __designer:dtid="1407383473487880"  >
                 <asp:Button ID="Button9" runat="server" Text="X" />
                </DIV></DIV></asp:Panel>
                <panel id="pnCuadroInterno" runat="Server" ScrollBars="Auto" >
                    <uc3:AdmTercero ID="AdmTercero1" runat="server" />
                    <BR />
                </panel>
              </asp:Panel>
    <br />
    <ajaxToolkit:ModalPopupExtender 
    ID="ModalPopupExtender1" 
    runat="server"
    BehaviorID="programmaticModalPopupBehavior1" 
    DropShadow="true" 
    BackgroundCssClass="modalBackground"
    PopupControlID="programmaticPopup1" 
    PopupDragHandleControlID="programmaticPopupDragHandle" 
    RepositionMode="RepositionOnWindowScroll" 
    TargetControlID="BntPopup">
    </ajaxToolkit:ModalPopupExtender>
                        <asp:Button style="DISPLAY: none" id="BntPopup" runat="server"></asp:Button>
            <asp:Panel id="programmaticPopup1" runat="server" Width="800px" 
        Height="600px" CssClass="ModalPanel2" ScrollBars="Auto" >
            <asp:Panel id="programmaticPopupDragHandle0" runat="Server" Width="100%" 
                    Height="33px" CssClass="BarTitleModal2" >
            <DIV style="PADDING-RIGHT: 5px; PADDING-LEFT: 5px; PADDING-BOTTOM: 5px; VERTICAL-ALIGN: middle; PADDING-TOP: 5px">
            <DIV style="FLOAT: left">
                Buscar Establecimientos </DIV>
             <DIV style="FLOAT: right" __designer:dtid="1407383473487880"  >
                 <asp:Button ID="Button10" runat="server" Text="X" />
                </DIV></DIV></asp:Panel>
                <uc2:AdmEntidad ID="AdmEntidad1" runat="server" />
              </asp:Panel>
    <br />
    <ajaxToolkit:ModalPopupExtender 
    ID="ModalPopupExtender2" 
    runat="server"
    BehaviorID="programmaticModalPopupBehavior2" 
    DropShadow="true" 
    BackgroundCssClass="modalBackground"
    PopupControlID="programmaticPopup2" 
    PopupDragHandleControlID="programmaticPopupDragHandle1" 
    RepositionMode="RepositionOnWindowScroll" 
    TargetControlID="BntPopup1">
    </ajaxToolkit:ModalPopupExtender>
                        <asp:Button style="DISPLAY: none" id="BntPopup1" runat="server"></asp:Button>
            <asp:Panel id="programmaticPopup2" runat="server" Width="797px" 
        Height="600px" CssClass="ModalPanel2" ScrollBars="Auto" >
            <asp:Panel id="programmaticPopupDragHandle1" runat="Server" Width="100%" 
                    Height="33px" CssClass="BarTitleModal2" >
            <DIV style="PADDING-RIGHT: 5px; PADDING-LEFT: 5px; PADDING-BOTTOM: 5px; VERTICAL-ALIGN: middle; PADDING-TOP: 5px">
            <DIV style="FLOAT: left">
                Buscar Productos&nbsp; </DIV>
                <DIV style="FLOAT: right" __designer:dtid="1407383473487880"  >
                 <asp:Button ID="Button7" runat="server" Text="X" />
                </DIV>
                </DIV></asp:Panel>
                <uc4:AdmProductos ID="AdmProductos1" runat="server" />
             </asp:Panel>
    <br />
</asp:Content>

