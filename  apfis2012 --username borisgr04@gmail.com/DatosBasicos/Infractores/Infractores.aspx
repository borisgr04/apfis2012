<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Infractores.aspx.vb" Inherits="DatosBasicos_Infractores_Default
" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="demoarea">
        <asp:UpdatePanel id="UpdatePanel1" runat="server">
        <contenttemplate>
&nbsp;<asp:Label id="Tit" runat="server" Width="286px" CssClass="Titulo" 
                Text="iNFRACTORES"></asp:Label><BR /><asp:Label id="MsgResult" 
                runat="server" SkinID="MsgResult"></asp:Label>&nbsp;&nbsp;&nbsp;<BR />&nbsp;<asp:GridView 
                id="GridView1" runat="server" Width="500px" ForeColor="#333333" 
                AllowSorting="True" 
                DataSourceID="ObjTipos" GridLines="None" CellPadding="4" ShowFooter="True" 
                OnRowCommand="GridView1_RowCommand" DataKeyNames="Ced_Inf" 
                AutoGenerateColumns="False" 
                OnSelectedIndexChanged="GridView1_SelectedIndexChanged" 
                EmptyDataText="No se encontraron Registros en la Base de Datos" 
                EnableModelValidation="True" AllowPaging="True" PageSize="20">
<RowStyle BackColor="#F7F6F3" ForeColor="#333333"></RowStyle>
<Columns>
<asp:TemplateField HeaderText="Cedula" SortExpression="Ced_Inf"><FooterTemplate>
<asp:LinkButton id="lnkNuevo" runat="server" Text="Nuevo Registro" __designer:wfdid="w10" CausesValidation="False" CommandName="Nuevo"></asp:LinkButton> 
</FooterTemplate>
<ItemTemplate>
<asp:Label id="LbCod" runat="server" Text='<%# Bind("Ced_Inf") %>' __designer:wfdid="w9"></asp:Label> 
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="Primer Apellido" SortExpression="Ape1_Inf"><ItemTemplate>
<asp:Label id="Lbcimp" runat="server" Text='<%# Bind("Ape1_Inf") %>' __designer:wfdid="w21"></asp:Label> 
</ItemTemplate>
</asp:TemplateField>
    <asp:BoundField DataField="Ape2_Inf" HeaderText="Segundo Apellido" 
        SortExpression="Ape2_Inf" />
    <asp:BoundField DataField="Nom_Inf" HeaderText="Nombres" 
        SortExpression="Nom_Inf" />
    <asp:BoundField DataField="Exp_Ced_Inf" HeaderText="Expedida en" 
        SortExpression="Exp_Ced_Inf" />
    <asp:BoundField DataField="Dir_Inf" HeaderText="Direccion" 
        SortExpression="Dir_Inf" />
    <asp:BoundField DataField="Tel_Inf" HeaderText="Telefono" 
        SortExpression="Tel_Inf" />
    <asp:BoundField DataField="Cor_Inf" DataFormatString="{0:c}" 
        HeaderText="Correo" SortExpression="Cor_Inf" >
    <ItemStyle Width="150px" />
    </asp:BoundField>
    <asp:ButtonField CommandName="Eliminar" ImageUrl="~/images/Operaciones/delete2.png" Text="Eliminar" ButtonType="Image"></asp:ButtonField>
<asp:ButtonField CommandName="Editar" ImageUrl="~/images/Operaciones/Edit2.png" Text="Editar" ButtonType="Image"></asp:ButtonField>
<asp:CommandField SelectImageUrl="~/images/Operaciones/Select.png" ShowSelectButton="True" ButtonType="Image"></asp:CommandField>
</Columns>

<FooterStyle BackColor="White" Font-Bold="True" ForeColor="#5D7B9D"></FooterStyle>

<PagerStyle HorizontalAlign="Center" BackColor="#284775" ForeColor="White"></PagerStyle>

<SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

<HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></HeaderStyle>

<EditRowStyle BackColor="#999999"></EditRowStyle>

<AlternatingRowStyle BackColor="White" ForeColor="#284775"></AlternatingRowStyle>
</asp:GridView> 
            <asp:ObjectDataSource id="ObjTipos" runat="server" TypeName="Infractores" 
                SelectMethod="GetRecords" OldValuesParameterFormatString="original_{0}">
            </asp:ObjectDataSource><!-- <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></FooterStyle>-->
</contenttemplate>
    </asp:UpdatePanel>&nbsp;
    <asp:UpdatePanel id="UpdatePanel2"
        runat="server" UpdateMode="Conditional"><contenttemplate>
