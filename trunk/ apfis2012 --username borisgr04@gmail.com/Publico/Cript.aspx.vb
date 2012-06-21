
Partial Class Publico_Cript
    Inherits System.Web.UI.Page

    Dim seg As New Seguridad
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Text = seg.Cript(TextBox1.Text)

    End Sub
    

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label2.Text = seg.DesCript(Label1.Text)
    End Sub
End Class
