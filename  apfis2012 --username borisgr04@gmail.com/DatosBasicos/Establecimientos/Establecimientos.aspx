<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Establecimientos.aspx.vb" Inherits="DatosBasicos_Establecimientos_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="demoarea">
        <asp:UpdatePanel id="UpdatePanel1" runat="server">
        <contenttemplate>
&nbsp;<asp:Label id="Tit" runat="server" Width="286px" CssClass="Titulo" 
                Text="ESTABLECIMIENTOS"></asp:Label><BR /><asp:Label id="MsgResult" 
                runat="server" SkinID="MsgResult"></asp:Label>&nbsp;&nbsp;&nbsp;<BR />&nbsp;<asp:GridView 
                id="GridView1" runat="server" Width="500px" ForeColor="#333333" 
                AllowSorting="True" 
                DataSourceID="ObjTipos" GridLines="None" CellPadding="4" ShowFooter="True" 
                OnRowCommand="GridView1_RowCommand" DataKeyNames="Nit_Est" 
                AutoGenerateColumns="False" 
                OnSelectedIndexChanged="GridView1_SelectedIndexChanged" 
                EmptyDataText="No se encontraron Registros en la Base de Datos" 
                EnableModelValidation="True">
<RowStyle BackColor="#F7F6F3" ForeColor="#333333"></RowStyle>
<Columns>
<asp:TemplateField HeaderText="NIT" SortExpression="Nit_Est"><FooterTemplate>
<asp:LinkButton id="lnkNuevo" runat="server" Text="Nuevo Registro" __designer:wfdid="w10" CausesValidation="False" CommandName="Nuevo"></asp:LinkButton> 
</FooterTemplate>
<ItemTemplate>
<asp:Label id="LbCod" runat="server" Text='<%# Bind("Nit_Est") %>' __designer:wfdid="w9"></asp:Label> 
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="Nombre" SortExpression="Nom_Est"><ItemTemplate>
<asp:Label id="Lbcimp" runat="server" Text='<%# Bind("Nom_Est") %>' __designer:wfdid="w21"></asp:Label> 
</ItemTemplate>
</asp:TemplateField>
    <asp:BoundField DataField="Dir_Est" HeaderText="Dirección" 
        SortExpression="Dir_Est" />
    <asp:BoundField DataField="Tel_Est" HeaderText="Télefono" 
        SortExpression="Tel_Est" />
    <asp:BoundField DataField="Cor_Est" HeaderText="Correo" 
        SortExpression="Cor_Est" />
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
            <asp:ObjectDataSource id="ObjTipos" runat="server" TypeName="Establecimientos" 
                SelectMethod="GetRecords" OldValuesParameterFormatString="original_{0}">
            </asp:ObjectDataSource><!-- <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></FooterStyle>-->
</contenttemplate>
    </asp:UpdatePanel>&nbsp;
    <asp:UpdatePanel id="UpdatePanel2"
        runat="server"><contenttemplate>