<!-- Mensaje de Salida--><BR /><asp:Button style="DISPLAY: none" id="hiddenTargetControlForModalPopup2" runat="server"></asp:Button> <ajaxToolkit:ModalPopupExtender id="ModalPopupTer" runat="server" PopupDragHandleControlID="programmaticPopupDragHandle2" PopupControlID="programmaticPopup2" DropShadow="True" BackgroundCssClass="modalBackground" BehaviorID="programmaticModalPopupBehavior2" RepositionMode="RepositionOnWindowScroll" TargetControlID="hiddenTargetControlForModalPopup2">
            </ajaxToolkit:ModalPopupExtender>&nbsp;&nbsp; 
            <asp:Panel id="programmaticPopup2" runat="server" Width="462px" Height="553px" 
                CssClass="ModalPanel2">
                <asp:Panel id="programmaticPopupDragHandle2" 
                    runat="Server" Width="463px" Height="30px" CssClass="BarTitleModal2"><DIV style="PADDING-RIGHT: 5px; PADDING-LEFT: 5px; PADDING-BOTTOM: 5px; VERTICAL-ALIGN: middle; PADDING-TOP: 5px"><DIV style="FLOAT: left">
                            Infractores...</DIV><DIV style="FLOAT: right">
                            <INPUT id="BtnCerrar" type=button value="X" /></DIV></DIV></asp:Panel>
                &nbsp;<asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>
                        <TABLE>
                            <tbody>
                                <tr>
                                    <td colspan="3">
                                        <asp:Label ID="SubT" runat="server" CssClass="SubTitulo" Text="Nuevo"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="3">
                                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                                            SkinID="ValidationSummary1" ValidationGroup="Guardar" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style3">
                                        <asp:Label ID="Label4" runat="server" __designer:wfdid="w19" Text="Cedula" 
                                            Width="143px"></asp:Label>
                                    </td>
                                    <td style="WIDTH: 100px">
                                        <asp:TextBox ID="TxtCed" runat="server" Width="200px"></asp:TextBox>
                                        <ajaxToolkit:FilteredTextBoxExtender runat="server" ID="FilteredTextBoxExtender1" FilterType="Numbers" TargetControlID="TxtCed"></ajaxToolkit:FilteredTextBoxExtender>
                                    </td>
                                    <td style="WIDTH: 100px">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                            ControlToValidate="TxtCed" ErrorMessage="Digite  la Cedula" 
                                            ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style3">
                                        <asp:Label ID="Label12" runat="server" Text="Expedida en" Width="126px"></asp:Label>
                                    </td>
                                    <td style="WIDTH: 100px; ">
                                        <asp:TextBox ID="TxtExp" runat="server" Width="200px"></asp:TextBox>
                                    </td>
                                    <td style="WIDTH: 100px; ">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style3">
                                        <asp:Label ID="Label1" runat="server" Text="Primer Apellido" Width="126px"></asp:Label>
                                    </td>
                                    <td style="WIDTH: 100px; ">
                                        <asp:TextBox ID="TxtApe1" runat="server" Width="200px"></asp:TextBox>
                                    </td>
                                    <td style="WIDTH: 100px; ">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                            ControlToValidate="TxtApe1" ErrorMessage="Digite el Primer Apellido" 
                                            ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style3">
                                        <asp:Label ID="Label10" runat="server" Text="Segundo Apellido" Width="126px"></asp:Label>
                                    </td>
                                    <td style="WIDTH: 100px; ">
                                        <asp:TextBox ID="TxtApe2" runat="server" Width="200px"></asp:TextBox>
                                    </td>
                                    <td style="WIDTH: 100px; ">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                            ControlToValidate="TxtNom" ErrorMessage="Digite el Nombre" 
                                            ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style2">
                                        <asp:Label ID="Label11" runat="server" Text="Nombres" Width="126px"></asp:Label>
                                    </td>
                                    <td style="WIDTH: 100px; height: 23px;">
                                        <asp:TextBox ID="TxtNom" runat="server" Width="200px"></asp:TextBox>
                                    </td>
                                    <td style="WIDTH: 100px; height: 23px;">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style3">
                                        <asp:Label ID="Label5" runat="server" Text="Direccion" Width="126px"></asp:Label>
                                    </td>
                                    <td style="WIDTH: 100px">
                                        <asp:TextBox ID="TxtDir" runat="server" Width="200px"></asp:TextBox>
                                    </td>
                                    <td style="WIDTH: 100px">
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style3">
                                        <asp:Label ID="Label6" runat="server" Text="Telefono" Width="126px"></asp:Label>
                                    </td>
                                    <td style="WIDTH: 100px">
                                        <asp:TextBox ID="TxtTel" runat="server" Width="200px"></asp:TextBox>
                                        <ajaxToolkit:FilteredTextBoxExtender runat="server" ID="F1" FilterType="Numbers" TargetControlID="TxtTel"></ajaxToolkit:FilteredTextBoxExtender>
                                    </td>
                                    <td style="WIDTH: 100px">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="style3">
                                        <asp:Label ID="Label7" runat="server" Text="Correo" 
                                            Width="126px"></asp:Label>
                                    </td>
                                    <td style="WIDTH: 100px">
                                        <asp:TextBox ID="TxtCor" runat="server" Width="200px"></asp:TextBox>
                                    </td>
                                    <td style="WIDTH: 100px">
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                            ControlToValidate="TxtCor" 
                                            ErrorMessage="El correo debe tener la forma nombre@dominio.com" 
                                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                            ValidationGroup="Guardar">*</asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style3">
                                        &nbsp;</td>
                                    <td style="WIDTH: 100px">
                                        &nbsp;</td>
                                    <td style="WIDTH: 100px">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="3" style="TEXT-ALIGN: center">
                                        <asp:Button ID="BtnGuardar" runat="server" onclick="BtnGuardar_Click" 
                                            Text="Guardar" ValidationGroup="Guardar" />
                                        &nbsp;<asp:Button ID="BtnEliminar" runat="server" onclick="BtnEliminar_Click" 
                                            Text="Eliminar" />
                                        &nbsp;
                                        <asp:Button ID="Button1" runat="server" Text="Cancelar" />
                                        &nbsp;</td>
                                </tr>
                            </tbody>
                        </TABLE>
                    </ContentTemplate>
                </asp:UpdatePanel>
                &nbsp;</asp:Panel>&nbsp;&nbsp; 
</contenttemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="BtnGuardar" EventName="Click" />
            <asp:AsyncPostBackTrigger ControlID="BtnEliminar" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>

    &nbsp;&nbsp;&nbsp;&nbsp;
        <script language="javascript" type="text/javascript">
// <![CDATA[

            function BtnCancelar_onclick() {

            }

// ]]>
        </script>
</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .style2
        {
            height: 23px;
            width: 978px;
        }
        .style3
        {
            width: 978px;
        }
    </style>
</asp:Content>


