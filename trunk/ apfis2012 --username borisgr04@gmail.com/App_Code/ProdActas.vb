Imports Microsoft.VisualBasic
Imports System.Data
Imports System.ComponentModel
Public Class ProdActas
    Inherits BDDatos
    <DataObjectMethodAttribute(DataObjectMethodType.Select, True)> _
    Public Function GetbyActa(ByVal NumActa As String) As DataTable
        Me.Conectar()
        Me.querystring = "Select * from VPRODUCTOSACTAS where NroActa=:NumActa"
        Me.CrearComando(querystring)
        Me.AsignarParametroCadena(":NumActa", UCase(NumActa))
        Dim dt As DataTable = EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dt
    End Function
    Public Function GetbyPK(ByVal NumActa As String, ByVal Codigo As String) As DataTable
        Me.Conectar()
        Me.querystring = "select * from VPRODUCTOSACTAS where NroActa=:NumActa and Codigo=:Codigo"
        Me.CrearComando(querystring)
        Me.AsignarParametroCadena(":NumActa", UCase(NumActa))
        Me.AsignarParametroCadena(":Codigo", Codigo)
        Dim dt As DataTable = EjecutarConsultaDataTable()
        Me.Desconectar()
        Return dt
    End Function
    Public Function Insert(ByVal NROACTA As String, ByVal CODIGO As String, ByVal UNIDADES As Integer, ByVal PRECIOUNIT As Decimal) As String
        Try
            Conectar()
            querystring = "INSERT INTO PRODACTAS(NROACTA, CODIGO, UNIDADES, PRECIOUNIT, ESTADO, PRODSAL)VALUES(:NROACTA, :CODIGO, :UNIDADES, :PRECIOUNIT, :ESTADO, :PRODSAL)"
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":NROACTA", UCase(NROACTA))
            Me.AsignarParametroCadena(":CODIGO", UCase(CODIGO))
            Me.AsignarParametroEntero(":UNIDADES", UNIDADES)
            Me.AsignarParametroDecimal(":PRECIOUNIT", PRECIOUNIT)
            Me.AsignarParametroCadena(":ESTADO", "00")
            Me.AsignarParametroCadena(":PRODSAL", UCase(UNIDADES))
            'Throw New Exception(vComando.CommandText)
            Me.num_reg = Me.EjecutarComando()
            Me.ConfirmarTransaccion()
            Me.Msg = Me.MsgOk + "Filas Afectadas [" + Me.num_reg.ToString + "]"
            Me.lErrorG = False
        Catch ex As Exception
            Me.Msg = "Error:" + ex.Message
            Me.CancelarTransaccion()
            Me.lErrorG = True
        Finally
            Me.Desconectar()
        End Try
        Return Msg
    End Function
    <DataObjectMethodAttribute(DataObjectMethodType.Delete, True)> _
    Public Overloads Function Delete(ByVal Codigo As String, ByVal NroActa As String) As String
        Me.Conectar()
        Try
            ComenzarTransaccion()
            querystring = "DELETE FROM ProdActas Where Codigo=:Codigo And NroActa=:NroActa"
            Me.CrearComando(querystring)
            Me.AsignarParametroCadena(":Codigo", UCase(Codigo))
            Me.AsignarParametroCadena(":NroActa", UCase(NroActa))
            Me.num_reg = EjecutarComando()
            ConfirmarTransaccion()
            Me.lErrorG = False
            Me.Msg = MsgOk & "[" & num_reg & "] " & "Filas Afectadas"
        Catch ex As Exception
            CancelarTransaccion()
            Me.lErrorG = True
            Me.Msg = "Error: " & ex.Message
        Finally
            Me.Desconectar()
        End Try
        Return Msg
    End Function
End Class
