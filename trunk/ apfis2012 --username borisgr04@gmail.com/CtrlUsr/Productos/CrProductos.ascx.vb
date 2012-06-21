Imports System.Data
Partial Class CtrlUsr_CrProductos_CrProductos
    Inherits CtrlUsrComun

    Public Property Evento() As String
        Get
            Return ViewState("Evento")
        End Get
        Set(ByVal value As String)
            ViewState("Evento") = value
        End Set
    End Property
    Public Property TipoTercero() As String
        Get
            Return ViewState("TipoTercero")
        End Get
        Set(ByVal value As String)
            ViewState("TipoTercero") = value
        End Set
    End Property
    Property Codigo As String
        Get
            Return ViewState("Codigo")
        End Get
        Set(ByVal value As String)
            'Session("NitTer") = value
            TxtCodNew.Text = value
            ViewState("Codigo") = value
        End Set
    End Property

    Public Property NomTer As String
        Get
            Return ViewState("NomTer")
        End Get
        Set(ByVal value As String)
            ViewState("NomTer") = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return ViewState("Tipo")
        End Get
        Set(ByVal value As String)
            ViewState("Tipo") = value
        End Set
    End Property

#Region "Eventos del control"

    Public Event CancelClicked As EventHandler
    Public Event SaveClicked As EventHandler
    Protected Overridable Sub OnClick(ByVal sender As Object)
        If Evento = "Guardar" Then
            RaiseEvent SaveClicked(sender, New EventArgs())
        End If
        If Evento = "Cancelar" Then
            RaiseEvent CancelClicked(sender, New EventArgs())
        End If
    End Sub
