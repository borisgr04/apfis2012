<%@ Control Language="VB" AutoEventWireup="false" CodeFile="CrProductos.ascx.vb" Inherits="CtrlUsr_CrProductos_CrProductos" %>


<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<style type="text/css">


.RadInput_Default
{
	font:12px "segoe ui",arial,sans-serif;
}

.RadInput
{
	vertical-align:middle;
}

.RadInput_Default
{
	font:12px "segoe ui",arial,sans-serif;
}

.RadInput
{
	vertical-align:middle;
}

    .style1
    {
        width: 109px;
    }
</style>


<%-- <script type="text/javascript">
         
            
          function ColocarNit(){
            
                document.aspnetForm.<%=Me.TxtDVER.ClientID%>.value="";
                document.aspnetForm.<%=Me.TxtUsu.ClientID%>.value=document.aspnetForm.<%=Me.TxtNit.ClientID%>.value;
                if(document.aspnetForm.<%=Me.CbTdoc.ClientID%>.value=="NI")
                {
                    var dv=calcularDV(document.aspnetForm.<%=Me.TxtNit.ClientID%>.value);
                    document.aspnetForm.<%=Me.TxtDVER.ClientID%>.value=dv;
                    document.aspnetForm.<%=Me.TxtUsu.ClientID%>.value=document.aspnetForm.<%=Me.TxtUsu.ClientID%>.value;//+"-"+dv;
                }
            }

            function ArmarNombre(){
            
            var ape1=document.aspnetForm.<%=Me.TxtApe1.ClientID%>.value;
            var ape2=document.aspnetForm.<%=Me.TxtApe2.ClientID%>.value;
            var nom1=document.aspnetForm.<%=Me.TxtNom1.ClientID%>.value;
            var nom2=document.aspnetForm.<%=Me.TxtNom2.ClientID%>.value;
            document.aspnetForm.<%=Me.TxtNom.ClientID%>.value=ape1+" "+ape2+" "+nom1+" "+nom2;           
            
            }

            function SwNombre(){
            
            if(document.aspnetForm.<%=Me.CbTdoc.ClientID%>.value=="NI")
                {
                /*document.aspnetForm.<%=Me.TxtApe1.ClientID%>.disabled=true;
                document.aspnetForm.<%=Me.TxtApe2.ClientID%>.disabled=true;
                document.aspnetForm.<%=Me.TxtNom1.ClientID%>.disabled=true;
                document.aspnetForm.<%=Me.TxtNom2.ClientID%>.disabled=true;
                

                document.aspnetForm.<%=Me.TxtApe1.ClientID%>.value="";
                document.aspnetForm.<%=Me.TxtApe2.ClientID%>.value="";
                document.aspnetForm.<%=Me.TxtNom1.ClientID%>.value="";
                document.aspnetForm.<%=Me.TxtNom2.ClientID%>.value="";

                document.aspnetForm.<%=Me.TxtNom.ClientID%>.disabled=false;*/
                }
                else
                {
               /* document.aspnetForm.<%=Me.TxtApe1.ClientID%>.disabled=false;
                document.aspnetForm.<%=Me.TxtApe2.ClientID%>.disabled=false;
                document.aspnetForm.<%=Me.TxtNom1.ClientID%>.disabled=false;
                document.aspnetForm.<%=Me.TxtNom2.ClientID%>.disabled=false;

                document.aspnetForm.<%=Me.TxtNom.ClientID%>.disabled=true;*/
                }

            }



               
        function zero_fill(i_valor, num_ceros) {
        relleno = ""
        i = 1
        salir = 0
        while ( ! salir ) {
        total_caracteres = i_valor.length + i
        if ( i > num_ceros || total_caracteres > num_ceros )
        salir = 1
        else
        relleno = relleno + "0"
        i++
        }

        i_valor = relleno + i_valor
        return i_valor
        }

        function calcularDV(i_rut) {
        var pesos = new Array(71,67,59,53,47,43,41,37,29,23,19,17,13,7,3); 
        rut_fmt = zero_fill(i_rut, 15)
        suma = 0
        for ( i=0; i<=14; i++ ) 
        suma += rut_fmt.substring(i, i+1) * pesos[i]
        resto = suma % 11
        if ( resto == 0 || resto == 1 )
        digitov = resto
        else
        digitov = 11 - resto

        return(digitov)
        }

       </script>--%>

       <div>
         <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate> 
            &nbsp;<asp:Label id="Tit" runat="server" CssClass="Titulo" 
                Text="ESTABLECIMIENTOS"></asp:Label>&nbsp; <BR />
            <asp:Label id="MsgResult" runat="server" SkinID="MsgResult"></asp:Label>&nbsp; <BR />
            <asp:ValidationSummary id="ValidationSummary1" runat="server" Width="543px"  SkinID="ValidationSummary1"
                ValidationGroup="GuardarEst"></asp:ValidationSummary> 

