Imports System.Data
Partial Class DatosBasicos_RBodega_Default
    Inherits PaginaComun

    Dim Obj As New RBodega
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.Opcion = Me.Tit.Text
        Me.SetTitulo()

        If Not IsPostBack Then
            FillCustomerInGrid()
            ' Me.MultiView1.ActiveViewIndex = -1
        End If
    End Sub

    Protected Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs)

        Me.Oper = e.CommandName
        'MultiView1.ActiveViewIndex = -1

        Select Case Me.Oper
            Case "Nuevo"
                Me.SubT.Text = "Nuevo..."
                Me.Habilitar(True)
                Limpiar()

                Me.ModalPopupTer.Show()
                'Me.TxtCodNew.ReadOnly = True
                Me.SetFocus(Me.TxtCed)

            Case "Editar"
                Me.SubT.Text = "Editando..."
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                Me.GridView1.SelectedIndex = index

                Dim tb As DataTable = Obj.GetbyPK(GridView1.DataKeys(index).Values(0).ToString())
                If tb.Rows.Count > 0 Then
                    Me.TxtCed.Text = tb.Rows(0)("Ced_Bod").ToString
                    Me.TxtApe1.Text = tb.Rows(0)("Ape1_Bod").ToString
                    Me.TxtApe2.Text = tb.Rows(0)("Ape2_Bod").ToString
                    Me.TxtNom.Text = tb.Rows(0)("Nom_Bod").ToString
                    Me.TxtExp.Text = tb.Rows(0)("Exp_Ced_Bod").ToString
                    Me.TxtDir.Text = tb.Rows(0)("Dir_Bod").ToString
                    Me.TxtTel.Text = tb.Rows(0)("Tel_Bod").ToString
                    Me.TxtCor.Text = tb.Rows(0)("Cor_Bod").ToString

                    Me.Pk1 = tb.Rows(0)("Ced_Bod").ToString
                    Me.ModalPopupTer.Show()
                    Me.UpdatePanel2.Update()
                    Habilitar(True)
                End If
                'MultiView1.ActiveViewIndex = 0
                Me.MsgResult.Text = "Editando: Código [" + Me.TxtCed.Text + "]"

            Case "Eliminar"
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                Me.GridView1.SelectedIndex = index
                Pk1 = GridView1.DataKeys(index).Values(0).ToString()
                'Me.Hdpk2.Value = GridView1.DataKeys(index).Values(1).ToString()
                Dim tb As DataTable = Obj.GetbyPK(GridView1.DataKeys(index).Values(0).ToString())
                If tb.Rows.Count > 0 Then
                    Me.TxtCed.Text = tb.Rows(0)("Ced_Bod").ToString
                    Me.TxtApe1.Text = tb.Rows(0)("Ape1_Bod").ToString
                    Me.TxtApe2.Text = tb.Rows(0)("Ape2_Bod").ToString
                    Me.TxtNom.Text = tb.Rows(0)("Nom_Bod").ToString
                    Me.TxtExp.Text = tb.Rows(0)("Exp_Ced_Bod").ToString
                    Me.TxtDir.Text = tb.Rows(0)("Dir_Bod").ToString
                    Me.TxtTel.Text = tb.Rows(0)("Tel_Bod").ToString
                    Me.TxtCor.Text = tb.Rows(0)("Cor_Bod").ToString

                    Me.Pk1 = tb.Rows(0)("Ced_Bod").ToString
                    Me.ModalPopupTer.Show()
                    Habilitar(False)
                End If
                Me.ModalPopupTer.Show()
        End Select

    End Sub


    Protected Sub Habilitar(ByVal b As Boolean)
        Me.TxtCed.Enabled = b
        Me.TxtApe1.Enabled = b
        Me.TxtApe2.Enabled = b
        Me.TxtNom.Enabled = b
        Me.TxtDir.Enabled = b
        Me.TxtTel.Enabled = b
        Me.TxtCor.Enabled = b
        Me.TxtExp.Enabled = b
        Me.BtnGuardar.Enabled = b
        Me.BtnEliminar.Enabled = Not b
    End Sub
    Protected Sub GridView1_RowEditing(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewEditEventArgs) Handles GridView1.RowEditing
        GridView1.EditIndex = e.NewEditIndex
        FillCustomerInGrid()
    End Sub
    Private Sub FillCustomerInGrid()
        Me.GridView1.DataBind()
        'Dim cl As String = Me.CboImpto.SelectedValue
        'If Left(Me.CboImpto.SelectedValue, 2) <> Me.CmbClase.SelectedValue Then
        ' Me.CboImpto.SelectedIndex = 0
        ' cl = ""
        'End If
        'Dim dtCustomer As DataTable = Obj.GetByImpuesto(cl)
        'If (dtCustomer.Rows.Count > 0) Then
        ' GridView1.DataSource = dtCustomer
        'GridView1.DataBind()
        'Else
        'dtCustomer.Rows.Add(dtCustomer.NewRow())
        'GridView1.DataSource = dtCustomer
        'GridView1.DataBind()
        'Dim TotalColumns As Integer = GridView1.Rows(0).Cells.Count
        'GridView1.Rows(0).Cells.Clear()
        'GridView1.Rows(0).Cells.Add(New TableCell())
        ' GridView1.Rows(0).Cells(0).ColumnSpan = TotalColumns
        'GridView1.Rows(0).Cells(0).Text = "No se encontraron Registro"
        'End If
    End Sub

    Protected Sub BtnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Select Case Me.Oper
            Case "Nuevo"
                Me.MsgResult.Text = Obj.Insert(Me.TxtCed.Text, Me.TxtApe1.Text, Me.TxtApe2.Text, Me.TxtNom.Text, Me.TxtExp.Text, Me.TxtDir.Text, Me.TxtTel.Text, Me.TxtCor.Text)
            Case "Editar"
                Me.MsgResult.Text = Obj.Update(Me.TxtCed.Text, Me.TxtApe1.Text, Me.TxtApe2.Text, Me.TxtNom.Text, Me.TxtExp.Text, Me.TxtDir.Text, Me.TxtTel.Text, Me.TxtCor.Text, Me.Pk1)
        End Select

        Me.MsgBox(MsgResult, Obj.lErrorG)
        FillCustomerInGrid()
        If Obj.lErrorG = False Then
            Me.Limpiar()
        End If

    End Sub

    Protected Sub Limpiar()
        Me.TxtCed.Text = ""
        Me.TxtApe1.Text = ""
        Me.TxtApe2.Text = ""
        Me.TxtNom.Text = ""
        Me.TxtDir.Text = ""
        Me.TxtCor.Text = ""
        Me.TxtExp.Text = ""
        Me.TxtTel.Text = ""
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.MsgResult.Text = ""
        Me.MsgResult.CssClass = ""
    End Sub

    Protected Sub BtnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.MsgResult.Text = Obj.Delete(Me.TxtCed.Text)
        Me.MsgBox(MsgResult, Obj.lErrorG)
        FillCustomerInGrid()
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ModalPopupTer.Hide()
    End Sub
End Class