#End Region

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.Opcion = Me.Tit.Text
        'Me.SetTitulo()
        'var theForm = document.forms['aspnetForm'];
        If Not IsPostBack Then
            Me.Oper = "Nuevo"
            Limpiar()

            '            FillCustomerInGrid()

        End If

    End Sub




    Protected Sub BtnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Guardar()


    End Sub

    Protected Sub Limpiar()

        'Me.CbTdoc.Text = ""

        Me.TxtCodNew.Text = ""
        Me.TxtDver.Text = ""

        'Me.CbTTcer.SelectedValue = ""
        'Me.CbMun.SelectedValue = ""
        Me.TxtCodNew.Text = ""
        Me.txtNomNew.Text = ""
        Me.TxtPVentIleg.Text = ""
        Me.TxtPventLeg.Text = ""
        Me.TxtGrad.Text = ""



        'Me.CbTUsu.Text = ""
        'Me.CbEst.Text = ""


        'Me.Oper = ""

        ' Me.TxtUsu.Enabled = True
        Me.TxtCodNew.Enabled = True
        'Me.TxtDver.Enabled = False
        Me.txtNomNew.Enabled = True
        Me.TxtPVentIleg.Enabled = True
        Me.TxtPventLeg.Enabled = True
        Me.CmbCap.Enabled = True
        Me.CmbScat.Enabled = True
        Me.CmbTip.Enabled = True
        Me.TxtGrad.Enabled = True
        Me.BtnSave.Visible = True

    End Sub


    Protected Sub GridView1_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs)
        If e.Row.RowType = DataControlRowType.DataRow Then
            ' ASIGNA EVENTOS
            e.Row.Attributes.Add("OnMouseOver", "Resaltar_On(this);")
            e.Row.Attributes.Add("OnMouseOut", "Resaltar_Off(this);")
            '            e.Row.Attributes("OnClick") = Page.ClientScript.GetPostBackClientHyperlink(Me.GridView1, "Select$" + e.Row.RowIndex.ToString)
        End If
    End Sub

    Protected Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnCancel.Click
        Limpiar()
        'Me.Evento = "Cancelar"
        'OnClick(sender)
    End Sub

    Protected Sub BtnBuscar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)

        Me.MsgResult.Text = ""
        Me.SubT.Text = "Buscando..."

    End Sub

    Protected Sub Btnsave_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Guardar()
    End Sub

    Protected Sub Guardar()
        Dim Obj As New Productos
        Me.Codigo = Me.TxtCodNew.Text
        Select Case Me.Oper
            Case "Nuevo"
                Me.MsgResult.Text = Obj.Insert(Me.TxtCodNew.Text, Me.txtNomNew.Text, Me.CmbScat.SelectedValue, Me.CmbCap.SelectedValue, Me.TxtPventLeg.Value, Me.TxtPVentIleg.Value, Me.TxtGrad.Value, Me.CmbTip.SelectedValue)
            Case "Editar"
                Me.MsgResult.Text = Obj.Update(Me.TxtCodNew.Text, Me.txtNomNew.Text, Me.CmbScat.SelectedValue, Me.CmbCap.SelectedValue, Me.TxtPventLeg.Value, Me.TxtPVentIleg.Value, Me.TxtGrad.Value, Me.CmbTip.SelectedValue, Me.Pk1)
        End Select
        MsgResult.Visible = True
        Me.MsgBox(MsgResult, Obj.lErrorG)

        If Obj.lErrorG = False Then
            'Me.Limpiar()
        End If

    End Sub

    Protected Sub BtnAgregar_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
        Nuevo()
    End Sub

    Public Sub Nuevo()
        Limpiar()
        Me.SubT.Text = "Nuevo..."

        Page.SetFocus(Me.TxtCodNew)
        Me.Oper = "Nuevo"

    End Sub

    Protected Sub TxtNit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodNew.TextChanged
        Dim t As New Establecimientos
        Dim dt As DataTable = t.GetbyPK(Me.TxtCodNew.Text)
        If dt.Rows.Count > 0 Then
            MsgResult.Text = "Ya se encuentra Registrado"
            MsgBox(MsgResult, True)
        Else
            MsgResult.Text = ""
            MsgResult.CssClass = ""
        End If
    End Sub


    Public Sub Editar()
        Me.Oper = "Editar"
        Dim Obj As New Productos
        Dim tb As DataTable = Obj.GetbyPK(Codigo)
        If tb.Rows.Count > 0 Then
            '    'If 1 = 0 Then
            Me.HOldNit.Value = tb.Rows(0)("codigo").ToString
            Me.MsgResult.Text = tb.Rows(0)("codigo").ToString
            Me.TxtCodNew.Text = tb.Rows(0)("codigo").ToString
            Me.txtNomNew.Text = tb.Rows(0)("descripcion").ToString
            Me.TxtGrad.Text = tb.Rows(0)("GradoA").ToString.Replace(",", ".")
            Me.TxtPVentIleg.Text = tb.Rows(0)("Val_Ilegal").ToString.Replace(",", ".")
            Me.TxtPventLeg.Text = tb.Rows(0)("Valor").ToString.Replace(",", ".")
            Me.CmbTip.SelectedValue = tb.Rows(0)("Tip_Fab").ToString()
            Me.CmbScat.SelectedValue = tb.Rows(0)("Cod_Scat").ToString
            CmbCap.DataBind()
            Me.CmbCap.SelectedValue = tb.Rows(0)("Cap_Prod").ToString

            Me.Pk1 = tb.Rows(0)("Codigo").ToString

            'Nuevos Campos agregados en DERWEB

            '--------------------------
            Me.TxtCodNew.Enabled = True
            'Me.TxtDver.Enabled = False
            Me.txtNomNew.Enabled = True
            Me.TxtPVentIleg.Enabled = True
            Me.TxtPventLeg.Enabled = True
            Me.CmbCap.Enabled = True
            Me.CmbScat.Enabled = True
            Me.CmbTip.Enabled = True
            Me.TxtGrad.Enabled = True
            Me.BtnSave.Visible = True

            MsgResult.Text = ""
            MsgResult.CssClass = ""
            Me.SubT.Text = "Editando..."
        Else
            MsgResult.Text = "No se encuentra registro N° de Identifiación [" + Codigo + "]"
            MsgBox(MsgResult, True)
        End If

    End Sub

    Protected Sub BtnSave_Click1(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnSave.Click
        Guardar()
    End Sub
End Class