<TABLE style="WIDTH: 641px"><TBODY>
    <TR><TD colSpan=12>
        <asp:Label ID="SubT" runat="server" CssClass="SubTitulo" Text="Nuevo"></asp:Label>
        </TD></TR>
    <TR><TD style="WIDTH: 108px">Subcategoria</TD>
        <TD style="WIDTH: 60px" colspan="4">
            <asp:DropDownList ID="CmbScat" runat="server" AutoPostBack="True" 
                DataSourceID="ObjScat" DataTextField="Des_Scat" DataValueField="Cod_Scat" 
                Width="200px">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ObjScat" runat="server" DeleteMethod="Delete" 
                InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
                SelectMethod="GetRecords" TypeName="SubCategorias" UpdateMethod="Update">
                <DeleteParameters>
                    <asp:Parameter Name="Original_Cod_SCat" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Cod_Cat" Type="String" />
                    <asp:Parameter Name="Cod_SCat" Type="String" />
                    <asp:Parameter Name="Des_SCat" Type="String" />
                    <asp:Parameter Name="Cod_SCat_Ant" Type="String" />
                    <asp:Parameter Name="Cod_Fnd" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Cod_Cat" Type="String" />
                    <asp:Parameter Name="Cod_SCat" Type="String" />
                    <asp:Parameter Name="Des_SCat" Type="String" />
                    <asp:Parameter Name="Cod_SCat_Ant" Type="String" />
                    <asp:Parameter Name="Cod_Fnd" Type="String" />
                    <asp:Parameter Name="Original_Cod_SCat" Type="String" />
                </UpdateParameters>
            </asp:ObjectDataSource>
        </TD>
        <TD colspan="4" class="style1">Capacidad</TD>
        <td colspan="2" valign="middle">
            <asp:DropDownList ID="CmbCap" runat="server" DataSourceID="ObjCap" 
                DataTextField="Des_Cap" DataValueField="Cod_Cap" Width="200px">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ObjCap" runat="server" DeleteMethod="Delete" 
                InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
                SelectMethod="GetbyCat" TypeName="Capacidades" UpdateMethod="Update">
                <DeleteParameters>
                    <asp:Parameter Name="Original_Cod_Cap" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Cod_Cap" Type="String" />
                    <asp:Parameter Name="Des_Cap" Type="String" />
                    <asp:Parameter Name="Cod_Cat" Type="String" />
                    <asp:Parameter Name="Cod_Cap_Ant" Type="String" />
                    <asp:Parameter Name="Pre_Fnd" Type="String" />
                </InsertParameters>
                <SelectParameters>
                    <asp:ControlParameter ControlID="CmbScat" Name="Cod_Scat" 
                        PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Cod_Cap" Type="String" />
                    <asp:Parameter Name="Des_Cap" Type="String" />
                    <asp:Parameter Name="Cod_Cat" Type="String" />
                    <asp:Parameter Name="Cod_Cap_Ant" Type="String" />
                    <asp:Parameter Name="Pre_Fnd" Type="String" />
                    <asp:Parameter Name="Original_Cod_Cap" Type="String" />
                </UpdateParameters>
            </asp:ObjectDataSource>
        </td>
        <TD style="WIDTH: 100px">
            &nbsp;</TD></TR>
    <tr>
        <td style="WIDTH: 108px">
            &nbsp;Codigo<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="TxtCodNew" ErrorMessage="Digite  Codigo " 
                ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
        </td>
        <td colspan="4" style="WIDTH: 60px">
            <asp:TextBox ID="TxtCodNew" runat="server" Width="200px"></asp:TextBox>
        </td>
        <td class="style1" colspan="4">
            Descripción<asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
                runat="server" ControlToValidate="txtNomNew" ErrorMessage="la Descripción" 
                ValidationGroup="Guardar">*</asp:RequiredFieldValidator>
        </td>
        <td colspan="2" valign="middle">
            <asp:TextBox ID="txtNomNew" runat="server" Width="200px"></asp:TextBox>
        </td>
        <td style="WIDTH: 100px">
            <asp:TextBox ID="TxtDver" runat="server" Enabled="False" ReadOnly="True" 
                Rows="1" Visible="False" Width="20px"></asp:TextBox>
        </td>
    </tr>
    <TR><TD style="WIDTH: 108px">Precio Venta DANE</TD>
        <TD style="WIDTH: 60px" colspan="4">
             <telerik:RadNumericTextBox ID="TxtPventLeg" Runat="server" Culture="es-CO" 
                 DataType="System.Decimal">
                 <NumberFormat DecimalSeparator="." GroupSeparator="," />
             </telerik:RadNumericTextBox>
             </TD>
        <td colspan="4" class="style1">
            Precio Venta Ilegal</td>
        <td colspan="3">
            <telerik:RadNumericTextBox ID="TxtPVentIleg" Runat="server" Culture="es-CO" 
                DataType="System.Decimal">
                <NumberFormat DecimalSeparator="." GroupSeparator="," />
            </telerik:RadNumericTextBox>
        </td>
    </TR>
    <tr>
        <td style="WIDTH: 108px">
            Grados Alcoholimetricos</td>
        <td style="WIDTH: 60px" colspan="4">
            <telerik:RadNumericTextBox ID="TxtGrad" Runat="server">
                <NumberFormat DecimalSeparator="." GroupSeparator="," />
            </telerik:RadNumericTextBox>
        </td>
        <td colspan="4" class="style1">
            Tipo</td>
        <td colspan="3">
            <asp:DropDownList ID="CmbTip" runat="server">
                <asp:ListItem Value="N">NACIONAL</asp:ListItem>
                <asp:ListItem Value="E">EXTRANJERO</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td style="text-align: center;" colspan="2">
            &nbsp;</td>
        <td style="WIDTH: 117px; text-align: center;">
            &nbsp;</td>
        <td style="WIDTH: 117px; text-align: center;" colspan="4">
            <asp:ImageButton ID="BtnAgregar" runat="server" CausesValidation="False" 
                CommandName="Nuevo" onclick="BtnAgregar_Click" SkinID="IBtnNuevo" />
        </td>
        <td style="text-align: center; width: 117px;">
            <asp:ImageButton ID="BtnSave" runat="server" SkinID="IBtnGuardar" 
                ValidationGroup="GuardarEst" />
        </td>
        <td colspan="2" style="text-align: center; width: 268435408px;">
            <asp:ImageButton ID="BtnCancel" runat="server" CausesValidation="False" 
                onclick="BtnCancel_Click" SkinID="IBtnCancelar" />
        </td>
        <td colspan="1" style="WIDTH: 192px; TEXT-ALIGN: center">
            &nbsp;</td>
        <td colspan="1" style="TEXT-ALIGN: center">
        </td>
    </tr>
    <tr>
        <td colspan="2" style="text-align: center;">
            &nbsp;</td>
        <td style="text-align: center; width: 117px;" colspan="2">
            &nbsp;</td>
        <td colspan="2" style="text-align: center; width: 117px;">
            Nuevo</td>
        <td style="text-align: center; width: 117px;" colspan="2">
            Guardar</td>
        <td colspan="2" style="text-align: center; width: 268435408px;">
            Limpiar</td>
        <td colspan="1" style="WIDTH: 192px; TEXT-ALIGN: center">
            &nbsp;</td>
        <td colspan="1" style="TEXT-ALIGN: center">
            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="10" style="text-align: right;">
            &nbsp;</td>
        <td colspan="1" style="WIDTH: 192px; TEXT-ALIGN: left">
            &nbsp;</td>
        <td colspan="1" style="TEXT-ALIGN: center; ">
            &nbsp;</td>
    </tr>
    </TBODY></TABLE>
           
