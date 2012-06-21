
Partial Class CtrlUsr_AdmProductos_AdmProductos
    Inherits CtrlUsrComun


    Public ReadOnly Property Codigo As String
        Get
            Return ConsultaProd1.Codigo
        End Get
    End Property

    Public Property TipoTer As String
        Get
            Return ViewState("TipoTer")
        End Get
        Set(ByVal value As String)
            ViewState("TipoTer") = value
            Me.ConsultaProd1.TipoTer = value
        End Set
    End Property

#Region "Eventos del control"
    Public Event SelClicked As EventHandler
    Protected Overridable Sub OnClick(ByVal sender As Object)
        RaiseEvent SelClicked(sender, New EventArgs())
    End Sub
#End Region
    Sub ConsultaTer21_SelClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles ConsultaProd1.SelClicked
        OnClick(sender)
    End Sub

    Sub ConsultaTer21_OnNuevoClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles ConsultaProd1.NuevoClicked
        CrProductos1.Nuevo()
        CrProductos1.TipoTercero = Me.TipoTer
        Me.MultiView1.ActiveViewIndex = 1
    End Sub
    Sub ConsultaTer21_EditClicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles ConsultaProd1.EditClicked
        CrProductos1.Codigo = ConsultaProd1.Codigo
        CrProductos1.TipoTercero = Me.TipoTer
        CrProductos1.Editar()
        Me.MultiView1.ActiveViewIndex = 1
    End Sub

    Protected Sub BtnVoler_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnVoler.Click
        ConsultaProd1.Filtro = CrProductos1.Codigo
        ConsultaProd1.DataBind()
        Me.MultiView1.ActiveViewIndex = 0
    End Sub
End Class
