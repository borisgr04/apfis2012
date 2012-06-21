<%@ Control Language="VB" AutoEventWireup="false" CodeFile="AdmEntidad.ascx.vb" Inherits="CtrlUsr_AdmTercero_AdmTercero" %>

<%@ Register src="../Terceros/ConsultaTer2.ascx" tagname="consultater2" tagprefix="uc3" %>
<%@ Register src="../CrTerceros/CrTerceros.ascx" tagname="crterceros" tagprefix="uc1" %>
<%@ Register src="ConsultaEnt.ascx" tagname="ConsultaEnt" tagprefix="uc2" %>
<%@ Register src="CrEntidad.ascx" tagname="CrEntidad" tagprefix="uc4" %>
<asp:UpdatePanel runat="server" ID="UpdatePanel1">
    <ContentTemplate>
<asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
    
        <asp:View ID="View1" runat="server">
            <uc2:ConsultaEnt ID="ConsultaEnt1" runat="server" />
        </asp:View>
        <asp:View ID="View2" runat="server">
            <table class="style1">
                <tr>
                    <td style="text-align: right">
                        <asp:Button ID="BtnVoler" runat="server" Text="Volver" CausesValidation="False" 
                            ValidationGroup="NOVALIDAR" />
                        <uc4:CrEntidad ID="CrEntidad1" runat="server" />
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
