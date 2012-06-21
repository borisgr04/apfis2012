Imports Microsoft.Reporting.WebForms
Imports System.Data

Partial Class Consultas_Inventario_Inventario
    Inherits PaginaComun

    Protected Sub Page_Load1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.TxtF1.Text = Today.ToShortDateString
        Me.TxtFf.Text = Today.AddMonths(1)
        Me.TxtProd.Text = "%"

        'Dim Parm(0) As ReportParameter
        'Parm(0) = New ReportParameter("Titulo", "Del " + (Me.TxtF1.Text) + " Al " + (Me.TxtFf.Text))
        'ReportViewer2.LocalReport.SetParameters(Parm)
    End Sub


    Protected Sub BtnBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        'ReportViewer2.LocalReport.Refresh()
        'Dim Parm(0) As ReportParameter
        'Parm(0) = New ReportParameter("Titulo", "Del " + (Me.TxtF1.Text) + " Al " + (Me.TxtFf.Text))
        'ReportViewer2.LocalReport.SetParameters(Parm)

        

        
    End Sub
End Class
