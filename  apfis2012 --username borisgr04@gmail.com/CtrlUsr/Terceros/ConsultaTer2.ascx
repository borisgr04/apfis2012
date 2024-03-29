<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ConsultaTer2.ascx.vb" Inherits="CtrlUsr_ConsultaTer2" %>
    <table style="width: 573px; height: 10px">
    <tr>
        <td style="width: 100px">
            Nit/Nombre</td>
        <td colspan="1" style="width: 290px">
            <asp:TextBox ID="TxtFilNom" runat="server" Width="277px" AutoPostBack="True"></asp:TextBox>
        
        </td>
        <td colspan="1" style="width: 53px">
            <asp:ImageButton ID="BtnBuscar" runat="server" AccessKey="b" AlternateText="Buscar"
                CausesValidation="False" CommandName="Buscar" ImageUrl="~/images/Operaciones/search2.png"
                OnClick="BtnBuscar_Click" /></td>
        <td style="width: 49px">
            <asp:ImageButton ID="BtnAgregar" runat="server" CausesValidation="False" 
                CommandName="Nuevo" onclick="BtnAgregar_Click" SkinID="IBtnNuevo" />
        </td>
    </tr>
    <tr>
        <td style="width: 100px">
        </td>
        <td colspan="1" style="width: 290px">
        </td>
        <td colspan="1" style="width: 53px">
            Buscar</td>
        <td style="width: 49px">
            Nuevo</td>
    </tr>
        <tr>
            <td colspan="4">
                <asp:GridView ID="GridView1" runat="server" 
                    AutoGenerateColumns="False" DataKeyNames="Cedula" DataSourceID="ObjTerceros" 
                    OnRowDataBound="GridView1_RowDataBound" 
                    OnSelectedIndexChanged="GridView1_SelectedIndexChanged" ShowFooter="True" 
                    EnableModelValidation="True" Width="100%" AllowPaging="True">
                    <Columns>
                        <asp:TemplateField HeaderText="Identificaci�n" SortExpression="IDE_TER">
                            <ItemTemplate>
                                <asp:Label ID="LbNom" runat="server" Text='<%# Bind("CEDULA") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Apellidos y Nombres / Raz�n Social" 
                            SortExpression="NOM_TER">
                            <ItemTemplate>
                                <asp:Label ID="LbUni1" runat="server" Text='<%# Bind("NOMCOMPLETO") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Direcci�n" SortExpression="DIR_TER">
                            <ItemTemplate>
                                <asp:Label ID="LbUni2" runat="server" Text='<%# Bind("DIRECCION") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Tel�fono" SortExpression="TEL_TER">
                            <ItemTemplate>
                                <asp:Label ID="LbBar" runat="server" Text='<%# Bind("TELEFONO") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Email" SortExpression="EMA_TER">
                            <ItemTemplate>
                                <asp:Label ID="LbNor" runat="server" Text='<%# Bind("CORREO") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField ButtonType="Image" 
                            SelectImageUrl="~/images/BlueTheme/Select.png" ShowSelectButton="True" />
                        <asp:ButtonField ButtonType="Image" CommandName="editar" 
                            ImageUrl="~/images/Operaciones/Edit2.png" Text="Button" />
                    </Columns>
                    <EmptyDataTemplate>
                        <br />
                        <asp:Label ID="Label1" runat="server" CssClass="NoData" 
                            Text="No se encontraron registros" Width="166px"></asp:Label>
                    </EmptyDataTemplate>
                </asp:GridView>
            </td>
        </tr>
</table>

&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;<asp:HiddenField ID="HiddenField1" runat="server" Value="Tipo" />
<asp:ObjectDataSource ID="ObjTerceros" runat="server" SelectMethod="GetRecords" 
    TypeName="Terceros" InsertMethod="Insert" 
    OldValuesParameterFormatString="original_{0}">
    <InsertParameters>
        <asp:Parameter Name="Ced_Inf" Type="String" />
        <asp:Parameter Name="Ape1_inf" Type="String" />
        <asp:Parameter Name="Ape2_Inf" Type="String" />
        <asp:Parameter Name="Nom_Inf" Type="String" />
        <asp:Parameter Name="Exp_Ced_Inf" Type="String" />
        <asp:Parameter Name="Dir_Inf" Type="String" />
        <asp:Parameter Name="Tel_Inf" Type="String" />
        <asp:Parameter Name="Cor_Inf" Type="String" />
        <asp:Parameter Name="Tipo" Type="String" />
    </InsertParameters>
    <SelectParameters>
        <asp:ControlParameter ControlID="TxtFilNom" Name="busc" PropertyName="Text" Type="String" />
        <asp:ControlParameter ControlID="HiddenField2" Name="tipo" PropertyName="Value" 
            Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:HiddenField ID="HiddenField2" runat="server" />

