
Partial Class MasterPage
    Inherits System.Web.UI.MasterPage
    Dim mn As New DBMenu
    Dim mn2 As New DBMenuTk
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Cargar_Menu1()
            Dim ObjEnt As Entidad = New Entidad
            'Dim dtEnt As DataTable = ObjEnt.GetRecords()
            'Me.LbEntidad.Text = dtEnt.Rows(0)("Nombre").ToString  '+ Request.Cookies(Publico.Cookie)("Modulo")
            'Me.LbNit.Text = dtEnt.Rows(0)("NIT").ToString
        End If
    End Sub
    Sub Cargar_Menu()
        'mn.cargarMenu(Me.MnuPpal, "CLOP")
    End Sub
    'Protected Sub Change_Menu(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim b As LinkButton = DirectCast(sender, LinkButton)
    '    Dim p() As String = b.CommandArgument.Split(",")
    '    mn.cargarMenu(Me.MnuPpal, p(0))
    'End Sub
    Sub Cargar_Menu1()
        mn2.cargarMenu(Me.RadMenu1, "APFIS")
    End Sub
End Class

