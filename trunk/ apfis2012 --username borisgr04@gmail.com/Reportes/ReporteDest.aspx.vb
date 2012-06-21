
Partial Class Reportes_ReporteDest
    Inherits PaginaComun


    Protected Sub Page_Load1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.TxtFI.Text = Today.AddMonths(-1).ToShortDateString
            Me.TxtFF.Text = Today.ToShortDateString
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        ReportViewer1.LocalReport.Refresh()
    End Sub
End Class
