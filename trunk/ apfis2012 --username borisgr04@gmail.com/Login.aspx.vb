
Partial Class Login
    Inherits PaginaComun

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            Context.Request.Browser.Adapters.Clear()

        End If

    End Sub

    Protected Sub cmdEnviar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEnviar.Click
        'System.Threading.Thread.Sleep(10000)

        Dim u As String = Me.TxtUsername.Text.Trim
        Dim c As String = Me.TxtClave.Text.Trim
        Dim usu As New UsuariosA
        'If Membership.ValidateUser(u, c) = True Then
        If usu.Validar_Usuarios(u, c) Then
            Me.msgResult.Text = "Acceso Permitido :" + Now.ToLongTimeString
            Me.msgResult.ForeColor = Drawing.Color.Green
            Dim aCookie As New HttpCookie(Publico.Cookie)
            Response.Cookies.Add(aCookie)
            'Profile.Modulo = 
            FormsAuthentication.RedirectFromLoginPage(Me.TxtUsername.Text, True)
            'Response.Redirect("default.aspx")

        Else
            
            Me.msgResult.Text = "Acceso Denegado : Usuario o Contreña Inválidas"
            Me.msgResult.ForeColor = Drawing.Color.Red
        End If



    End Sub
End Class
