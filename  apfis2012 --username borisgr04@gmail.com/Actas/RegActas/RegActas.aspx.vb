Imports System.Data
Partial Class Actas_RegActas
    Inherits PaginaComun
    Private Property TipoTer() As String
        Set(ByVal value As String)
            ViewState("TipoTer") = value
        End Set
        Get
            Return ViewState("TipoTer")
        End Get
    End Property
    Private Property OperProd() As String
        Set(ByVal value As String)
            ViewState("OperProd") = value
        End Set
        Get
            Return ViewState("OperProd")
        End Get
    End Property
    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBuscInf.Click
        Me.AdmTercero1.tipoter = "Infractor"
        Me.ModalPopup.Show()
        Me.TipoTer = "Infractor"
    End Sub

    Protected Sub AdmTercero1_SelClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdmTercero1.SelClicked
        Select Case Me.TipoTer
            Case "Infractor"
                Me.TxtCedInf.Text = AdmTercero1.Nit
                BuscarInf()
            Case "InfractorFirma"
                Me.TxtCedInfFir.Text = AdmTercero1.Nit
                BuscarInfFirma()
            Case "RBodega"
                Me.TxtCedRB.Text = AdmTercero1.Nit
                BuscarRB()
            Case "RAutoridad"
                Me.TxtCedRA.Text = AdmTercero1.Nit
                BuscarRA()
            Case "CGOperativo"
                Me.TxtCedCG.Text = AdmTercero1.Nit
                BuscarCG()
        End Select
        ModalPopup.Hide()
    End Sub

    Protected Sub TxtCedInf_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCedInf.TextChanged
        BuscarInf()
    End Sub
    Sub BuscarInf()
        Dim obj As New Terceros
        Dim dt As DataTable = obj.GetByIde(TxtCedInf.Text)
        If dt.Rows.Count > 0 Then
            TxtNomInf.Text = dt.Rows(0)("NOMCOMPLETO").ToString
            TxtDirInf.Text = dt.Rows(0)("Direccion").ToString
            TxtCorInf.Text = dt.Rows(0)("Correo").ToString
            TxtExpInf.Text = dt.Rows(0)("Expedida").ToString
            TxtTelInf.Text = dt.Rows(0)("Telefono").ToString
        Else
            TxtNomInf.Text = ""
            TxtDirInf.Text = ""
            TxtCorInf.Text = ""
            TxtExpInf.Text = ""
            TxtTelInf.Text = ""
        End If
    End Sub
    Sub BuscarInfFirma()
        Dim obj As New Terceros
        Dim dt As DataTable = obj.GetByIde(TxtCedInfFir.Text)
        If dt.Rows.Count > 0 Then
            TxtNomInfFir.Text = dt.Rows(0)("NOMCOMPLETO").ToString
            TxtDirInfFir.Text = dt.Rows(0)("Direccion").ToString
        Else
            TxtNomInfFir.Text = ""
            TxtDirInfFir.Text = ""
        End If
    End Sub
    Sub BuscarRA()
        Dim obj As New Terceros
        Dim dt As DataTable = obj.GetByIde(TxtCedRA.Text)
        If dt.Rows.Count > 0 Then
            TxtNomRA.Text = dt.Rows(0)("NOMCOMPLETO").ToString
            TxtDirRA.Text = dt.Rows(0)("Direccion").ToString
        Else
            TxtNomRA.Text = ""
            TxtDirRA.Text = ""
        End If
    End Sub
    Sub BuscarRB()
        Dim obj As New Terceros
        Dim dt As DataTable = obj.GetByIde(TxtCedRB.Text)
        If dt.Rows.Count > 0 Then
            TxtNomRB.Text = dt.Rows(0)("NOMCOMPLETO").ToString
            TXTDirRB.Text = dt.Rows(0)("Direccion").ToString
        Else
            TxtNomRB.Text = ""
            TXTDirRB.Text = ""
        End If
    End Sub
    Sub BuscarCG()
        Dim obj As New Terceros
        Dim dt As DataTable = obj.GetByIde(TxtCedCG.Text)
        If dt.Rows.Count > 0 Then
            TxtNomCG.Text = dt.Rows(0)("NOMCOMPLETO").ToString
            TxtDirCG.Text = dt.Rows(0)("Direccion").ToString
        Else
            TxtNomCG.Text = ""
            TxtDirCG.Text = ""
        End If
    End Sub
    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBuscInf1.Click
        Me.AdmTercero1.TipoTer = "Infractor"
        Me.ModalPopup.Show()
        Me.TipoTer = "InfractorFirma"
    End Sub

    Protected Sub TxtCedInfFir_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCedInfFir.TextChanged
        BuscarInfFirma()
    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBuscRA.Click
        Me.AdmTercero1.TipoTer = "RAutoridad"
        Me.ModalPopup.Show()
        Me.TipoTer = "RAutoridad"
    End Sub

    Protected Sub Button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBuscRB.Click
        Me.AdmTercero1.TipoTer = "RBodega"
        Me.ModalPopup.Show()
        Me.TipoTer = "RBodega"
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBuscCoor.Click
        Me.AdmTercero1.TipoTer = "CGOperativo"
        Me.ModalPopup.Show()
        Me.TipoTer = "CGOperativo"
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBuscEst.Click
        Me.ModalPopupExtender1.Show()
    End Sub

    Protected Sub ConsultaEnt1_SelClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdmEntidad1.SelClicked
        Me.TxtIdEst.Text = AdmEntidad1.Nit
        BuscarEnt()
        ModalPopupExtender1.Hide()
    End Sub
    Protected Sub AdmProductos1_SelClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdmProductos1.SelClicked
        Me.TxtCodProd.Text = AdmProductos1.Codigo
        BuscarProd()
        UdpProd.Update()
        ModalPopupExtender2.Hide()
    End Sub
    Sub BuscarProd()
        Dim obj As New Productos
        Dim dt As DataTable = obj.GetbyPK(TxtCodProd.Text)
        If dt.Rows.Count > 0 Then
            TxtDesProd.Text = dt.Rows(0)("Descripcion").ToString
            TxtValProd.Text = dt.Rows(0)("Valor").ToString
        Else
            TxtDesProd.Text = ""
            TxtValProd.Text = ""
        End If
    End Sub
    Sub BuscarEnt()
        Dim obj As New Establecimientos
        Dim dt As DataTable = obj.GetbyPK(TxtIdEst.Text)
        If dt.Rows.Count > 0 Then
            Me.TxtNomEst.Text = dt.Rows(0)("Nom_Est").ToString
            Me.TxtDirEst.Text = dt.Rows(0)("Dir_Est").ToString
        Else
            Me.TxtNomEst.Text = ""
            Me.TxtDirEst.Text = ""
        End If
    End Sub

    Protected Sub TxtIdEst_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtIdEst.TextChanged
        BuscarEnt()
    End Sub

    Protected Sub Button7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSig.Click
        Dim objAct As New Actas
        Select Case Me.Oper
            Case "Nuevo"
                Me.MsgResult.Text = objAct.Insert(Me.TxtNumActa.Text, Me.DtFi.SelectedDate, Me.DTFf.SelectedDate, Me.TxtIdEst.Text, Me.TxtFact.Text, Me.TxtOtro.Text, Me.TxtCedInf.Text, Me.TxtFacCom.Text, Me.TxtOtros.Text, Me.TxtManCar.Text, Me.TxtNumFolioFac.Text, Me.TxtNumFolioMarcar.Text, Me.TxtNumFolOtros.Text, TxtCedCG.Text, Me.TxtCedRA.Text, Me.TxtCedRB.Text, Util.invSI_NO(Me.ChkCoor.Checked), Util.invSI_NO(ChkInf.Checked), Util.invSI_NO(ChkRA.Checked), Util.invSI_NO(ChkRB.Checked), "00", CmbMunOri.SelectedValue, CmbBodDes.SelectedValue, Util.invN1_0(Rb1.Checked))
                MsgBox(MsgResult, objAct.lErrorG)
                If objAct.lErrorG = False Then
                    Me.Panel1.Visible = True
                    Me.BtnSig.Visible = False
                Else
                    Me.Panel1.Visible = False
                    Me.BtnSig.Visible = True
                End If
            Case "Editar"
                
        End Select
        
    End Sub

    Protected Sub Button16_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button16.Click
        ModalPopupExtender2.Show()
    End Sub

    Protected Sub TxtCodProd_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodProd.TextChanged
        BuscarProd()
    End Sub

    Protected Sub TxtNumActaI_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNumActaI.TextChanged
        Abrir()
    End Sub
    Sub Abrir()
        Dim objAct As New Actas
        Dim dt As DataTable = objAct.GetbyPK(TxtNumActaI.Text)
        Me.MsgResultProd.Text = ""
        Me.MsgResultProd.CssClass = ""
        If dt.Rows.Count > 0 Then
            If dt.Rows(0)("Estado").ToString <> "00" Then
                MsgResult.Text = "El Acta ya fue confirmada y no puede ser modificada."
                MsgBoxAlert(MsgResult, True)
                Me.TxtNumActa.Text = dt.Rows(0)("NROACTA").ToString
                Me.Pk1 = dt.Rows(0)("NROACTA").ToString
                Me.DtFi.SelectedDate = dt.Rows(0)("FECHAINI").ToString
                Me.DTFf.SelectedDate = dt.Rows(0)("FECHAFIN").ToString
                Me.TxtFact.Text = dt.Rows(0)("FACTURA").ToString
                Me.TxtOtro.Text = dt.Rows(0)("OTRODOC").ToString
                Me.TxtIdEst.Text = dt.Rows(0)("NIT_EST").ToString
                Me.TxtCedInf.Text = dt.Rows(0)("CED_INF").ToString
                Me.TxtExpl.Text = dt.Rows(0)("EXPLICACION").ToString
                Me.TxtFacCom.Text = dt.Rows(0)("REL_FACTCOM").ToString
                Me.TxtNumFolioFac.Text = dt.Rows(0)("REL_FACTCOM_FOLIO").ToString
                Me.TxtManCar.Text = dt.Rows(0)("REL_MANCARGA").ToString
                Me.TxtNumFolioMarcar.Text = dt.Rows(0)("REL_MANCARGA_FOLIO").ToString
                Me.TxtOtros.Text = dt.Rows(0)("REL_OTROS").ToString
                Me.TxtNumFolOtros.Text = dt.Rows(0)("REL_OTROS_FOLIO").ToString
                Me.ChkCoor.Checked = Util.SI_NO(dt.Rows(0)("FCOOR").ToString)
                Me.ChkInf.Checked = Util.SI_NO(dt.Rows(0)("FINF").ToString)
                Me.ChkRA.Checked = Util.SI_NO(dt.Rows(0)("FAUT").ToString)
                Me.ChkRB.Checked = Util.SI_NO(dt.Rows(0)("FBOD").ToString)
                Me.TxtCedInfFir.Text = dt.Rows(0)("CED_INF").ToString
                Me.TxtCedCG.Text = dt.Rows(0)("IDE_COOR").ToString
                Me.TxtCedRA.Text = dt.Rows(0)("IDE_AUTORIDAD").ToString
                Me.TxtCedRB.Text = dt.Rows(0)("IDE_BODEGA").ToString
                Me.CmbMunOri.SelectedValue = dt.Rows(0)("COD_MUN").ToString
                Dim objbod As New Bodegas
                Me.CmbMunDes.SelectedValue = objbod.GetMunbyBOD(dt.Rows(0)("COD_BOD").ToString)
                Me.CmbBodDes.SelectedValue = dt.Rows(0)("COD_BOD").ToString
                If dt.Rows(0)("FIRMA").ToString = "PERSONAL" Then
                    Rb1.Checked = True
                Else
                    Rb2.Checked = True
                End If
                BuscarCG()
                BuscarEnt()
                BuscarInf()
                BuscarInfFirma()
                BuscarRA()
                BuscarRB()
                Me.Panel1.Visible = True
                Me.BtnSig.Visible = False
                UdpProd.Update()
                habilitar(False)
                Me.BtnEdit.Enabled = False
            Else
                Me.MsgResult.Text = ""
                Me.MsgResult.CssClass = ""
                Me.TxtNumActa.Text = dt.Rows(0)("NROACTA").ToString
                Me.Pk1 = dt.Rows(0)("NROACTA").ToString
                Me.DtFi.SelectedDate = dt.Rows(0)("FECHAINI").ToString
                Me.DTFf.SelectedDate = dt.Rows(0)("FECHAFIN").ToString
                Me.TxtFact.Text = dt.Rows(0)("FACTURA").ToString
                Me.TxtOtro.Text = dt.Rows(0)("OTRODOC").ToString
                Me.TxtIdEst.Text = dt.Rows(0)("NIT_EST").ToString
                Me.TxtCedInf.Text = dt.Rows(0)("CED_INF").ToString
                Me.TxtExpl.Text = dt.Rows(0)("EXPLICACION").ToString
                Me.TxtFacCom.Text = dt.Rows(0)("REL_FACTCOM").ToString
                Me.TxtNumFolioFac.Text = dt.Rows(0)("REL_FACTCOM_FOLIO").ToString
                Me.TxtManCar.Text = dt.Rows(0)("REL_MANCARGA").ToString
                Me.TxtNumFolioMarcar.Text = dt.Rows(0)("REL_MANCARGA_FOLIO").ToString
                Me.TxtOtros.Text = dt.Rows(0)("REL_OTROS").ToString
                Me.TxtNumFolOtros.Text = dt.Rows(0)("REL_OTROS_FOLIO").ToString
                Me.ChkCoor.Checked = Util.SI_NO(dt.Rows(0)("FCOOR").ToString)
                Me.ChkInf.Checked = Util.SI_NO(dt.Rows(0)("FINF").ToString)
                Me.ChkRA.Checked = Util.SI_NO(dt.Rows(0)("FAUT").ToString)
                Me.ChkRB.Checked = Util.SI_NO(dt.Rows(0)("FBOD").ToString)
                Me.TxtCedInfFir.Text = dt.Rows(0)("CED_INF").ToString
                Me.TxtCedCG.Text = dt.Rows(0)("IDE_COOR").ToString
                Me.TxtCedRA.Text = dt.Rows(0)("IDE_AUTORIDAD").ToString
                Me.TxtCedRB.Text = dt.Rows(0)("IDE_BODEGA").ToString
                Me.CmbMunOri.SelectedValue = dt.Rows(0)("COD_MUN").ToString
                Dim objbod As New Bodegas
                Me.CmbMunDes.SelectedValue = objbod.GetMunbyBOD(dt.Rows(0)("COD_BOD").ToString)
                Me.CmbBodDes.SelectedValue = dt.Rows(0)("COD_BOD").ToString
                If dt.Rows(0)("FIRMA").ToString = "PERSONAL" Then
                    Rb1.Checked = True
                Else
                    Rb2.Checked = True
                End If
                BuscarCG()
                BuscarEnt()
                BuscarInf()
                BuscarInfFirma()
                BuscarRA()
                BuscarRB()
                Me.Panel1.Visible = True
                Me.BtnSig.Visible = False
                UdpProd.Update()
                habilitar(False)
                Me.BtnEdit.Enabled = True
            End If
        End If
    End Sub
    Sub Limpiar()
        Me.Oper = "Nuevo"
        Me.TxtNumActa.Text = ""
        Me.DtFi.SelectedDate = Today
        Me.DTFf.SelectedDate = Today
        Me.TxtFact.Text = ""
        Me.TxtOtro.Text = ""
        Me.TxtIdEst.Text = ""
        Me.TxtCedInf.Text = ""
        Me.TxtExpl.Text = ""
        Me.TxtFacCom.Text = ""
        Me.TxtNumFolioFac.Text = ""
        Me.TxtManCar.Text = ""
        Me.TxtNumFolioMarcar.Text = ""
        Me.TxtOtros.Text = ""
        Me.TxtNumFolOtros.Text = ""
        Me.ChkCoor.Checked = False
        Me.ChkInf.Checked = False
        Me.ChkRA.Checked = False
        Me.ChkRB.Checked = False
        Me.TxtCedInfFir.Text = ""
        Me.TxtCedCG.Text = ""
        Me.TxtCedRA.Text = ""
        Me.TxtCedRB.Text = ""
        Rb1.Checked = True
        Rb2.Checked = False
        BuscarCG()
        BuscarEnt()
        BuscarInf()
        BuscarInfFirma()
        BuscarRA()
        BuscarRB()
    End Sub

    Protected Sub BtnNuevo_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnNuevo.Click
        Limpiar()
        habilitar(True)
        Me.BtnEdit.Enabled = False
        Me.BtnAnu.Enabled = False
    End Sub

    Protected Sub Page_Load1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.DTFf.SelectedDate = Today
            Me.DtFi.SelectedDate = Today
            habilitar(False)
            Me.BtnEdit.Enabled = False
            Me.BtnAnu.Enabled = False
        End If
    End Sub

    Protected Sub BtnAbrir_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnAbrir.Click
        Abrir()
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnGuardarProd.Click
        Dim objprod As New ProdActas
        Me.MsgResultProd.Text = objprod.Insert(Me.TxtNumActa.Text, Me.TxtCodProd.Text, Me.TxtCanProd.Value, Me.TxtValProd.Value)
        MsgBox(MsgResultProd, objprod.lErrorG)
        Me.GridView1.DataBind()
    End Sub
    Sub habilitar(ByVal val As Boolean)
        Me.TxtNumActa.Enabled = val
        Me.DtFi.Enabled = val
        Me.DTFf.Enabled = val
        Me.TxtFact.Enabled = val
        Me.TxtOtro.Enabled = val
        Me.TxtIdEst.Enabled = val
        Me.TxtCedInf.Enabled = val
        Me.TxtExpl.Enabled = val
        Me.TxtFacCom.Enabled = val
        Me.TxtNumFolioFac.Enabled = val
        Me.TxtManCar.Enabled = val
        Me.TxtNumFolioMarcar.Enabled = val
        Me.TxtOtros.Enabled = val
        Me.TxtNumFolOtros.Enabled = val
        Me.ChkCoor.Enabled = val
        Me.ChkInf.Enabled = val
        Me.ChkRA.Enabled = val
        Me.ChkRB.Enabled = val
        Me.TxtCedInfFir.Enabled = val
        Me.TxtCedCG.Enabled = val
        Me.TxtCedRA.Enabled = val
        Me.TxtCedRB.Enabled = val
        Rb1.Enabled = val
        Rb2.Enabled = val
        Me.CmbBodDes.Enabled = val
        Me.CmbMunDes.Enabled = val
        Me.CmbMunOri.Enabled = val
        Me.TxtNomEst.Enabled = val
        Me.TxtDirEst.Enabled = val
        Me.TxtNomInf.Enabled = val
        Me.TxtDirInf.Enabled = val
        Me.TxtTelInf.Enabled = val
        Me.TxtCorInf.Enabled = val
        Me.TxtExpInf.Enabled = val
        Me.TxtNomInfFir.Enabled = val
        Me.TxtDirInfFir.Enabled = val
        Me.TxtNomCG.Enabled = val
        Me.TxtDirCG.Enabled = val
        Me.TxtNomRA.Enabled = val
        Me.TxtDirRA.Enabled = val
        Me.TxtNomRB.Enabled = val
        Me.TXTDirRB.Enabled = val
        Me.TxtCodProd.Enabled = val
        Me.TxtDesProd.Enabled = val
        Me.TxtCanProd.Enabled = val
        Me.TxtValProd.Enabled = val
        Me.BtnGuardarProd.Enabled = val
        Me.BtnBuscCoor.Enabled = val
        Me.BtnBuscEst.Enabled = val
        Me.BtnBuscInf.Enabled = val
        Me.BtnBuscInf1.Enabled = val
        Me.BtnBuscRA.Enabled = val
        Me.BtnBuscRB.Enabled = val
        Me.BtnSig.Enabled = val
        Me.GridView1.Enabled = val
        Me.BtnConf.Enabled = val
        UdpProd.Update()
    End Sub
    Sub Editar()
        habilitar(True)
        Me.Oper = "Editar"
        Me.BtnNuevo.Enabled = False
        Me.BtnGuardar.Visible = True
        Me.LbGuar.Visible = True
    End Sub

    Protected Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnCancel.Click
        habilitar(False)
        Me.BtnEdit.Enabled = False
        Me.BtnAnu.Enabled = False
        Me.BtnNuevo.Enabled = True
        Me.BtnGuardar.Visible = False
        Me.LbGuar.Visible = False
    End Sub

    Protected Sub BtnEdit_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnEdit.Click
        Editar()
    End Sub

    Protected Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        Dim index As Integer = Convert.ToInt32(e.CommandArgument)
        Me.GridView1.SelectedIndex = index
        Dim objprod As New ProdActas
        Select Case e.CommandName
            Case "Eliminar"
                Me.MsgResultProd.Text = objprod.Delete(GridView1.DataKeys(index).Values(1).ToString(), GridView1.DataKeys(index).Values(0).ToString())
                Me.MsgBox(MsgResultProd, objprod.lErrorG)
                Me.GridView1.DataBind()
        End Select
        Me.OperProd = "Nuevo"
    End Sub

    Protected Sub BtnGuardar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnGuardar.Click
        Dim objact As New Actas
        Me.MsgResult.Text = objact.Update(Me.TxtNumActa.Text, Me.DtFi.SelectedDate, Me.DTFf.SelectedDate, Me.TxtIdEst.Text, Me.TxtFact.Text, Me.TxtOtro.Text, Me.TxtCedInf.Text, Me.TxtFacCom.Text, Me.TxtOtros.Text, Me.TxtManCar.Text, Me.TxtNumFolioFac.Text, Me.TxtNumFolioMarcar.Text, Me.TxtNumFolOtros.Text, TxtCedCG.Text, Me.TxtCedRA.Text, Me.TxtCedRB.Text, Util.invSI_NO(Me.ChkCoor.Checked), Util.invSI_NO(ChkInf.Checked), Util.invSI_NO(ChkRA.Checked), Util.invSI_NO(ChkRB.Checked), "00", CmbMunOri.SelectedValue, CmbBodDes.SelectedValue, Util.invN1_0(Rb1.Checked), Me.Pk1)
        MsgBox(MsgResult, objact.lErrorG)
        If objact.lErrorG = False Then
            Me.BtnGuardar.Visible = False
            Me.LbGuar.Visible = False
        End If
    End Sub
End Class