<asp:ObjectDataSource id="ObjMUN" runat="server" TypeName="Municipios" SelectMethod="GetRecords"></asp:ObjectDataSource> <asp:ObjectDataSource id="ObjTTer" runat="server" TypeName="TTerc" SelectMethod="GetRecords"></asp:ObjectDataSource> 
                <asp:ObjectDataSource ID="ObjTD" runat="server" 
                    OldValuesParameterFormatString="original_{0}" SelectMethod="GetRecords" 
                    TypeName="TipIde"></asp:ObjectDataSource>
                <asp:ObjectDataSource id="ObjTusua" runat="server" TypeName="TipUsu" SelectMethod="GetRecords"></asp:ObjectDataSource>
            &nbsp;<asp:HiddenField id="HOldNit" runat="server"></asp:HiddenField> <asp:HiddenField id="HoldTDoc" runat="server"></asp:HiddenField> <asp:HiddenField id="HoldDVer" runat="server"></asp:HiddenField>&nbsp;<BR />
</ContentTemplate>

        </asp:UpdatePanel>
<asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
        <ProgressTemplate>
            <div class="Loading">
            <asp:Image SkinID="ImgProgress" runat="server" ID="ImgAjax"/> Cargando …
            </div>
        </ProgressTemplate>
        </asp:UpdateProgress>
    </div>