<!-- Mensaje de Salida--><BR /><asp:Button style="DISPLAY: none" id="hiddenTargetControlForModalPopup2" runat="server"></asp:Button> <ajaxToolkit:ModalPopupExtender id="ModalPopupTer" runat="server" PopupDragHandleControlID="programmaticPopupDragHandle2" PopupControlID="programmaticPopup2" DropShadow="True" BackgroundCssClass="modalBackground" BehaviorID="programmaticModalPopupBehavior2" RepositionMode="RepositionOnWindowScroll" TargetControlID="hiddenTargetControlForModalPopup2">
            </ajaxToolkit:ModalPopupExtender>&nbsp;&nbsp; 
            <asp:Panel id="programmaticPopup2" runat="server" Width="409px" Height="400px" 
                CssClass="ModalPanel2"><asp:Panel id="programmaticPopupDragHandle2" 
                    runat="Server" Width="412px" Height="30px" CssClass="BarTitleModal2"><DIV style="PADDING-RIGHT: 5px; PADDING-LEFT: 5px; PADDING-BOTTOM: 5px; VERTICAL-ALIGN: middle; PADDING-TOP: 5px"><DIV style="FLOAT: left">
                            Capacidades</DIV><DIV style="FLOAT: right">
                            <INPUT id="BtnCerrar" type=button value="X" /></DIV></DIV></asp:Panel>&nbsp;<TABLE><TBODY>
        <TR><TD colSpan=3>
            <asp:Label id="SubT" runat="server" Text="Nuevo" CssClass="SubTitulo"></asp:Label></TD></TR>
        <TR><TD colSpan=3>
            <asp:ValidationSummary id="ValidationSummary1" runat="server" 
                SkinID="ValidationSummary1" ValidationGroup="Guardar">
                    </asp:ValidationSummary></TD></TR>
        <TR><TD style="WIDTH: 98px">
                <asp:Label id="Label4" runat="server" Width="143px" Text="NIT" 
                    __designer:wfdid="w19"></asp:Label></TD>
            <TD style="WIDTH: 100px"><asp:TextBox ID="TxtCodNew" runat="server" Width="200px"></asp:TextBox>
            <ajaxToolkit:FilteredTextBoxExtender runat="server" ID="F1" FilterType="Numbers" TargetControlID="TxtCodNew"></ajaxToolkit:FilteredTextBoxExtender></TD>
            <TD style="WIDTH: 100px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="TxtCodNew" ErrorMessage="Digite  Codigo " 
                    ValidationGroup="Guardar">*</asp:RequiredFieldValidator></TD></TR>
        <TR><TD style="WIDTH: 98px; HEIGHT: 23px">
                <asp:Label id="Label1" runat="server" Width="126px" Text="Nombre"></asp:Label></TD>
            <TD style="WIDTH: 100px; HEIGHT: 23px">
                    <asp:TextBox ID="txtNomNew" runat="server" Width="200px"></asp:TextBox></TD>
            <TD style="WIDTH: 100px; HEIGHT: 23px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtNomNew" 
                        ErrorMessage="Digite el Nombre de la Categoria" ValidationGroup="Guardar">*</asp:RequiredFieldValidator></TD></TR>
                    <TR><TD style="WIDTH: 98px">
                        <asp:Label ID="Label5" runat="server" Text="Dirección" Width="126px"></asp:Label>
                        </TD><TD style="WIDTH: 100px">
                            <asp:TextBox ID="TxtDir" runat="server" Width="200px"></asp:TextBox>
                        </TD>
            <TD style="WIDTH: 100px"></TD></TR>
        <TR><TD style="WIDTH: 98px">
            <asp:Label ID="Label6" runat="server" Text="Télefono" Width="126px"></asp:Label>
            </TD>
            <TD style="WIDTH: 100px">
                <asp:TextBox ID="TxtTel" runat="server"></asp:TextBox>
                <ajaxToolkit:FilteredTextBoxExtender runat="server" ID="FilteredTextBoxExtender1" FilterType="Numbers" TargetControlID="TxtTel"></ajaxToolkit:FilteredTextBoxExtender>
            </TD><TD style="WIDTH: 100px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="TxtTel" ErrorMessage="Digite el Telefono" 
                    ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
            </TD></TR><TR>
            <TD style="WIDTH: 98px">
                <asp:Label ID="Label7" runat="server" Text="Correo" Width="126px"></asp:Label>
                    </TD><TD style="WIDTH: 100px">
                        <asp:TextBox ID="TxtCor" runat="server" Width="200px"></asp:TextBox>
                    </TD><TD style="WIDTH: 100px"></TD></TR>
        <TR><TD style="TEXT-ALIGN: center" colSpan=3><asp:Button id="BtnGuardar" 
                onclick="BtnGuardar_Click" runat="server" Text="Guardar" 
                ValidationGroup="Guardar"></asp:Button>&nbsp;<asp:Button id="BtnEliminar" onclick="BtnEliminar_Click" runat="server" Text="Eliminar">
                    </asp:Button>&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Cancelar" />
            &nbsp;</TD></TR></TBODY></TABLE>&nbsp;</asp:Panel>&nbsp;&nbsp; 
</contenttemplate>
    </asp:UpdatePanel>

    &nbsp;&nbsp;&nbsp;&nbsp;
        <script language="javascript" type="text/javascript">
// <![CDATA[

            function BtnCancelar_onclick() {

            }

// ]]>
        </script>
</asp:Content>

