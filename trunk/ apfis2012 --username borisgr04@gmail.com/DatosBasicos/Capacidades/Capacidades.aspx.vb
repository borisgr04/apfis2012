Imports System.Data
Partial Class DatosBasicos_Capacidades_Default
    Inherits PaginaComun

    Dim Obj As New Capacidades
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
                Me.TxtCodAnt.Visible = True
                Me.Label7.Visible = True
                Me.Habilitar(True)
                Limpiar()

                Me.ModalPopupTer.Show()
                'Me.TxtCodNew.ReadOnly = True
                Me.SetFocus(Me.TxtCodNew)

            Case "Editar"
                Me.SubT.Text = "Editando..."
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                Me.GridView1.SelectedIndex = index

                Dim tb As DataTable = Obj.GetbyPK(GridView1.DataKeys(index).Values(0).ToString())
                If tb.Rows.Count > 0 Then
                    Me.TxtCodNew.Text = tb.Rows(0)("Cod_Cap").ToString
                    Me.txtNomNew.Text = tb.Rows(0)("Des_Cap").ToString
                    Me.TxtCodAnt.Text = tb.Rows(0)("Cod_cap_Ant").ToString
                    Me.CmbCategoria.SelectedValue = tb.Rows(0)("Cod_Cat").ToString
                    If tb.Rows(0)("Pre_Fnd").ToString <> "" Then
                        Me.CmbFondo.SelectedValue = tb.Rows(0)("Pre_Fnd").ToString
                    End If
                    Me.TxtCodAnt.Visible = False
                    Me.Label7.Visible = False
                    Me.Pk1 = tb.Rows(0)("Cod_Cap").ToString
                    Habilitar(True)
                    Me.ModalPopupTer.Show()
                End If

                'MultiView1.ActiveViewIndex = 0
                Me.MsgResult.Text = "Editando: Código [" + Me.TxtCodNew.Text + "]"

            Case "Eliminar"
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                Me.GridView1.SelectedIndex = index
                Pk1 = GridView1.DataKeys(index).Values(0).ToString()
                'Me.Hdpk2.Value = GridView1.DataKeys(index).Values(1).ToString()
                Dim tb As DataTable = Obj.GetbyPK(GridView1.DataKeys(index).Values(0).ToString())
                If tb.Rows.Count > 0 Then
                    Me.TxtCodNew.Text = tb.Rows(0)("Cod_Cap").ToString
                    Me.txtNomNew.Text = tb.Rows(0)("Des_Cap").ToString
                    Me.TxtCodAnt.Text = tb.Rows(0)("Cod_cap_Ant").ToString
                    Me.CmbCategoria.SelectedValue = tb.Rows(0)("Cod_Cat").ToString
                    If tb.Rows(0)("Pre_Fnd").ToString <> "" Then
                        Me.CmbFondo.SelectedValue = tb.Rows(0)("Pre_Fnd").ToString
                    End If
                    Me.TxtCodAnt.Visible = True
                    Me.Label7.Visible = True
                    Me.Pk1 = tb.Rows(0)("Cod_Cap").ToString
                    Me.ModalPopupTer.Show()
                    Habilitar(False)
                End If
                Me.ModalPopupTer.Show()
                'MultiView1.ActiveViewIndex = 0




        End Select

    End Sub


    Protected Sub Habilitar(ByVal b As Boolean)
        Me.TxtCodNew.Enabled = b
        Me.txtNomNew.Enabled = b
        Me.TxtCodAnt.Enabled = b
        Me.CmbFondo.Enabled = b
        Me.CmbCategoria.Enabled = b
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
                Me.MsgResult.Text = Obj.Insert(Me.TxtCodNew.Text, Me.txtNomNew.Text, Me.CmbCategoria.SelectedValue, Me.TxtCodAnt.Text, Me.CmbFondo.SelectedValue)
            Case "Editar"
                Me.MsgResult.Text = Obj.Update(Me.TxtCodNew.Text, Me.txtNomNew.Text, Me.CmbCategoria.SelectedValue, Me.TxtCodAnt.Text, Me.CmbFondo.SelectedValue, Me.Pk1)
        End Select

        Me.MsgBox(MsgResult, Obj.lErrorG)
        FillCustomerInGrid()
        If Obj.lErrorG = False Then
            Me.Limpiar()
        End If

    End Sub

    Protected Sub Limpiar()
        Me.TxtCodNew.Text = ""
        Me.txtNomNew.Text = ""
        Me.TxtCodAnt.Text = ""
        'Me.MultiView1.ActiveViewIndex = -1
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.MsgResult.Text = ""
        Me.MsgResult.CssClass = ""
    End Sub

    Protected Sub BtnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.MsgResult.Text = Obj.Delete(Me.TxtCodNew.Text)
        Me.MsgBox(MsgResult, Obj.lErrorG)
        FillCustomerInGrid()
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ModalPopupTer.Hide()
    End Sub
End Class
