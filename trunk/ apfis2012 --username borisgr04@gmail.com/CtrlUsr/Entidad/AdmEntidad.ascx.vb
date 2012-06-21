
Partial Class CtrlUsr_AdmTercero_AdmTercero
    Inherits CtrlUsrComun


    Public ReadOnly Property Nit As String
        Get
            Return ConsultaEnt1.Ide_Ter
        End Get

    End Property

    Public Property TipoTer As String
        Get
            Return ViewState("TipoTer")
        End Get
        Set(ByVal value As String)
            ViewState("TipoTer") = value
            Me.ConsultaEnt1.TipoTer = value
        End Set
    End Property

#Region "Eventos del control"
    Public Event SelClicked As EventHandler
    Protected Overridable Sub OnClick(ByVal sender As Object)
        RaiseEvent SelClicked(sender, New EventArgs())
    End Sub
#End Region
    Sub ConsultaTer21_SelClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles ConsultaEnt1.SelClicked
        OnClick(sender)
    End Sub

    Sub ConsultaTer21_OnNuevoClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles ConsultaEnt1.NuevoClicked
        CrEntidad1.Nuevo()
        CrEntidad1.TipoTercero = Me.TipoTer
        Me.MultiView1.ActiveViewIndex = 1
    End Sub
    Sub ConsultaTer21_EditClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles ConsultaEnt1.EditClicked
        CrEntidad1.Nit = ConsultaEnt1.Ide_Ter
        CrEntidad1.TipoTercero = Me.TipoTer
        CrEntidad1.Editar()
        Me.MultiView1.ActiveViewIndex = 1
    End Sub

    Protected Sub BtnVoler_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnVoler.Click
        ConsultaEnt1.Filtro = CrEntidad1.Nit
        ConsultaEnt1.DataBind()
        Me.MultiView1.ActiveViewIndex = 0
    End Sub
End Class
