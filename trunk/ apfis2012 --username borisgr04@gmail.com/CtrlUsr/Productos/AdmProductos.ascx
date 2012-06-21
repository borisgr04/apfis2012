<%@ Control Language="VB" AutoEventWireup="false" CodeFile="AdmProductos.ascx.vb" Inherits="CtrlUsr_AdmProductos_AdmProductos" %>

<%@ Register src="../Terceros/ConsultaTer2.ascx" tagname="consultater2" tagprefix="uc3" %>
<%@ Register src="../CrTerceros/CrTerceros.ascx" tagname="crterceros" tagprefix="uc1" %>
<%@ Register src="ConsultaProd.ascx" tagname="ConsultaProd" tagprefix="uc5" %>
<%@ Register src="CrProductos.ascx" tagname="CrProductos" tagprefix="uc6" %>
<asp:UpdatePanel runat="server" ID="UpdatePanel1">
    <ContentTemplate>
<asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
    
        <asp:View ID="View1" runat="server">
            <uc5:ConsultaProd ID="ConsultaProd1" runat="server" />
        </asp:View>
        <asp:View ID="View2" runat="server">
            <table class="style1">
                <tr>
                    <td style="text-align: right">
                        <asp:Button ID="BtnVoler" runat="server" Text="Volver" CausesValidation="False" 
                            ValidationGroup="NOVALIDAR" />
                        <uc6:CrProductos ID="CrProductos1" runat="server" />
                    </td>
                </tr>
            </table>
            
</asp:View>
        </asp:MultiView>
        </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="BtnVoler" EventName="Click" />
    </Triggers>
</asp:UpdatePanel>
